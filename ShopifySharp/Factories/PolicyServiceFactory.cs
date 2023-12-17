#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IPolicyServiceFactory
{
    /// Creates a new instance of the <see cref="IPolicyService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IPolicyService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IPolicyService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IPolicyService Create(ShopifyApiCredentials credentials);
}

public class PolicyServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IPolicyServiceFactory
{
    /// <inheritDoc />
    public virtual IPolicyService Create(string shopDomain, string accessToken)
    {
        var service = new PolicyService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IPolicyService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
