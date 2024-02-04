#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IApplicationCreditServiceFactory : IServiceFactory<IApplicationCreditService>;

public class ApplicationCreditServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IApplicationCreditServiceFactory
{
    /// <inheritDoc />
    public virtual IApplicationCreditService Create(string shopDomain, string accessToken)
    {
        IApplicationCreditService service = shopifyDomainUtility is null ? new ApplicationCreditService(shopDomain, accessToken) : new ApplicationCreditService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IApplicationCreditService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
