#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IOrderRiskServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IOrderRiskService Create(ShopifyRestApiCredentials credentials);
}

public class OrderRiskServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IOrderRiskServiceFactory
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