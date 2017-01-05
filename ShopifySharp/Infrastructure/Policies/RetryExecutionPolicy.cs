using RestSharp;
using System;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// See https://help.shopify.com/api/guides/api-call-limit
    /// </summary>
    public class RetryExecutionPolicy : IRequestExecutionPolicy
    {
        private static readonly TimeSpan RETRY_DELAY = TimeSpan.FromMilliseconds(500);

        public async Task<T> Run<T>(IRestClient client, IRestRequest request, ExecuteRequestAsync<T> executeRequestAsync)
        {
            Start:
            try
            {
                return (await executeRequestAsync()).Result;
            }
            catch (ShopifyRateLimitException)
            {
                await Task.Delay(RETRY_DELAY);
                goto Start;
            }
        }
    }
}
