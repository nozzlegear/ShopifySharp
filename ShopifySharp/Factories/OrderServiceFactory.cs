#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IOrderServiceFactory
{
    /// Creates a new instance of the <see cref="IOrderService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IOrderService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IOrderService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IOrderService Create(ShopifyApiCredentials credentials);
}

public class OrderServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IOrderServiceFactory
{
    /// <inheritDoc />
    public virtual IOrderService Create(string shopDomain, string accessToken)
    {
        IOrderService service = shopifyDomainUtility is null ? new OrderService(shopDomain, accessToken) : new OrderService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IOrderService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
