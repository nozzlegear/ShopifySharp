using System.Net.Http;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    public class DefaultRequestExecutionPolicy : IRequestExecutionPolicy
    {
        public async Task<RequestResult<T>> Run<T>(CloneableRequestMessage request, ExecuteRequestAsync<T> executeRequestAsync)
        {
            var fullResult = await executeRequestAsync(request);

            return fullResult;
        }
    }
}
