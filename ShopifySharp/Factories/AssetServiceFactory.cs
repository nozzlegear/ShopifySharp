#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IAssetServiceFactory
{
    /// Creates a new instance of the <see cref="IAssetService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IAssetService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IAssetService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IAssetService Create(ShopifyApiCredentials credentials);
}

public class AssetServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IAssetServiceFactory
{
    /// <inheritDoc />
    public virtual IAssetService Create(string shopDomain, string accessToken)
    {
        IAssetService service = shopifyDomainUtility is null ? new AssetService(shopDomain, accessToken) : new AssetService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IAssetService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
