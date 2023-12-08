// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IFulfillmentOrderServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IFulfillmentOrderService Create(ShopifyRestApiCredentials credentials);
}

public class FulfillmentOrderServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IFulfillmentOrderServiceFactory
{
    public virtual IFulfillmentOrderService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new FulfillmentOrderService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
