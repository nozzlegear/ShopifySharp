#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IStorefrontAccessTokenServiceFactory
{
    /// Creates a new instance of the <see cref="IStorefrontAccessTokenService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IStorefrontAccessTokenService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IStorefrontAccessTokenService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IStorefrontAccessTokenService Create(ShopifyApiCredentials credentials);
}

public class StorefrontAccessTokenServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IStorefrontAccessTokenServiceFactory
{
    /// <inheritDoc />
    public virtual IStorefrontAccessTokenService Create(string shopDomain, string accessToken)
    {
        IStorefrontAccessTokenService service = shopifyDomainUtility is null ? new StorefrontAccessTokenService(shopDomain, accessToken) : new StorefrontAccessTokenService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IStorefrontAccessTokenService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
