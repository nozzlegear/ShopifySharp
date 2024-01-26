using System;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// See https://help.shopify.com/api/guides/api-call-limit
    /// </summary>
    public class RetryExecutionPolicy : IRequestExecutionPolicy
    {
        private static readonly TimeSpan RetryDelay = TimeSpan.FromMilliseconds(500);

        private readonly ResponseClassifier _responseClassifier;

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
        public RetryExecutionPolicy(int maxRetriesPerNonLimitedRequest, bool retryUnexpectedRateLimitResponse = false)
        {
            _responseClassifier = new ResponseClassifier(retryUnexpectedRateLimitResponse, maxRetriesPerNonLimitedRequest);
        }

        /// <param name="retryOnlyIfLeakyBucketFull">
        /// Whether the policy should consider a response retriable only if it was rate limited and Shopify explicitly
        /// indicates that the rate limit was reached. Temporary service interruptions (such as 503 Server Unavailable)
        /// and unexpected rate limit responses will not be retried and instead will throw an exception.
        /// </param>
        public RetryExecutionPolicy(bool retryOnlyIfLeakyBucketFull = true)
        {
            _responseClassifier = new ResponseClassifier(!retryOnlyIfLeakyBucketFull, 0);
        }

        public async Task<RequestResult<T>> Run<T>(
            CloneableRequestMessage baseRequest,
            ExecuteRequestAsync<T> executeRequestAsync,
            CancellationToken cancellationToken,
            int? graphqlQueryCost = null
        )
        {
            var totalRetriesDueToServiceUnavailableResponse = 0;
            graphqlQueryCost = graphqlQueryCost ?? 0;

            while (true)
            {
                using var request = await baseRequest.CloneAsync();

                try
                {
                    var fullResult = await executeRequestAsync(request);

                    return fullResult;
                }
                catch (ShopifyException ex)
                {
                    if (!_responseClassifier.IsRetriableException(ex, totalRetriesDueToServiceUnavailableResponse))
                    {
                        throw;
                    }

                    totalRetriesDueToServiceUnavailableResponse++;
                    await Task.Delay(RetryDelay, cancellationToken);
                }
            }
        }
    }
}
