#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IAccessScopeServiceFactory
{
    /// Creates a new instance of the <see cref="IAccessScopeService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IAccessScopeService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IAccessScopeService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IAccessScopeService Create(ShopifyApiCredentials credentials);
}

public class AccessScopeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IAccessScopeServiceFactory
{
    /// <inheritDoc />
    public virtual IAccessScopeService Create(string shopDomain, string accessToken)
    {
        IAccessScopeService service = shopifyDomainUtility is null ? new AccessScopeService(shopDomain, accessToken) : new AccessScopeService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IAccessScopeService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
