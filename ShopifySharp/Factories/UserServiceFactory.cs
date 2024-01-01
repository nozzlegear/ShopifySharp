#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IUserServiceFactory
{
    /// Creates a new instance of the <see cref="IUserService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IUserService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IUserService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IUserService Create(ShopifyApiCredentials credentials);
}

public class UserServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IUserServiceFactory
{
    /// <inheritDoc />
    public virtual IUserService Create(string shopDomain, string accessToken)
    {
        IUserService service = shopifyDomainUtility is null ? new UserService(shopDomain, accessToken) : new UserService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IUserService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
