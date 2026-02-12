#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using JetBrains.Annotations;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

public interface ISmartCollectionServiceFactory : IServiceFactory<ISmartCollectionService>;

[PublicAPI]
public class SmartCollectionServiceFactory : ISmartCollectionServiceFactory
{
    private readonly IShopifyDomainUtility? _shopifyDomainUtility;
    private readonly IRequestExecutionPolicy? _requestExecutionPolicy;
    private readonly IServiceProvider? _serviceProvider;

    // ReSharper disable ConvertToPrimaryConstructor
    public SmartCollectionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy, IShopifyDomainUtility? shopifyDomainUtility = null)
    {
        _shopifyDomainUtility = shopifyDomainUtility;
        _requestExecutionPolicy = requestExecutionPolicy;
    }

    public SmartCollectionServiceFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _requestExecutionPolicy = InternalServiceResolver.GetService<IRequestExecutionPolicy>(serviceProvider);
    }

    /// <inheritDoc />
    public virtual ISmartCollectionService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual ISmartCollectionService Create(ShopifyApiCredentials credentials)
    {
        ISmartCollectionService service = _serviceProvider is not null
            ? new SmartCollectionService(credentials, _serviceProvider)
            : new SmartCollectionService(credentials, _shopifyDomainUtility);

        if (_requestExecutionPolicy is not null)
            service.SetExecutionPolicy(_requestExecutionPolicy);

        return service;
    }
}
