#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IBlogServiceFactory
{
    /// Creates a new instance of the <see cref="IBlogService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IBlogService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IBlogService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IBlogService Create(ShopifyApiCredentials credentials);
}

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
