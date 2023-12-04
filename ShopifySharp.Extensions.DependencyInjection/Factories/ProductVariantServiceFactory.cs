using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IProductVariantServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IProductVariantService Create(ShopifyRestApiCredentials credentials);
}

public class ProductVariantServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IProductVariantServiceFactory
{
    public virtual IProductVariantService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ProductVariantService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
