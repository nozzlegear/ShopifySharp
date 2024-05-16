using ShopifySharp.Infrastructure;
using ShopifySharp.Utilities;

namespace ShopifySharp.Extensions.DependencyInjection.Tests;

public class TestException : Exception;

public class TestRequestExecutionPolicy : IRequestExecutionPolicy
{
    public Task<RequestResult<T>> Run<T>(
        CloneableRequestMessage baseRequestMessage,
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

public class TestServiceLifetime<T> where T : class
{
    public readonly T? Instance1, Instance2;

    public TestServiceLifetime(T? instance1, T? instance2)
    {
        Instance1 = instance1;
        Instance2 = instance2;
    }
}
