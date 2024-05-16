using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

// ReSharper disable once CheckNamespace
namespace ShopifySharp;

public class DefaultRequestExecutionPolicy : IRequestExecutionPolicy
{
    public async Task<RequestResult<T>> Run<T>(CloneableRequestMessage baseRequestMessage, ExecuteRequestAsync<T> executeRequestAsync, CancellationToken cancellationToken, int? graphqlQueryCost = null)
    {
        return await executeRequestAsync(baseRequestMessage);
    }
}
