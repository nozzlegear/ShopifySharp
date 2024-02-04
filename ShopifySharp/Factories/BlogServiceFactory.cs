#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IBlogServiceFactory : IServiceFactory<IBlogService>;

public class BlogServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IBlogServiceFactory
{
    /// <inheritDoc />
    public virtual IBlogService Create(string shopDomain, string accessToken)
    {
        IBlogService service = shopifyDomainUtility is null ? new BlogService(shopDomain, accessToken) : new BlogService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IBlogService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
