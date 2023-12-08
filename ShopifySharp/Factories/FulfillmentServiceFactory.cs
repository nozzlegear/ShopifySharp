#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IFulfillmentServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IFulfillmentService Create(ShopifyRestApiCredentials credentials);
}

public class FulfillmentServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IFulfillmentServiceFactory
{
    public virtual IFulfillmentService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new FulfillmentService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
