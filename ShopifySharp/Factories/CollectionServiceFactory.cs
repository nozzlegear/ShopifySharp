#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICollectionServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICollectionService Create(ShopifyRestApiCredentials credentials);
}

public class CollectionServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ICollectionServiceFactory
{
    public virtual ICollectionService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CollectionService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
