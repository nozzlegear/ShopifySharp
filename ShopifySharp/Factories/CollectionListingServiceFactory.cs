#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ICollectionListingServiceFactory : IServiceFactory<ICollectionListingService>;


public class CollectionListingServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ICollectionListingServiceFactory
{
    /// <inheritDoc />
    public virtual ICollectionListingService Create(string shopDomain, string accessToken)
    {
        ICollectionListingService service = shopifyDomainUtility is null ? new CollectionListingService(shopDomain, accessToken) : new CollectionListingService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICollectionListingService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
