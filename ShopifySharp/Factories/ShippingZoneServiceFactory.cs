#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IShippingZoneServiceFactory
{
    /// Creates a new instance of the <see cref="IShippingZoneService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IShippingZoneService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IShippingZoneService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IShippingZoneService Create(ShopifyApiCredentials credentials);
}

public class ShippingZoneServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IShippingZoneServiceFactory
{
    /// <inheritDoc />
    public virtual IShippingZoneService Create(string shopDomain, string accessToken)
    {
        var service = new ShippingZoneService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IShippingZoneService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
