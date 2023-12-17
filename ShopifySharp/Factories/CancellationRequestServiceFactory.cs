#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICancellationRequestServiceFactory
{
    /// Creates a new instance of the <see cref="ICancellationRequestService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    ICancellationRequestService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="ICancellationRequestService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    ICancellationRequestService Create(ShopifyApiCredentials credentials);
}

public class CancellationRequestServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICancellationRequestServiceFactory
{
    /// <inheritDoc />
    public virtual ICancellationRequestService Create(string shopDomain, string accessToken)
    {
        var service = new CancellationRequestService(shopDomain, accessToken);

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
