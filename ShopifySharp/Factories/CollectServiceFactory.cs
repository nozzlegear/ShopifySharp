#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ICollectServiceFactory : IServiceFactory<ICollectService>;

public class CollectServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ICollectServiceFactory
{
    /// <inheritDoc />
    public virtual ICollectService Create(string shopDomain, string accessToken)
    {
        ICollectService service = shopifyDomainUtility is null ? new CollectService(shopDomain, accessToken) : new CollectService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICollectService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
