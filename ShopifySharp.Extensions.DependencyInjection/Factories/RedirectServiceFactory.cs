using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IRedirectServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IRedirectService Create(ShopifyRestApiCredentials credentials);
}

public class RedirectServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IRedirectServiceFactory
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
