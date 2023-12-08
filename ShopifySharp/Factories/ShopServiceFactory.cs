#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IShopServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IShopService Create(ShopifyRestApiCredentials credentials);
}

public class ShopServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IShopServiceFactory
{
    public virtual IShopService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ShopService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
