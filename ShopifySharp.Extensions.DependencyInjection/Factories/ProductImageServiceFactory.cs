using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IProductImageServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IProductImageService Create(ShopifyRestApiCredentials credentials);
}

public class ProductImageServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IProductImageServiceFactory
{
    public virtual IProductImageService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ProductImageService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
