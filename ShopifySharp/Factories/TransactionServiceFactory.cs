#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ITransactionServiceFactory
{
    /// Creates a new instance of the <see cref="ITransactionService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    ITransactionService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="ITransactionService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    ITransactionService Create(ShopifyApiCredentials credentials);
}

public class TransactionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ITransactionServiceFactory
{
    /// <inheritDoc />
    public virtual ITransactionService Create(string shopDomain, string accessToken)
    {
        var service = new TransactionService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ITransactionService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
