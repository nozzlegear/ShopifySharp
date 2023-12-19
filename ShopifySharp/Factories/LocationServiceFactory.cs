#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ILocationServiceFactory
{
    /// Creates a new instance of the <see cref="ILocationService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    ILocationService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="ILocationService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    ILocationService Create(ShopifyApiCredentials credentials);
}

public class LocationServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ILocationServiceFactory
{
    /// <inheritDoc />
    public virtual ILocationService Create(string shopDomain, string accessToken)
    {
        ILocationService service = shopifyDomainUtility is null ? new LocationService(shopDomain, accessToken) : new LocationService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ILocationService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
