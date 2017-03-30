using Flurl.Http;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// See https://help.shopify.com/api/guides/api-call-limit
    /// </summary>
    public class RetryExecutionPolicy : IRequestExecutionPolicy
    {
        private static readonly TimeSpan RETRY_DELAY = TimeSpan.FromMilliseconds(500);

        public async Task<T> Run<T>(IFlurlClient request, HttpContent bodyContent, ExecuteRequestAsync<T> executeRequestAsync)
        {
            while (true)
            {
                try
                {
                    var fullResult = await executeRequestAsync(request, bodyContent);

                    return fullResult.Result;
                }
                catch (ShopifyRateLimitException)
                {
                    await Task.Delay(RETRY_DELAY);
                }
            }
        }
    }
}
