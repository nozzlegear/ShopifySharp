using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IProductListingServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IProductListingService Create(ShopifyRestApiCredentials credentials);
}

public class ProductListingServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IProductListingServiceFactory
{
    public virtual IProductListingService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ProductListingService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
