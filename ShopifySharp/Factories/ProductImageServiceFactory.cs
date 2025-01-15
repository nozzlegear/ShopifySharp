#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

[Obsolete("Shopify has deprecated the REST API for product images. This service is deprecated and will be removed in a future version of ShopifySharp. Use ShopifySharp's GraphService to manage product images via the GraphQL API, and check https://github.com/nozzlegear/shopifysharp for a migration guide.")]
public interface IProductImageServiceFactory : IServiceFactory<IProductImageService>;

[Obsolete("Shopify has deprecated the REST API for product images. This service is deprecated and will be removed in a future version of ShopifySharp. Use ShopifySharp's GraphService to manage product images via the GraphQL API, and check https://github.com/nozzlegear/shopifysharp for a migration guide.")]
public class ProductImageServiceFactory : IProductImageServiceFactory
{
    private readonly IShopifyDomainUtility? _shopifyDomainUtility;
    private readonly IRequestExecutionPolicy? _requestExecutionPolicy;
    private readonly IServiceProvider? _serviceProvider;

    // ReSharper disable ConvertToPrimaryConstructor
    public ProductImageServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy, IShopifyDomainUtility? shopifyDomainUtility = null)
    {
        _shopifyDomainUtility = shopifyDomainUtility;
        _requestExecutionPolicy = requestExecutionPolicy;
    }

    public ProductImageServiceFactory(IServiceProvider serviceProvider)
    {
        _shopifyDomainUtility = InternalServiceResolver.GetService<IShopifyDomainUtility>(serviceProvider);
        _requestExecutionPolicy = InternalServiceResolver.GetService<IRequestExecutionPolicy>(serviceProvider);
        _serviceProvider = serviceProvider;
    }

    /// <inheritDoc />
    public virtual IProductImageService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual IProductImageService Create(ShopifyApiCredentials credentials)
    {
        IProductImageService service = new ProductImageService(credentials, _shopifyDomainUtility);

        if (_requestExecutionPolicy is not null)
            service.SetExecutionPolicy(_requestExecutionPolicy);

        return service;
    }
}
