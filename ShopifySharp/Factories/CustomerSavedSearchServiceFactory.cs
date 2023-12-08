// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICustomerSavedSearchServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICustomerSavedSearchService Create(ShopifyRestApiCredentials credentials);
}

public class CustomerSavedSearchServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ICustomerSavedSearchServiceFactory
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
