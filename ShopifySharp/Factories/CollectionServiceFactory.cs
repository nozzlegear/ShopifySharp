using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICollectionServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICollectionService Create(ShopifyRestApiCredentials credentials);
}

public class CollectionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICollectionServiceFactory
{
    public virtual ICollectionService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CollectionService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
