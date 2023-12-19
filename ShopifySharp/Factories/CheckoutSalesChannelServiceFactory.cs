#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ICheckoutSalesChannelServiceFactory
{
    /// Creates a new instance of the <see cref="ICheckoutSalesChannelService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    ICheckoutSalesChannelService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="ICheckoutSalesChannelService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    ICheckoutSalesChannelService Create(ShopifyApiCredentials credentials);
}

public class CheckoutSalesChannelServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ICheckoutSalesChannelServiceFactory
{
    /// <inheritDoc />
    public virtual ICheckoutSalesChannelService Create(string shopDomain, string accessToken)
    {
        ICheckoutSalesChannelService service = shopifyDomainUtility is null ? new CheckoutSalesChannelService(shopDomain, accessToken) : new CheckoutSalesChannelService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICheckoutSalesChannelService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
