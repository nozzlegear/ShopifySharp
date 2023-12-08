using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IOrderRiskServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IOrderRiskService Create(ShopifyRestApiCredentials credentials);
}

public class OrderRiskServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IOrderRiskServiceFactory
{
    public virtual IOrderRiskService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new OrderRiskService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
