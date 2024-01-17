using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net;
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

        /// An arbitrary magic number that short-circuits 503 Server Unavailable retries, preventing applications getting
        /// stuck in endless retry loops in cases where Shopify is down.
        private const int MaxServiceUnavailableRetries = 10;

        private static ConcurrentDictionary<string, MultiShopifyAPIBucket> _shopAccessTokenToLeakyBucket = new ConcurrentDictionary<string, MultiShopifyAPIBucket>();

        private readonly bool _retryRESTOnlyIfLeakyBucketFull;

        private readonly Func<RequestContext> _getRequestContext;

        private static readonly TimeSpan DefaultRetryDelay = TimeSpan.FromSeconds(1);

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
        /// Foreground requests will be prioritized to execute before any background requests can run.
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
            var apiType = APIType.RESTAdmin;

            if (baseRequest.RequestUri.AbsolutePath.EndsWith("graphql.json"))
                apiType = baseRequest.RequestUri.Host == "partners.shopify.com" ? APIType.GraphQLPartner : APIType.GraphQLAdmin;

            return apiType switch
            {
                APIType.GraphQLAdmin => await ExecuteGraphAdminRequest(
                    executeRequestAsync,
                    cancellationToken,
                    // If the user didn't pass a request query cost, we assume a cost of 50
                    graphqlQueryCost ?? 50,
                    bucket,
                    baseRequest),
                APIType.RESTAdmin => await ExecuteRestAdminRequest(
                    executeRequestAsync,
                    cancellationToken,
                    bucket,
                    baseRequest),
                APIType.GraphQLPartner => await ExecuteGraphPartnerRequest(
                    executeRequestAsync,
                    cancellationToken,
                    bucket,
                    baseRequest),
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private async Task<RequestResult<T>> ExecuteGraphPartnerRequest<T>(
            ExecuteRequestAsync<T> executeRequestAsync,
            CancellationToken cancellationToken,
            MultiShopifyAPIBucket bucket,
            CloneableRequestMessage request,
            int totalRetriesDueToServiceUnavailableResponse = 0
        )
        {
            // TODO: add a check to see if the request should be cloned, so the clone can be skipped on the first request
            request = request.Clone();

            if (bucket != null)
            {
                await bucket.WaitForAvailableGraphQLPartnerAsync(cancellationToken);
            }

            try
            {
                return await executeRequestAsync(request);
            }
            catch (ShopifyHttpException ex) when (ex.HttpStatusCode == HttpStatusCode.ServiceUnavailable && totalRetriesDueToServiceUnavailableResponse <= MaxServiceUnavailableRetries)
            {
                // 503 Service Unavailable errors should be retried until we reach the maximum amount of retries
                return await ExecuteGraphPartnerRequest(executeRequestAsync, cancellationToken, bucket, request, totalRetriesDueToServiceUnavailableResponse + 1);
            }
            catch (ShopifyRateLimitException ex) when (ex.Reason == ShopifyRateLimitReason.BucketFull || !_retryRESTOnlyIfLeakyBucketFull)
            {
                await Task.Delay(DefaultRetryDelay, cancellationToken);
                return await ExecuteGraphPartnerRequest(executeRequestAsync, cancellationToken, bucket, request);
            }
        }

        private static async Task<RequestResult<T>> ExecuteGraphAdminRequest<T>(
            ExecuteRequestAsync<T> executeRequestAsync,
            CancellationToken cancellationToken,
            int graphqlQueryCost,
            MultiShopifyAPIBucket bucket,
            CloneableRequestMessage request,
            int totalRetriesDueToServiceUnavailableResponse = 0
        )
        {
            // TODO: add a check to see if the request should be cloned, so the clone can be skipped on the first request
            request = request.Clone();

            if (bucket != null)
            {
                await bucket.WaitForAvailableGraphQLAsync(graphqlQueryCost, cancellationToken);
            }

            RequestResult<T> graphRes;

            try
            {
                graphRes = await executeRequestAsync(request);
            }
            catch (ShopifyHttpException ex) when (ex.HttpStatusCode == HttpStatusCode.ServiceUnavailable && totalRetriesDueToServiceUnavailableResponse <= MaxServiceUnavailableRetries)
            {
                // 503 Service Unavailable errors should be retried until we reach the maximum amount of retries
                await Task.Delay(DefaultRetryDelay, cancellationToken);
                return await ExecuteGraphAdminRequest(executeRequestAsync,
                    cancellationToken,
                    graphqlQueryCost,
                    bucket,
                    request,
                    totalRetriesDueToServiceUnavailableResponse + 1
                );
            }

            var jsonDoc = graphRes.Result switch
            {
                System.Text.Json.JsonDocument systemTextJsonDoc => systemTextJsonDoc,
                JToken jsonNetDoc => System.Text.Json.JsonDocument.Parse(jsonNetDoc.ToString(Newtonsoft.Json.Formatting.None)),
                _ => throw new Exception($"Unexpected non json result of type {graphRes.Response.GetType().Name} for GraphQL Admin API")
            };

            if (bucket != null)
            {
                var graphBucketState = graphRes.GetGraphQLBucketState(jsonDoc);
                if (graphBucketState != null)
                {
                    var actualQueryCost = graphBucketState.ActualQueryCost ?? graphqlQueryCost;
                    var refund = graphqlQueryCost- actualQueryCost;//may be negative if user didn't supply query cost
                    bucket.SetGraphQLBucketState(graphBucketState.MaxAvailable, graphBucketState.RestoreRate, graphBucketState.CurrentlyAvailable, refund);

                    //The user might have supplied no cost or an invalid cost
                    //We fix the query cost so the correct value is used if a retry is needed
                    graphqlQueryCost = graphBucketState.RequestedQueryCost;
                }
            }

            if (jsonDoc.RootElement.TryGetProperty("errors", out var errors) &&
                errors.EnumerateArray().Any(error => error.TryGetProperty("extensions", out var extensions) &&
                                                     extensions.TryGetProperty("code", out var code) &&
                                                     code.GetString() == "THROTTLED"))
            {
                await Task.Delay(DefaultRetryDelay, cancellationToken);
                return await ExecuteGraphAdminRequest<T>(
                    executeRequestAsync,
                    cancellationToken,
                    graphqlQueryCost,
                    bucket,
                    request
                );
            }

            return graphRes;
        }

        private async Task<RequestResult<T>> ExecuteRestAdminRequest<T>(
            ExecuteRequestAsync<T> executeRequestAsync,
            CancellationToken cancellationToken,
            MultiShopifyAPIBucket bucket,
            CloneableRequestMessage request,
            int totalRetriesDueToServiceUnavailableResponse = 0
        )
        {
            // TODO: add a check to see if the request should be cloned, so the clone can be skipped on the first request
            request = request.Clone();

            if (bucket != null)
            {
                await bucket.WaitForAvailableRESTAsync(cancellationToken);
            }

            RequestResult<T> restRes;

            try
            {
                restRes = await executeRequestAsync(request);
            }
            catch (ShopifyHttpException ex) when (ex.HttpStatusCode == HttpStatusCode.ServiceUnavailable && totalRetriesDueToServiceUnavailableResponse <= MaxServiceUnavailableRetries)
            {
                // 503 Service Unavailable errors should be retried until we reach the maximum amount of retries
                await Task.Delay(DefaultRetryDelay, cancellationToken);
                return await ExecuteRestAdminRequest(executeRequestAsync,
                    cancellationToken,
                    bucket,
                    request,
                    totalRetriesDueToServiceUnavailableResponse + 1);
            }
            catch (ShopifyRateLimitException ex) when (ex.Reason == ShopifyRateLimitReason.BucketFull || !_retryRESTOnlyIfLeakyBucketFull)
            {
                await Task.Delay(DefaultRetryDelay, cancellationToken);
                return await ExecuteRestAdminRequest(executeRequestAsync, cancellationToken, bucket, request);
            }

            if (bucket != null)
            {
                var restBucketState = restRes.GetRestBucketState();
                if (restBucketState != null)
                    bucket.SetRESTBucketState(restBucketState.MaxAvailable,
                        restBucketState.MaxAvailable - restBucketState.CurrentlyUsed);
            }

            return restRes;
        }

        private string GetAccessToken(HttpRequestMessage client)
        {
            return client.Headers.TryGetValues(REQUEST_HEADER_ACCESS_TOKEN, out var values) ?
                values.FirstOrDefault() :
                null;
        }
    }
}
