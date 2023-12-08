using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICustomCollectionServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICustomCollectionService Create(ShopifyRestApiCredentials credentials);
}

public class CustomCollectionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICustomCollectionServiceFactory
{
    public virtual ICustomCollectionService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CustomCollectionService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
