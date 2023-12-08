using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICollectServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICollectService Create(ShopifyRestApiCredentials credentials);
}

public class CollectServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICollectServiceFactory
{
    public virtual ICollectService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CollectService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
