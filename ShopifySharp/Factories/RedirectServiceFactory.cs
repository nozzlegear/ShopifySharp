#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IRedirectServiceFactory : IServiceFactory<IRedirectService>;

public class RedirectServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IRedirectServiceFactory
{
    /// <inheritDoc />
    public virtual IRedirectService Create(string shopDomain, string accessToken)
    {
        IRedirectService service = shopifyDomainUtility is null ? new RedirectService(shopDomain, accessToken) : new RedirectService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IRedirectService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
