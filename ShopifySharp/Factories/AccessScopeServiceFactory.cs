#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IAccessScopeServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IAccessScopeService Create(ShopifyRestApiCredentials credentials);
}

public class AccessScopeServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IAccessScopeServiceFactory
{
    public virtual IAccessScopeService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new AccessScopeService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
