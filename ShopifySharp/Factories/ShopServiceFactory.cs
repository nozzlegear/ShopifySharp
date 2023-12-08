using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IShopServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IShopService Create(ShopifyRestApiCredentials credentials);
}

public class ShopServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IShopServiceFactory
{
    public virtual IShopService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ShopService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
