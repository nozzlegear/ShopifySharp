#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IFulfillmentEventServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IFulfillmentEventService Create(ShopifyRestApiCredentials credentials);
}

public class FulfillmentEventServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IFulfillmentEventServiceFactory
{
    public virtual IFulfillmentEventService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new FulfillmentEventService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
