#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICustomerAddressServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICustomerAddressService Create(ShopifyRestApiCredentials credentials);
}

public class CustomerAddressServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ICustomerAddressServiceFactory
{
    public virtual ICustomerAddressService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CustomerAddressService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
