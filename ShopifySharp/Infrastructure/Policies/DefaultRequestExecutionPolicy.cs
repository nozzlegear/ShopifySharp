using RestSharp;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class DefaultRequestExecutionPolicy : IRequestExecutionPolicy
    {
        public async Task<T> Run<T>(IRestClient client, IRestRequest request, ExecuteRequestAsync<T> executeRequestAsync)
        {
            return (await executeRequestAsync()).Result;
        }
    }
}
