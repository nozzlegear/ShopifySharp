#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IWebhookServiceFactory : IServiceFactory<IWebhookService>;

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
