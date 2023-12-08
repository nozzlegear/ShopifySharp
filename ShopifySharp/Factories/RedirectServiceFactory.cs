#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IRedirectServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IRedirectService Create(ShopifyRestApiCredentials credentials);
}

public class RedirectServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IRedirectServiceFactory
{
    public virtual IRedirectService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new RedirectService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
