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
            RequestResult<T> fullResult = null;

            while (fullResult == null)
            {
                try
                {
                    fullResult = await executeRequestAsync(request, bodyContent);
                }
                catch (ShopifyRateLimitException)
                {
                    await Task.Delay(RETRY_DELAY);
                }
            }

            return fullResult.Result;
        }
    }
}
