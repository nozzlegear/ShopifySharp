using Flurl.Http;
using System.Net.Http;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    public class DefaultRequestExecutionPolicy : IRequestExecutionPolicy
    {
        public async Task<T> Run<T>(IFlurlClient request, JsonContent bodyContent, ExecuteRequestAsync<T> executeRequestAsync)
        {
            var fullResult = await executeRequestAsync(request, bodyContent);

            return fullResult.Result;
        }
    }
}
