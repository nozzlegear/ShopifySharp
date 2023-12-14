// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IProductVariantServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IProductVariantService Create(ShopifyApiCredentials credentials);
}

public class ProductVariantServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IProductVariantServiceFactory
{
    public virtual IProductVariantService Create(ShopifyApiCredentials credentials)
    {
        var service = new ProductVariantService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
