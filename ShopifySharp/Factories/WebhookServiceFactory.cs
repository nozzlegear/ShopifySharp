#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IWebhookServiceFactory
{
    /// Creates a new instance of the <see cref="IWebhookService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IWebhookService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IWebhookService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IWebhookService Create(ShopifyApiCredentials credentials);
}

public class WebhookServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IWebhookServiceFactory
{
    /// <inheritDoc />
    public virtual IWebhookService Create(string shopDomain, string accessToken)
    {
        IWebhookService service = shopifyDomainUtility is null ? new WebhookService(shopDomain, accessToken) : new WebhookService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IWebhookService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
