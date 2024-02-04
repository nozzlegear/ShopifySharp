#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IInventoryLevelServiceFactory : IServiceFactory<IInventoryLevelService>;

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
