using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface ITransactionServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ITransactionService Create(ShopifyRestApiCredentials credentials);
}

public class TransactionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ITransactionServiceFactory
{
    public virtual ITransactionService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new TransactionService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
