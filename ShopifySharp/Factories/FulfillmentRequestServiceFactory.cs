#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IFulfillmentRequestServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IFulfillmentRequestService Create(ShopifyRestApiCredentials credentials);
}

public class FulfillmentRequestServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IFulfillmentRequestServiceFactory
{
    public virtual IFulfillmentRequestService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new FulfillmentRequestService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
