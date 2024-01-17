using System;
using System.Net;
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

        private const int MaxServiceUnavailableRetries = 0;

        private readonly bool _retryOnlyIfLeakyBucketFull;

        public RetryExecutionPolicy(bool retryOnlyIfLeakyBucketFull = true)
        {
            _retryOnlyIfLeakyBucketFull = retryOnlyIfLeakyBucketFull;
        }

        public async Task<RequestResult<T>> Run<T>(CloneableRequestMessage baseRequest,
            ExecuteRequestAsync<T> executeRequestAsync,
            CancellationToken cancellationToken,
            int? graphqlQueryCost = null
        )
        {
            return await ExecuteWithRetryAsync(
                executeRequestAsync,
                cancellationToken,
                baseRequest,
                graphqlQueryCost ?? 0
            );
        }

        private async Task<RequestResult<T>> ExecuteWithRetryAsync<T>(
            ExecuteRequestAsync<T> executeRequestAsync,
            CancellationToken cancellationToken,
            CloneableRequestMessage request,
            int graphqlQueryCost,
            int totalRetriesDueToServiceUnavailableResponse = 0
        )
        {
            request = request.Clone();

            try
            {
                var fullResult = await executeRequestAsync(request);

                return fullResult;
            }
            catch (ShopifyHttpException ex) when (ex.HttpStatusCode == HttpStatusCode.ServiceUnavailable && totalRetriesDueToServiceUnavailableResponse <= MaxServiceUnavailableRetries)
            {
                await Task.Delay(RETRY_DELAY, cancellationToken);
                return await ExecuteWithRetryAsync(
                    executeRequestAsync,
                    cancellationToken,
                    request,
                    graphqlQueryCost,
                    totalRetriesDueToServiceUnavailableResponse + 1
                );
            }
            catch (ShopifyRateLimitException ex) when (ex.Reason == ShopifyRateLimitReason.BucketFull || !_retryOnlyIfLeakyBucketFull)
            {
                //Only retry if breach caused by full bucket
                //Other limits will bubble the exception because it's not clear how long the program should wait
                //Even if there is a Retry-After header, we probably don't want the thread to sleep for potentially many hours
                await Task.Delay(RETRY_DELAY, cancellationToken);
                return await ExecuteWithRetryAsync(
                    executeRequestAsync,
                    cancellationToken,
                    request,
                    graphqlQueryCost
                );
            }
        }
    }
}
