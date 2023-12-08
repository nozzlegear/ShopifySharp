#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICustomerServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICustomerService Create(ShopifyRestApiCredentials credentials);
}

public class CustomerServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ICustomerServiceFactory
{
    public virtual ICustomerService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CustomerService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
