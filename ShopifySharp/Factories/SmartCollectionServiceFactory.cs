using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ISmartCollectionServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ISmartCollectionService Create(ShopifyRestApiCredentials credentials);
}

public class SmartCollectionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ISmartCollectionServiceFactory
{
    public virtual ISmartCollectionService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new SmartCollectionService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
