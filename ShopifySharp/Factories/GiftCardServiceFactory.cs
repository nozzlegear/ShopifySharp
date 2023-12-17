#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IGiftCardServiceFactory
{
    /// Creates a new instance of the <see cref="IGiftCardService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IGiftCardService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IGiftCardService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IGiftCardService Create(ShopifyApiCredentials credentials);
}

public class GiftCardServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IGiftCardServiceFactory
{
    /// <inheritDoc />
    public virtual IGiftCardService Create(string shopDomain, string accessToken)
    {
        var service = new GiftCardService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IGiftCardService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
