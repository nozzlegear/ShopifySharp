using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IScriptTagServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IScriptTagService Create(ShopifyRestApiCredentials credentials);
}

public class ScriptTagServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IScriptTagServiceFactory
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
