#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IScriptTagServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IScriptTagService Create(ShopifyRestApiCredentials credentials);
}

public class ScriptTagServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IScriptTagServiceFactory
{
    public virtual IScriptTagService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ScriptTagService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
