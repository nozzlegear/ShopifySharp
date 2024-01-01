#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IShopServiceFactory
{
    /// Creates a new instance of the <see cref="IShopService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IShopService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IShopService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IShopService Create(ShopifyApiCredentials credentials);
}

public class ShopServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IShopServiceFactory
{
    /// <inheritDoc />
    public virtual IShopService Create(string shopDomain, string accessToken)
    {
        IShopService service = shopifyDomainUtility is null ? new ShopService(shopDomain, accessToken) : new ShopService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IShopService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
