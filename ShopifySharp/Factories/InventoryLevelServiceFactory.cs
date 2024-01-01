#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IInventoryLevelServiceFactory
{
    /// Creates a new instance of the <see cref="IInventoryLevelService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IInventoryLevelService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IInventoryLevelService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IInventoryLevelService Create(ShopifyApiCredentials credentials);
}

public class InventoryLevelServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IInventoryLevelServiceFactory
{
    /// <inheritDoc />
    public virtual IInventoryLevelService Create(string shopDomain, string accessToken)
    {
        IInventoryLevelService service = shopifyDomainUtility is null ? new InventoryLevelService(shopDomain, accessToken) : new InventoryLevelService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IInventoryLevelService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
