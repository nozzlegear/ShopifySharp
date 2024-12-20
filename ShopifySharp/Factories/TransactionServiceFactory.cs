#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

public interface ITransactionServiceFactory : IServiceFactory<ITransactionService>;

public class TransactionServiceFactory : ITransactionServiceFactory
{
    private readonly IShopifyDomainUtility? _shopifyDomainUtility;
    private readonly IRequestExecutionPolicy? _requestExecutionPolicy;
    private readonly IServiceProvider? _serviceProvider;

    // ReSharper disable ConvertToPrimaryConstructor
    public TransactionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy, IShopifyDomainUtility? shopifyDomainUtility = null)
    {
        _shopifyDomainUtility = shopifyDomainUtility;
        _requestExecutionPolicy = requestExecutionPolicy;
    }

    public TransactionServiceFactory(IServiceProvider serviceProvider)
    {
        _shopifyDomainUtility = InternalServiceResolver.GetService<IShopifyDomainUtility>(serviceProvider);
        _requestExecutionPolicy = InternalServiceResolver.GetService<IRequestExecutionPolicy>(serviceProvider);
        _serviceProvider = serviceProvider;
    }

    /// <inheritDoc />
    public virtual ITransactionService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual ITransactionService Create(ShopifyApiCredentials credentials)
    {
        ITransactionService service = new TransactionService(credentials, _shopifyDomainUtility);

        if (_requestExecutionPolicy is not null)
            service.SetExecutionPolicy(_requestExecutionPolicy);

        return service;
    }
}
