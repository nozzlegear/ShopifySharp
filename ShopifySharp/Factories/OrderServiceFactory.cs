using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IOrderServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IOrderService Create(ShopifyRestApiCredentials credentials);
}

public class OrderServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IOrderServiceFactory
{
    public virtual IOrderService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new OrderService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
