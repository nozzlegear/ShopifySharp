using System;
using System.Net.Http;
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
        private static readonly TimeSpan RETRY_DELAY = TimeSpan.FromMilliseconds(500);

        private readonly bool _retryOnlyIfLeakyBucketFull;

        public RetryExecutionPolicy(bool retryOnlyIfLeakyBucketFull = true)
        {
            _retryOnlyIfLeakyBucketFull = retryOnlyIfLeakyBucketFull;
        }

        public async Task<RequestResult<T>> Run<T>(CloneableRequestMessage baseRequest, ExecuteRequestAsync<T> executeRequestAsync, CancellationToken cancellationToken, int? graphqlQueryCost = null)
        {
            while (true)
            {
                var request = baseRequest.Clone();

                try
                {
                    var fullResult = await executeRequestAsync(request);

                    return fullResult;
                }
                catch (ShopifyRateLimitException ex) when (ex.Reason == ShopifyRateLimitReason.BucketFull || !_retryOnlyIfLeakyBucketFull)
                {
                    //Only retry if breach caused by full bucket
                    //Other limits will bubble the exception because it's not clear how long the program should wait
                    //Even if there is a Retry-After header, we probably don't want the thread to sleep for potentially many hours
                    await Task.Delay(RETRY_DELAY, cancellationToken);
                }
            }
        }
    }
}
