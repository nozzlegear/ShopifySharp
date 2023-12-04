using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IFulfillmentOrderServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IFulfillmentOrderService Create(ShopifyRestApiCredentials credentials);
}

public class FulfillmentOrderServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IFulfillmentOrderServiceFactory
{
    public virtual IFulfillmentOrderService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new FulfillmentOrderService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
