#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IInventoryItemServiceFactory
{
    /// Creates a new instance of the <see cref="IInventoryItemService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IInventoryItemService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IInventoryItemService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IInventoryItemService Create(ShopifyApiCredentials credentials);
}

public class InventoryItemServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IInventoryItemServiceFactory
{
    /// <inheritDoc />
    public virtual IInventoryItemService Create(string shopDomain, string accessToken)
    {
        var service = new InventoryItemService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IInventoryItemService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
