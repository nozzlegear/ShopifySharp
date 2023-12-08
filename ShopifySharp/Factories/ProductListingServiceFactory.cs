#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IProductListingServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IProductListingService Create(ShopifyRestApiCredentials credentials);
}

public class ProductListingServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IProductListingServiceFactory
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
