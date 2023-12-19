#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IProductImageServiceFactory
{
    /// Creates a new instance of the <see cref="IProductImageService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IProductImageService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IProductImageService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IProductImageService Create(ShopifyApiCredentials credentials);
}

public class ProductImageServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IProductImageServiceFactory
{
    /// <inheritDoc />
    public virtual IProductImageService Create(string shopDomain, string accessToken)
    {
        IProductImageService service = shopifyDomainUtility is null ? new ProductImageService(shopDomain, accessToken) : new ProductImageService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IProductImageService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
