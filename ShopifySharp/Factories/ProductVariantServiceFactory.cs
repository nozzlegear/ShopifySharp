#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

[Obsolete("Shopify has deprecated the REST API for product variants. This service is deprecated and will be removed in a future version of ShopifySharp. Use ShopifySharp's GraphService to manage product variants via the GraphQL API, and check https://github.com/nozzlegear/shopifysharp for a migration guide.")]
public interface IProductVariantServiceFactory : IServiceFactory<IProductVariantService>;

[Obsolete("Shopify has deprecated the REST API for product variants. This service is deprecated and will be removed in a future version of ShopifySharp. Use ShopifySharp's GraphService to manage product variants via the GraphQL API, and check https://github.com/nozzlegear/shopifysharp for a migration guide.")]
public class ProductVariantServiceFactory : IProductVariantServiceFactory
{
    private readonly IShopifyDomainUtility? _shopifyDomainUtility;
    private readonly IRequestExecutionPolicy? _requestExecutionPolicy;
    private readonly IServiceProvider? _serviceProvider;

    // ReSharper disable ConvertToPrimaryConstructor
    public ProductVariantServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy, IShopifyDomainUtility? shopifyDomainUtility = null)
    {
        _shopifyDomainUtility = shopifyDomainUtility;
        _requestExecutionPolicy = requestExecutionPolicy;
    }

    public ProductVariantServiceFactory(IServiceProvider serviceProvider)
    {
        _shopifyDomainUtility = InternalServiceResolver.GetService<IShopifyDomainUtility>(serviceProvider);
        _requestExecutionPolicy = InternalServiceResolver.GetService<IRequestExecutionPolicy>(serviceProvider);
        _serviceProvider = serviceProvider;
    }

    /// <inheritDoc />
    public virtual IProductVariantService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual IProductVariantService Create(ShopifyApiCredentials credentials)
    {
        IProductVariantService service = new ProductVariantService(credentials, _shopifyDomainUtility);

        if (_requestExecutionPolicy is not null)
            service.SetExecutionPolicy(_requestExecutionPolicy);

        return service;
    }
}
