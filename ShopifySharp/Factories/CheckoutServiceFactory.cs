#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICheckoutServiceFactory
{
    /// Creates a new instance of the <see cref="ICheckoutService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    ICheckoutService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="ICheckoutService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    ICheckoutService Create(ShopifyApiCredentials credentials);
}

public class CheckoutServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICheckoutServiceFactory
{
    /// <inheritDoc />
    public virtual ICheckoutService Create(string shopDomain, string accessToken)
    {
        var service = new CheckoutService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICheckoutService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
