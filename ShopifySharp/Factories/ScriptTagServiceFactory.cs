#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IScriptTagServiceFactory
{
    /// Creates a new instance of the <see cref="IScriptTagService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IScriptTagService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IScriptTagService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IScriptTagService Create(ShopifyApiCredentials credentials);
}

public class ScriptTagServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IScriptTagServiceFactory
{
    /// <inheritDoc />
    public virtual IScriptTagService Create(string shopDomain, string accessToken)
    {
        IScriptTagService service = shopifyDomainUtility is null ? new ScriptTagService(shopDomain, accessToken) : new ScriptTagService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IScriptTagService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
