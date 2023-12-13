using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Infrastructure;
using Newtonsoft.Json.Linq;

namespace ShopifySharp
{
    /// <summary>
    /// An execution policy that implements Shopify API rate limits via a leaky bucket algorithm
    /// See https://shopify.dev/api/usage/rate-limits
    /// Requests are granted execution in FIFO order.
    /// The next pending request is granted execution as soon as the bucket has enough budget available
    /// </summary>
    public class LeakyBucketExecutionPolicy : IRequestExecutionPolicy
    {
        private const string REQUEST_HEADER_ACCESS_TOKEN = "X-Shopify-Access-Token";

        private static ConcurrentDictionary<string, MultiShopifyAPIBucket> _shopAccessTokenToLeakyBucket = new ConcurrentDictionary<string, MultiShopifyAPIBucket>();

        private readonly bool _retryRESTOnlyIfLeakyBucketFull;
        private readonly Func<RequestContext> _getRequestContext;

        /// <summary>
        /// Creates a new LeakyBucketExecutionPolicy.
        /// It is not recommended to create multiple instances for different access tokens because each instance maintain that leaky bucket state
        /// and is not aware of other instances
        /// </summary>
        /// <param name="retryRESTOnlyIfLeakyBucketFull">Controls when the request should be retried when a Shopify returns an HTTP 429 to a REST request.
        /// If true (default), then the policy only retries if the 429 is due to a empty bucket.
        /// If false, then the policy also retries for other types of 429. For example, Shopify will return a 429 if one tries to create too many products too quickly on dev stores
        /// </param>
        /// <param name="getRequestContext">Indicates the current request context, either Foreground or Background.
        /// Foreground requests will be priortized to execute before any background requests can run.
        /// RequestContext.Foregroud can be used for requests where a user is waiting (e.g loading a web page to show results of query).
        /// RequestContext.Background can be used for background requests triggered by job, where no user is waiting.
        /// By default, all requests are served in FIFO order</param>
        public LeakyBucketExecutionPolicy(bool retryRESTOnlyIfLeakyBucketFull = true, Func<RequestContext> getRequestContext = null)
        {
            _retryRESTOnlyIfLeakyBucketFull = retryRESTOnlyIfLeakyBucketFull;
            _getRequestContext = getRequestContext ?? new Func<RequestContext>(() => RequestContext.Foreground);
        }

        public async Task<RequestResult<T>> Run<T>(CloneableRequestMessage baseRequest, ExecuteRequestAsync<T> executeRequestAsync, CancellationToken cancellationToken, int? graphqlQueryCost = null)
        {
            var accessToken = GetAccessToken(baseRequest);
            var bucket = accessToken == null ? null : _shopAccessTokenToLeakyBucket.GetOrAdd(accessToken, _ => new MultiShopifyAPIBucket(_getRequestContext));
            APIType apiType = APIType.RESTAdmin;
            if (baseRequest.RequestUri.AbsolutePath.EndsWith("graphql.json"))
                apiType = baseRequest.RequestUri.Host == "partners.shopify.com" ? APIType.GraphQLPartner : APIType.GraphQLAdmin;

            while (true)
            {
                var request = baseRequest.Clone();

                switch (apiType)
                {
                    case APIType.GraphQLAdmin:
                        //if the user didn't pass a request query cost, we assume a cost of 50
                        graphqlQueryCost = graphqlQueryCost ?? 50;
                        if (bucket != null)
                            await bucket.WaitForAvailableGraphQLAsync(graphqlQueryCost.Value, cancellationToken);

                        var graphRes = await executeRequestAsync(request);
                        var json = graphRes.Result as JToken;
                        if (graphRes.Result is System.Text.Json.JsonDocument jsonDoc)
                            json = JToken.Parse(jsonDoc.RootElement.ToString());

                        if (bucket != null)
                        {
                            var graphBucketState = graphRes.GetGraphQLBucketState(json);
                            if (graphBucketState != null)
                            {
                                int actualQueryCost = graphBucketState.ActualQueryCost ?? graphqlQueryCost.Value;//actual query cost is null if THROTTLED
                                int refund = graphqlQueryCost.Value - actualQueryCost;//may be negative if user didn't supply query cost
                                bucket.SetGraphQLBucketState(graphBucketState.MaxAvailable, graphBucketState.RestoreRate, graphBucketState.CurrentlyAvailable, refund);

                                //The user might have supplied no cost or an invalid cost
                                //We fix the query cost so the correct value is used if a retry is needed
                                graphqlQueryCost = graphBucketState.RequestedQueryCost;
                            }
                        }

                        if (json.SelectToken("errors")
                            ?.Children()
                            .Any(r => r.SelectToken("extensions.code")?.Value<string>() == "THROTTLED")
                            == true)
                        {
                            await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
                            break;
                        }

                        return graphRes;

                    case APIType.RESTAdmin:
                        try
                        {
                            if (bucket != null)
                                await bucket.WaitForAvailableRESTAsync(cancellationToken);

                            var restRes = await executeRequestAsync(request);

                            if (bucket != null)
                            {
                                var restBucketState = restRes.GetRestBucketState();
                                if (restBucketState != null)
                                    bucket.SetRESTBucketState(restBucketState.MaxAvailable, restBucketState.MaxAvailable - restBucketState.CurrentlyUsed);
                            }

                            return restRes;
                        }
                        catch (ShopifyRateLimitException ex) when (ex.Reason == ShopifyRateLimitReason.BucketFull || !_retryRESTOnlyIfLeakyBucketFull)
                        {
                            //Only retry if breach caused by full bucket
                            //Shopify sometimes return 429 for other limits (e.g if too many variants are created)
                            await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
                            break;
                        }

                    case APIType.GraphQLPartner:
                        try
                        {
                            if (bucket != null)
                                await bucket.WaitForAvailableGraphQLPartnerAsync(cancellationToken);

                            return await executeRequestAsync(request);
                        }
                        catch (ShopifyRateLimitException)
                        {
                            await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
                            break;
                        }
                }
            }
        }

        private string GetAccessToken(HttpRequestMessage client)
        {
            return client.Headers.TryGetValues(REQUEST_HEADER_ACCESS_TOKEN, out var values) ?
                values.FirstOrDefault() :
                null;
        }
    }
}
