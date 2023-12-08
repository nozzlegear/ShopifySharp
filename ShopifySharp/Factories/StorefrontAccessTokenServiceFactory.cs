// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IStorefrontAccessTokenServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IStorefrontAccessTokenService Create(ShopifyRestApiCredentials credentials);
}

public class StorefrontAccessTokenServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IStorefrontAccessTokenServiceFactory
{
    public virtual IStorefrontAccessTokenService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new StorefrontAccessTokenService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
