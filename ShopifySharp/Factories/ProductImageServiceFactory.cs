#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IProductImageServiceFactory : IServiceFactory<IProductImageService>;

public class ProductImageServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IProductImageServiceFactory
{
    /// <inheritDoc />
    public virtual IProductImageService Create(string shopDomain, string accessToken)
    {
        IProductImageService service = shopifyDomainUtility is null ? new ProductImageService(shopDomain, accessToken) : new ProductImageService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IProductImageService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
