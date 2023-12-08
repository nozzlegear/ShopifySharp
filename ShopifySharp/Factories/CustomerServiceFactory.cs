using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICustomerServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICustomerService Create(ShopifyRestApiCredentials credentials);
}

public class CustomerServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICustomerServiceFactory
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
