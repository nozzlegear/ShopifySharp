#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IRefundServiceFactory : IServiceFactory<IRefundService>;

public class RefundServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IRefundServiceFactory
{
    /// <inheritDoc />
    public virtual IRefundService Create(string shopDomain, string accessToken)
    {
        IRefundService service = shopifyDomainUtility is null ? new RefundService(shopDomain, accessToken) : new RefundService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IRefundService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
