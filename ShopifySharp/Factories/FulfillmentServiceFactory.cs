#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IFulfillmentServiceFactory
{
    /// Creates a new instance of the <see cref="IFulfillmentService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IFulfillmentService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IFulfillmentService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IFulfillmentService Create(ShopifyApiCredentials credentials);
}

public class FulfillmentServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IFulfillmentServiceFactory
{
    /// <inheritDoc />
    public virtual IFulfillmentService Create(string shopDomain, string accessToken)
    {
        var service = new FulfillmentService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IFulfillmentService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
