#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IArticleServiceFactory : IServiceFactory<IArticleService>;

public class ArticleServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IArticleServiceFactory
{
    /// <inheritDoc />
    public virtual IArticleService Create(string shopDomain, string accessToken)
    {
        IArticleService service = shopifyDomainUtility is null ? new ArticleService(shopDomain, accessToken) : new ArticleService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IArticleService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
