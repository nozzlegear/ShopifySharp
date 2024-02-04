#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IThemeServiceFactory : IServiceFactory<IThemeService>;

public class ThemeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IThemeServiceFactory
{
    /// <inheritDoc />
    public virtual IThemeService Create(string shopDomain, string accessToken)
    {
        IThemeService service = shopifyDomainUtility is null ? new ThemeService(shopDomain, accessToken) : new ThemeService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IThemeService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
