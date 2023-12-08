#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ITenderTransactionServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ITenderTransactionService Create(ShopifyRestApiCredentials credentials);
}

public class TenderTransactionServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ITenderTransactionServiceFactory
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
