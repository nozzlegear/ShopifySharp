using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IFulfillmentServiceServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IFulfillmentServiceService Create(ShopifyRestApiCredentials credentials);
}

public class FulfillmentServiceServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IFulfillmentServiceServiceFactory
{
    public virtual IFulfillmentServiceService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new FulfillmentServiceService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
