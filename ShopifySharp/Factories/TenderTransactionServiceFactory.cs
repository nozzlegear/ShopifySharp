// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
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
    ITenderTransactionService Create(ShopifyApiCredentials credentials);
}

public class TenderTransactionServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ITenderTransactionServiceFactory
{
    public virtual ITenderTransactionService Create(ShopifyApiCredentials credentials)
    {
        var service = new TenderTransactionService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
