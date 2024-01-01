using ShopifySharp.Infrastructure;
using ShopifySharp.Utilities;

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

public class TestDomainUtility : IShopifyDomainUtility
{
    /// <inheritdoc />
    public Uri BuildShopDomainUri(string shopDomain)
    {
        throw new TestException();
    }

    /// <inheritdoc />
    public Task<bool> IsValidShopDomainAsync(string shopDomain, CancellationToken cancellationToken = default)
    {
        throw new TestException();
    }
}
