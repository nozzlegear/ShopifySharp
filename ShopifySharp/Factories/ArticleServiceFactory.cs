#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IArticleServiceFactory
{
    /// Creates a new instance of the <see cref="IArticleService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IArticleService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IArticleService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IArticleService Create(ShopifyApiCredentials credentials);
}

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
