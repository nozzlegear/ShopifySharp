using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IFulfillmentEventServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IFulfillmentEventService Create(ShopifyRestApiCredentials credentials);
}

public class FulfillmentEventServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IFulfillmentEventServiceFactory
{
    public virtual IFulfillmentEventService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new FulfillmentEventService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
