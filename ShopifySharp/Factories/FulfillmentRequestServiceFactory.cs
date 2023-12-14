// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
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
    IFulfillmentRequestService Create(ShopifyApiCredentials credentials);
}

public class FulfillmentRequestServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IFulfillmentRequestServiceFactory
{
    public virtual IFulfillmentRequestService Create(ShopifyApiCredentials credentials)
    {
        var service = new FulfillmentRequestService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
