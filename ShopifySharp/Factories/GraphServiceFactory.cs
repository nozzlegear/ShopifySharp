#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IGraphServiceFactory
{
    /// Creates a new instance of the <see cref="IGraphService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IGraphService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IGraphService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IGraphService Create(ShopifyApiCredentials credentials);
}

public class GraphServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IGraphServiceFactory
{
    /// <inheritDoc />
    public virtual IGraphService Create(string shopDomain, string accessToken)
    {
        IGraphService service = shopifyDomainUtility is null ? new GraphService(shopDomain, accessToken) : new GraphService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IGraphService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
