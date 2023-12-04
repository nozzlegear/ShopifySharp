using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface ICustomerSavedSearchServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICustomerSavedSearchService Create(ShopifyRestApiCredentials credentials);
}

public class CustomerSavedSearchServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICustomerSavedSearchServiceFactory
{
    public virtual ICustomerSavedSearchService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CustomerSavedSearchService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
