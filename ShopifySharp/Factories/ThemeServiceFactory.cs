#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IThemeServiceFactory
{
    /// Creates a new instance of the <see cref="IThemeService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IThemeService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IThemeService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IThemeService Create(ShopifyApiCredentials credentials);
}

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
