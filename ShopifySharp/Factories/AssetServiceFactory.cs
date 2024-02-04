#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IAssetServiceFactory : IServiceFactory<IAssetService>;

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
