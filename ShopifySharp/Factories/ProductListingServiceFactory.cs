#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IProductListingServiceFactory
{
    /// Creates a new instance of the <see cref="IProductListingService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IProductListingService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IProductListingService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IProductListingService Create(ShopifyApiCredentials credentials);
}

public class ProductListingServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IProductListingServiceFactory
{
    /// <inheritDoc />
    public virtual IProductListingService Create(string shopDomain, string accessToken)
    {
        var service = new ProductListingService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IProductListingService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
