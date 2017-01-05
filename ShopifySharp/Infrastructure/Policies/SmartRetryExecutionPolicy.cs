using RestSharp;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A retry policy that attemps to pro-actively limit the number of requests that will result in a ShopifyRateLimitException
    /// by implementing the leaky bucket algorithm.
    /// For example, if a 100 requests are created in parallel, only 40 should be immediately sent, and the subsequent 60 requests
    /// should be throttled at 1 per 500ms.
    /// 
    /// In comparison, the naive retry policy will issue the 100 requests immediately:
    /// -60 requests will fail and be retried after 500ms
    /// -59 requests will fail and be retried after 500ms
    /// -58 requests will fail and be retried after 500ms
    /// etc...
    /// The number may be different in practice, but this will certainly result in a very high number of failed requests that 
    /// can be proactively throttled instead.
    /// 
    /// See https://help.shopify.com/api/guides/api-call-limit
    /// https://en.wikipedia.org/wiki/Leaky_bucket
    /// </summary>
    public partial class SmartRetryExecutionPolicy : IRequestExecutionPolicy
    {
        private const string RESPONSE_HEADER_API_CALL_LIMIT = "X-Shopify-Shop-Api-Call-Limit";
        private const string REQUEST_HEADER_ACCESS_TOKEN = "X-Shopify-Access-Token";
        private static readonly TimeSpan THROTTLE_DELAY = TimeSpan.FromMilliseconds(500);

        private static ConcurrentDictionary<string, LeakyBucket> _shopAccessTokenToLeakyBucket = new ConcurrentDictionary<string, LeakyBucket>();

        public async Task<T> Run<T>(IRestClient client, IRestRequest request, ExecuteRequestAsync<T> executeRequestAsync)
        {
            string accessToken = this.GetAccessToken(client);
            LeakyBucket bucket = null;

            if (accessToken != null)
            {
                bucket = _shopAccessTokenToLeakyBucket.GetOrAdd(accessToken, _ => new LeakyBucket());
            }

            Start:
            if (accessToken != null)
            {
                await bucket.GrantAsync();
            }
            try
            {
                var requestResult = await executeRequestAsync();
                int? bucketContentSize = this.GetBucketContentSize(requestResult.Response);
                if (bucketContentSize != null)
                {
                    bucket?.SetContentSize(bucketContentSize.Value);
                }
                return requestResult.Result;
            }
            catch (ShopifyRateLimitException)
            {
                //An exception may still occur:
                //-Shopify may have a slightly different algorithm
                //-Shopify may change to a different algorithm in the future
                //-There may be timing and latency delays
                //-Multiple programs may use the same access token
                //-Multiple instance of the same program may use the same access token
                await Task.Delay(THROTTLE_DELAY);
                goto Start;
            }
        }

        private string GetAccessToken(IRestClient client)
        {
            return client.DefaultParameters
                        .SingleOrDefault(p => p.Type == ParameterType.HttpHeader &&
                                              p.Name == REQUEST_HEADER_ACCESS_TOKEN)
                        ?.Value
                        ?.ToString();
        }

        private int? GetBucketContentSize(IRestResponse response)
        {
            string apiCallLimitHeaderValue = response.Headers
                                                     .FirstOrDefault(p => p.Name == RESPONSE_HEADER_API_CALL_LIMIT)
                                                     ?.Value
                                                     ?.ToString();
            if (apiCallLimitHeaderValue != null)
            {
                int bucketContentSize;
                if (int.TryParse(apiCallLimitHeaderValue.Split('/').First(), out bucketContentSize))
                {
                    return bucketContentSize;
                }
            }
            return null;
        }
    }
}
