using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

// ReSharper disable once CheckNamespace
namespace ShopifySharp;

public class DefaultRequestExecutionPolicy : IRequestExecutionPolicy
{
    public async Task<RequestResult<T>> Run<T>(CloneableRequestMessage request, ExecuteRequestAsync<T> executeRequestAsync, CancellationToken cancellationToken, int? graphqlQueryCost = null)
    {
        var fullResult = await executeRequestAsync(request);

        return fullResult;
    }
}
