#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ICustomCollectionServiceFactory : IServiceFactory<ICustomCollectionService>;

public class CustomCollectionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ICustomCollectionServiceFactory
{
    /// <inheritDoc />
    public virtual ICustomCollectionService Create(string shopDomain, string accessToken)
    {
        ICustomCollectionService service = shopifyDomainUtility is null ? new CustomCollectionService(shopDomain, accessToken) : new CustomCollectionService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICustomCollectionService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
