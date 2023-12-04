using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IAccessScopeServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IAccessScopeService Create(ShopifyRestApiCredentials credentials);
}

public class AccessScopeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IAccessScopeServiceFactory
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
