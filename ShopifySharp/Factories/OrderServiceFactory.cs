#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IOrderServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IOrderService Create(ShopifyRestApiCredentials credentials);
}

public class OrderServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IOrderServiceFactory
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
