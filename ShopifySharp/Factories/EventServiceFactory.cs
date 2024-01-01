#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IEventServiceFactory
{
    /// Creates a new instance of the <see cref="IEventService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IEventService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IEventService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IEventService Create(ShopifyApiCredentials credentials);
}

public class EventServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IEventServiceFactory
{
    /// <inheritDoc />
    public virtual IEventService Create(string shopDomain, string accessToken)
    {
        IEventService service = shopifyDomainUtility is null ? new EventService(shopDomain, accessToken) : new EventService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IEventService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
