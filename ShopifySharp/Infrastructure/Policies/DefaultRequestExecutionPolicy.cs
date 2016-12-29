using System;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class DefaultRequestExecutionPolicy : IRequestExecutionPolicy
    {
        public async Task<T> Run<T>(ExecuteRequestAsync<T> executeRequestAsync)
        {
            return (await executeRequestAsync()).Result;
        }
    }
}
