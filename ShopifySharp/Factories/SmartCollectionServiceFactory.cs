#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ISmartCollectionServiceFactory : IServiceFactory<ISmartCollectionService>;

public class SmartCollectionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ISmartCollectionServiceFactory
{
    /// <inheritDoc />
    public virtual ISmartCollectionService Create(string shopDomain, string accessToken)
    {
        ISmartCollectionService service = shopifyDomainUtility is null ? new SmartCollectionService(shopDomain, accessToken) : new SmartCollectionService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ISmartCollectionService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
