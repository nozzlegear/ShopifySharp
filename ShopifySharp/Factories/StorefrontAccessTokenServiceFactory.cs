#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

public interface IStorefrontAccessTokenServiceFactory : IServiceFactory<IStorefrontAccessTokenService>;

public class StorefrontAccessTokenServiceFactory : IStorefrontAccessTokenServiceFactory
{
    private readonly IShopifyDomainUtility? _shopifyDomainUtility;
    private readonly IRequestExecutionPolicy? _requestExecutionPolicy;
    private readonly IServiceProvider? _serviceProvider;

    // ReSharper disable ConvertToPrimaryConstructor
    public StorefrontAccessTokenServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy, IShopifyDomainUtility? shopifyDomainUtility = null)
    {
        _shopifyDomainUtility = shopifyDomainUtility;
        _requestExecutionPolicy = requestExecutionPolicy;
    }

    public StorefrontAccessTokenServiceFactory(IServiceProvider serviceProvider)
    {
        _shopifyDomainUtility = InternalServiceResolver.GetService<IShopifyDomainUtility>(serviceProvider);
        _requestExecutionPolicy = InternalServiceResolver.GetService<IRequestExecutionPolicy>(serviceProvider);
        _serviceProvider = serviceProvider;
    }

    /// <inheritDoc />
    public virtual IStorefrontAccessTokenService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual IStorefrontAccessTokenService Create(ShopifyApiCredentials credentials)
    {
        IStorefrontAccessTokenService service = new StorefrontAccessTokenService(credentials, _shopifyDomainUtility);

        if (_requestExecutionPolicy is not null)
            service.SetExecutionPolicy(_requestExecutionPolicy);

        return service;
    }
}
