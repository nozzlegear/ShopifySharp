using Flurl.Http;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A retry policy that attemps to pro-actively limit the number of requests that will result in a ShopifyRateLimitException
    /// by implementing the leaky bucket algorithm.
    /// For example: if 100 requests are created in parallel, only 40 should be immediately sent, and the subsequent 60 requests
    /// should be throttled at 1 per 500ms.
    /// </summary>
    /// <remarks>
    /// In comparison, the naive retry policy will issue the 100 requests immediately:
    /// 60 requests will fail and be retried after 500ms,
    /// 59 requests will fail and be retried after 500ms,
    /// 58 requests will fail and be retried after 500ms.
    /// See https://help.shopify.com/api/guides/api-call-limit
    /// https://en.wikipedia.org/wiki/Leaky_bucket
    /// </remarks>
    public partial class SmartRetryExecutionPolicy : IRequestExecutionPolicy
    {
        private const string RESPONSE_HEADER_API_CALL_LIMIT = "X-Shopify-Shop-Api-Call-Limit";

        private const string REQUEST_HEADER_ACCESS_TOKEN = "X-Shopify-Access-Token";

        private static readonly TimeSpan THROTTLE_DELAY = TimeSpan.FromMilliseconds(500);

        private static ConcurrentDictionary<string, LeakyBucket> _shopAccessTokenToLeakyBucket = new ConcurrentDictionary<string, LeakyBucket>();

        public async Task<T> Run<T>(IFlurlClient request, HttpContent bodyContent, ExecuteRequestAsync<T> executeRequestAsync)
        {
            var accessToken = GetAccessToken(request);
            LeakyBucket bucket = null;

            if (accessToken != null)
            {
                bucket = _shopAccessTokenToLeakyBucket.GetOrAdd(accessToken, _ => new LeakyBucket());
            }

            while (true)
            {
                if (accessToken != null)
                {
                    await bucket.GrantAsync();
                }

                try
                {
                    var fullResult = await executeRequestAsync(request.Clone(), bodyContent);
                    int? bucketContentSize = this.GetBucketContentSize(fullResult.Response);

                    if (bucketContentSize != null)
                    {
                        bucket?.SetContentSize(bucketContentSize.Value);
                    }

                    return fullResult.Result;
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
                }
            }
        }

        private string GetAccessToken(IFlurlClient client)
        {
            var headerValues = client.HttpClient.DefaultRequestHeaders.GetValues(REQUEST_HEADER_ACCESS_TOKEN);

            return headerValues.FirstOrDefault();
        }

        private int? GetBucketContentSize(HttpResponseMessage response)
        {
            var headers = response.Headers.FirstOrDefault(kvp => kvp.Key == RESPONSE_HEADER_API_CALL_LIMIT);
            var apiCallLimitHeaderValue = headers.Value?.FirstOrDefault();

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
