#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICollectServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICollectService Create(ShopifyRestApiCredentials credentials);
}

public class CollectServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ICollectServiceFactory
{
    public virtual ICollectService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CollectService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
