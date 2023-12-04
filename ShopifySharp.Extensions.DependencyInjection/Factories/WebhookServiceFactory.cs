using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IWebhookServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IWebhookService Create(ShopifyRestApiCredentials credentials);
}

public class WebhookServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IWebhookServiceFactory
{
    public virtual IWebhookService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new WebhookService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
