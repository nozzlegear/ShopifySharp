#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ITransactionServiceFactory : IServiceFactory<ITransactionService>;

public class TransactionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ITransactionServiceFactory
{
    /// <inheritDoc />
    public virtual ITransactionService Create(string shopDomain, string accessToken)
    {
        ITransactionService service = shopifyDomainUtility is null ? new TransactionService(shopDomain, accessToken) : new TransactionService(shopDomain, accessToken, shopifyDomainUtility);

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
