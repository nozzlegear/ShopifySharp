#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IFulfillmentServiceServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IFulfillmentServiceService Create(ShopifyRestApiCredentials credentials);
}

public class FulfillmentServiceServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IFulfillmentServiceServiceFactory
{
    public virtual IFulfillmentServiceService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new FulfillmentServiceService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
