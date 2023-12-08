// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IMetaFieldServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IMetaFieldService Create(ShopifyRestApiCredentials credentials);
}

public class MetaFieldServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IMetaFieldServiceFactory
{
    public virtual IMetaFieldService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new MetaFieldService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
