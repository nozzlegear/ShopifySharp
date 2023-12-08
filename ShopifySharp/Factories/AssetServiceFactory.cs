// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IAssetServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IAssetService Create(ShopifyRestApiCredentials credentials);
}

public class AssetServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IAssetServiceFactory
{
    public virtual IAssetService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new AssetService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
