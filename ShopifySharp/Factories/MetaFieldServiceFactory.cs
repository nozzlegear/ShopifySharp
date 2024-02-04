#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IMetaFieldServiceFactory : IServiceFactory<IMetaFieldService>;

public class MetaFieldServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IMetaFieldServiceFactory
{
    /// <inheritDoc />
    public virtual IMetaFieldService Create(string shopDomain, string accessToken)
    {
        IMetaFieldService service = shopifyDomainUtility is null ? new MetaFieldService(shopDomain, accessToken) : new MetaFieldService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IMetaFieldService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
