using ShopifySharp.Infrastructure;

namespace ShopifySharp.Extensions.DependencyInjection.Tests;

public class TestException : Exception;

public class TestRequestExecutionPolicy : IRequestExecutionPolicy
{
    public Task<RequestResult<T>> Run<T>(
        CloneableRequestMessage requestMessage,
        ExecuteRequestAsync<T> executeRequestAsync,
        CancellationToken cancellationToken,
        int? graphqlQueryCost = null
    )
    {
        throw new TestException();
    }
}
