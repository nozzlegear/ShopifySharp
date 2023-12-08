// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICustomCollectionServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICustomCollectionService Create(ShopifyRestApiCredentials credentials);
}

public class CustomCollectionServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ICustomCollectionServiceFactory
{
    public virtual ICustomCollectionService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CustomCollectionService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
