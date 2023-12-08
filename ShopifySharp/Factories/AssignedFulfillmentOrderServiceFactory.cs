#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IAssignedFulfillmentOrderServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IAssignedFulfillmentOrderService Create(ShopifyRestApiCredentials credentials);
}

public class AssignedFulfillmentOrderServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IAssignedFulfillmentOrderServiceFactory
{
    public virtual IAssignedFulfillmentOrderService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new AssignedFulfillmentOrderService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
