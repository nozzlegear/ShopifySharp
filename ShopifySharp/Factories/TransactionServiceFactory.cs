// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ITransactionServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ITransactionService Create(ShopifyRestApiCredentials credentials);
}

public class TransactionServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ITransactionServiceFactory
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
