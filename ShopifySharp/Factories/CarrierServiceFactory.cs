#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ICarrierServiceFactory : IServiceFactory<ICarrierService>;

public class CarrierServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ICarrierServiceFactory
{
    /// <inheritDoc />
    public virtual ICarrierService Create(string shopDomain, string accessToken)
    {
        ICarrierService service = shopifyDomainUtility is null ? new CarrierService(shopDomain, accessToken) : new CarrierService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICarrierService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
