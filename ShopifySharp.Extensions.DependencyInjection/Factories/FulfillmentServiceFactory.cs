using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IFulfillmentServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IFulfillmentService Create(ShopifyRestApiCredentials credentials);
}

public class FulfillmentServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IFulfillmentServiceFactory
{
    public virtual IFulfillmentService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new FulfillmentService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
