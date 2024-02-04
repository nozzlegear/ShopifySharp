#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IInventoryItemServiceFactory : IServiceFactory<IInventoryItemService>;

public class InventoryItemServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IInventoryItemServiceFactory
{
    /// <inheritDoc />
    public virtual IInventoryItemService Create(string shopDomain, string accessToken)
    {
        IInventoryItemService service = shopifyDomainUtility is null ? new InventoryItemService(shopDomain, accessToken) : new InventoryItemService(shopDomain, accessToken, shopifyDomainUtility);

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
