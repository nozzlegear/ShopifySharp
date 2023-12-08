// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ISmartCollectionServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ISmartCollectionService Create(ShopifyRestApiCredentials credentials);
}

public class SmartCollectionServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ISmartCollectionServiceFactory
{
    public virtual ISmartCollectionService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new SmartCollectionService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
