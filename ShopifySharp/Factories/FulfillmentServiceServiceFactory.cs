#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IFulfillmentServiceServiceFactory
{
    /// Creates a new instance of the <see cref="IFulfillmentServiceService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IFulfillmentServiceService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IFulfillmentServiceService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IFulfillmentServiceService Create(ShopifyApiCredentials credentials);
}

public class FulfillmentServiceServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IFulfillmentServiceServiceFactory
{
    /// <inheritDoc />
    public virtual IFulfillmentServiceService Create(string shopDomain, string accessToken)
    {
        IFulfillmentServiceService service = shopifyDomainUtility is null ? new FulfillmentServiceService(shopDomain, accessToken) : new FulfillmentServiceService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IFulfillmentServiceService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
