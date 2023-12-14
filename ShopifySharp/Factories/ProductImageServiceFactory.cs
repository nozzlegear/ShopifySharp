// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IProductImageServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IProductImageService Create(ShopifyApiCredentials credentials);
}

public class ProductImageServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IProductImageServiceFactory
{
    public virtual IProductImageService Create(ShopifyApiCredentials credentials)
    {
        var service = new ProductImageService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
