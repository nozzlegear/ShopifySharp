using Flurl.Http;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class DefaultRequestExecutionPolicy : IRequestExecutionPolicy
    {
        public async Task<T> Run<T>(IFlurlClient request, HttpContent bodyContent, ExecuteRequestAsync<T> executeRequestAsync)
        {
            var fullResult = await executeRequestAsync(request, bodyContent);

            return fullResult.Result;
        }
    }
}
