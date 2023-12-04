using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface ICollectionListingServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICollectionListingService Create(ShopifyRestApiCredentials credentials);
}

public class CollectionListingServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICollectionListingServiceFactory
{
    public virtual ICollectionListingService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CollectionListingService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
