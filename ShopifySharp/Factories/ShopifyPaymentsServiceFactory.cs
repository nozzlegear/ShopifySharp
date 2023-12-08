#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IShopifyPaymentsServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IShopifyPaymentsService Create(ShopifyRestApiCredentials credentials);
}

public class ShopifyPaymentsServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IShopifyPaymentsServiceFactory
{
    public virtual IShopifyPaymentsService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ShopifyPaymentsService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
