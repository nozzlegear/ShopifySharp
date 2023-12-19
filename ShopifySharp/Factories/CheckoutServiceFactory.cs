#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

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

public class CheckoutServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ICheckoutServiceFactory
{
    /// <inheritDoc />
    public virtual ICheckoutService Create(string shopDomain, string accessToken)
    {
        ICheckoutService service = shopifyDomainUtility is null ? new CheckoutService(shopDomain, accessToken) : new CheckoutService(shopDomain, accessToken, shopifyDomainUtility);

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
