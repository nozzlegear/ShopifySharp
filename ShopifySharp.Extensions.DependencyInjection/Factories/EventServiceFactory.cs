using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IEventServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IEventService Create(ShopifyRestApiCredentials credentials);
}

public class EventServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IEventServiceFactory
{
    public virtual IEventService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new EventService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
