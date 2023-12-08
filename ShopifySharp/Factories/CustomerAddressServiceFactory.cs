using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICustomerAddressServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICustomerAddressService Create(ShopifyRestApiCredentials credentials);
}

public class CustomerAddressServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICustomerAddressServiceFactory
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
