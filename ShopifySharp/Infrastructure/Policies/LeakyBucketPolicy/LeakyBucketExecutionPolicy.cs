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

        private readonly Func<RequestContext> _getRequestContext;

        private static readonly TimeSpan DefaultRetryDelay = TimeSpan.FromSeconds(1);

        private readonly ResponseClassifier _responseClassifier;

        /// <summary>
        /// Creates a new LeakyBucketExecutionPolicy.
        /// It is not recommended to create multiple instances for different access tokens because each instance maintain that leaky bucket state
        /// and is not aware of other instances
        /// </summary>
        /// <param name="retryOnlyIfLeakyBucketFull">
        /// Whether the policy should consider a response retriable only if it was rate limited and Shopify explicitly
        /// indicates that the rate limit was reached. Temporary service interruptions (such as 503 Server Unavailable)
        /// and unexpected rate limit responses will not be retried and instead will throw an exception.
        /// </param>
        /// <param name="getRequestContext">Indicates the current request context, either Foreground or Background.
        /// Foreground requests will be prioritized to execute before any background requests can run.
        /// RequestContext.Foreground can be used for requests where a user is waiting (e.g loading a web page to show results of query).
        /// RequestContext.Background can be used for background requests triggered by job, where no user is waiting.
        /// By default, all requests are served in FIFO order</param>
        public LeakyBucketExecutionPolicy(bool retryOnlyIfLeakyBucketFull = true, Func<RequestContext> getRequestContext = null)
        {
            _responseClassifier = new ResponseClassifier(!retryOnlyIfLeakyBucketFull, 0);
            _getRequestContext = getRequestContext ?? (() => RequestContext.Foreground);
        }

        /// <summary>
        /// Creates a new execution policy using the options given. Note: it is recommended to use only execution policy instance per access token if possible,
        /// because each instance maintains its own leaky bucket state and is not aware of other instances.
        /// </summary>
        /// <param name="maxRetriesPerNonLimitedRequest">
        /// The policy will retry common HTTP request failures such as temporary 503 Server Unavailable responses for
        /// a total of up to <paramref name="maxRetriesPerNonLimitedRequest"/> times. This number is independent of the
        /// retries that occur due to the leaky bucket rate limit.
        /// </param>
        /// <param name="retryUnexpectedRateLimitResponse">
        /// Whether the policy should consider a response retriable when it was unexpectedly rate limited. This can
        /// happen, for example, if one tries to create too many Shopify products too quickly on a development store.
        /// Shopify will return a 429 Too Many Requests status code, despite the leaky bucket not reaching the API rate
        /// limit.
        /// </param>
        /// <param name="getRequestContext">Indicates the current request context, either Foreground or Background.
        /// Foreground requests will be prioritized to execute before any background requests can run.
        /// RequestContext.Foreground can be used for requests where a user is waiting (e.g loading a web page to show results of query).
        /// RequestContext.Background can be used for background requests triggered by job, where no user is waiting.
        /// By default, all requests are served in FIFO order</param>
        public LeakyBucketExecutionPolicy(int maxRetriesPerNonLimitedRequest, bool retryUnexpectedRateLimitResponse = false, Func<RequestContext> getRequestContext = null)
        {
            _responseClassifier = new ResponseClassifier(retryUnexpectedRateLimitResponse, maxRetriesPerNonLimitedRequest);
            _getRequestContext = getRequestContext ?? (() => RequestContext.Foreground);
        }

        public async Task<RequestResult<T>> Run<T>(CloneableRequestMessage baseRequest, ExecuteRequestAsync<T> executeRequestAsync, CancellationToken cancellationToken, int? graphqlQueryCost = null)
        {
            var accessToken = GetAccessToken(baseRequest);
            var bucket = accessToken == null ? null : _shopAccessTokenToLeakyBucket.GetOrAdd(accessToken, _ => new MultiShopifyAPIBucket(_getRequestContext));
            var apiType = APIType.RESTAdmin;

            if (baseRequest?.RequestUri?.AbsolutePath.EndsWith("graphql.json") == true)
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
            CloneableRequestMessage baseRequest
        )
        {
            var totalRetriesDueToServiceUnavailableResponse = 0;

            while (true)
            {
                // TODO: add a check to see if the request should be cloned, so the clone can be skipped on the first request
                using var request = await baseRequest.CloneAsync();

                if (bucket != null)
                {
                    await bucket.WaitForAvailableGraphQLPartnerAsync(cancellationToken);
                }

                try
                {
                    return await executeRequestAsync(request);
                }
                catch (ShopifyException ex)
                {
                    if (!_responseClassifier.IsRetriableException(ex, totalRetriesDueToServiceUnavailableResponse))
                    {
                        throw;
                    }

                    totalRetriesDueToServiceUnavailableResponse++;
                    await Task.Delay(DefaultRetryDelay, cancellationToken);
                }
            }
        }

        private async Task<RequestResult<T>> ExecuteGraphAdminRequest<T>(
            ExecuteRequestAsync<T> executeRequestAsync,
            CancellationToken cancellationToken,
            int graphqlQueryCost,
            MultiShopifyAPIBucket bucket,
            CloneableRequestMessage baseRequest
        )
        {
            var totalRetriesDueToServiceUnavailableResponse = 0;

            while (true)
            {
                // TODO: add a check to see if the request should be cloned, so the clone can be skipped on the first request
                var request = await baseRequest.CloneAsync();

                if (bucket != null)
                {
                    await bucket.WaitForAvailableGraphQLAsync(graphqlQueryCost, cancellationToken);
                }

                RequestResult<T> result;

                try
                {
                    result = await executeRequestAsync(request);
                }
                catch (ShopifyException ex)
                {
                    if (!_responseClassifier.IsRetriableException(ex, totalRetriesDueToServiceUnavailableResponse))
                    {
                        throw;
                    }

                    totalRetriesDueToServiceUnavailableResponse++;
                    await Task.Delay(DefaultRetryDelay, cancellationToken);
                    continue;
                }

                var jsonDoc = result.Result switch
                {
                    System.Text.Json.JsonDocument systemTextJsonDoc => systemTextJsonDoc,
                    JToken jsonNetDoc => System.Text.Json.JsonDocument.Parse(jsonNetDoc.ToString(Newtonsoft.Json.Formatting.None)),
                    _ => throw new Exception($"Unexpected non json result of type {result.Response.GetType().Name} for GraphQL Admin API")
                };

                if (bucket != null)
                {
                    var graphBucketState = result.GetGraphQLBucketState(jsonDoc);
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
                    // The graph response's error code indicates the request was throttled. Retry the request.
                    await Task.Delay(DefaultRetryDelay, cancellationToken);
                }
                else
                {
                    return result;
                }
            }
        }

        private async Task<RequestResult<T>> ExecuteRestAdminRequest<T>(
            ExecuteRequestAsync<T> executeRequestAsync,
            CancellationToken cancellationToken,
            MultiShopifyAPIBucket bucket,
            CloneableRequestMessage baseRequest
        )
        {
            var totalRetriesDueToServiceUnavailableResponse = 0;

            while (true)
            {
                // TODO: add a check to see if the request should be cloned, so the clone can be skipped on the first request
                using var request = await baseRequest.CloneAsync();

                if (bucket != null)
                {
                    await bucket.WaitForAvailableRESTAsync(cancellationToken);
                }

                RequestResult<T> result;

                try
                {
                    result = await executeRequestAsync(request);
                }
                catch (ShopifyException ex)
                {
                    if (!_responseClassifier.IsRetriableException(ex, totalRetriesDueToServiceUnavailableResponse))
                    {
                        throw;
                    }

                    totalRetriesDueToServiceUnavailableResponse++;
                    await Task.Delay(DefaultRetryDelay, cancellationToken);
                    continue;
                }

                if (bucket != null)
                {
                    var restBucketState = result.GetRestBucketState();
                    if (restBucketState != null)
                    {
                        bucket.SetRESTBucketState(restBucketState.MaxAvailable, restBucketState.MaxAvailable - restBucketState.CurrentlyUsed);
                    }
                }

                return result;
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
