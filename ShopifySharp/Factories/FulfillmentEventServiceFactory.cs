#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IFulfillmentEventServiceFactory
{
    /// Creates a new instance of the <see cref="IFulfillmentEventService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IFulfillmentEventService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IFulfillmentEventService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IFulfillmentEventService Create(ShopifyApiCredentials credentials);
}

public class FulfillmentEventServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IFulfillmentEventServiceFactory
{
    /// <inheritDoc />
    public virtual IFulfillmentEventService Create(string shopDomain, string accessToken)
    {
        var service = new FulfillmentEventService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IFulfillmentEventService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
