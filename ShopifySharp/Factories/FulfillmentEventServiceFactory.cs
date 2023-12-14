// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
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
    IFulfillmentEventService Create(ShopifyApiCredentials credentials);
}

public class FulfillmentEventServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IFulfillmentEventServiceFactory
{
    public virtual IFulfillmentEventService Create(ShopifyApiCredentials credentials)
    {
        var service = new FulfillmentEventService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
