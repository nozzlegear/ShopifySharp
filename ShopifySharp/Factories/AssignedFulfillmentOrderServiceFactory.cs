#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IAssignedFulfillmentOrderServiceFactory
{
    /// Creates a new instance of the <see cref="IAssignedFulfillmentOrderService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IAssignedFulfillmentOrderService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IAssignedFulfillmentOrderService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IAssignedFulfillmentOrderService Create(ShopifyApiCredentials credentials);
}

public class AssignedFulfillmentOrderServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IAssignedFulfillmentOrderServiceFactory
{
    /// <inheritDoc />
    public virtual IAssignedFulfillmentOrderService Create(string shopDomain, string accessToken)
    {
        IAssignedFulfillmentOrderService service = shopifyDomainUtility is null ? new AssignedFulfillmentOrderService(shopDomain, accessToken) : new AssignedFulfillmentOrderService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IAssignedFulfillmentOrderService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
