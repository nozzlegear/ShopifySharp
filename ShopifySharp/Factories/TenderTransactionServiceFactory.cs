#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ITenderTransactionServiceFactory
{
    /// Creates a new instance of the <see cref="ITenderTransactionService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    ITenderTransactionService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="ITenderTransactionService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    ITenderTransactionService Create(ShopifyApiCredentials credentials);
}

public class TenderTransactionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ITenderTransactionServiceFactory
{
    /// <inheritDoc />
    public virtual ITenderTransactionService Create(string shopDomain, string accessToken)
    {
        ITenderTransactionService service = shopifyDomainUtility is null ? new TenderTransactionService(shopDomain, accessToken) : new TenderTransactionService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ITenderTransactionService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
