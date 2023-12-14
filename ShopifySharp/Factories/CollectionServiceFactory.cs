// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
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
    ICollectionService Create(ShopifyApiCredentials credentials);
}

public class CollectionServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ICollectionServiceFactory
{
    public virtual ICollectionService Create(ShopifyApiCredentials credentials)
    {
        var service = new CollectionService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
