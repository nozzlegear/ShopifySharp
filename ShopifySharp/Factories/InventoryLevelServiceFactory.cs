#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IInventoryLevelServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IInventoryLevelService Create(ShopifyRestApiCredentials credentials);
}

public class InventoryLevelServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IInventoryLevelServiceFactory
{
    public virtual IInventoryLevelService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new InventoryLevelService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
