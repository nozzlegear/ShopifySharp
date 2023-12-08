using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ILocationServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ILocationService Create(ShopifyRestApiCredentials credentials);
}

public class LocationServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ILocationServiceFactory
{
    public virtual ILocationService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new LocationService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
