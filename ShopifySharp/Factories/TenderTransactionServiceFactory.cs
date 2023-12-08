using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ITenderTransactionServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ITenderTransactionService Create(ShopifyRestApiCredentials credentials);
}

public class TenderTransactionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ITenderTransactionServiceFactory
{
    public virtual ITenderTransactionService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new TenderTransactionService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
