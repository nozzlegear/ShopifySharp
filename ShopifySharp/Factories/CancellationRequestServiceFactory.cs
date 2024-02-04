#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ICancellationRequestServiceFactory : IServiceFactory<ICancellationRequestService>;

public class CancellationRequestServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ICancellationRequestServiceFactory
{
    /// <inheritDoc />
    public virtual ICancellationRequestService Create(string shopDomain, string accessToken)
    {
        ICancellationRequestService service = shopifyDomainUtility is null ? new CancellationRequestService(shopDomain, accessToken) : new CancellationRequestService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICancellationRequestService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
