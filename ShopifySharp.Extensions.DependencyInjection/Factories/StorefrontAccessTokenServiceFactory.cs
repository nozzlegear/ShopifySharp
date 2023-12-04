using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IStorefrontAccessTokenServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IStorefrontAccessTokenService Create(ShopifyRestApiCredentials credentials);
}

public class StorefrontAccessTokenServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IStorefrontAccessTokenServiceFactory
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
