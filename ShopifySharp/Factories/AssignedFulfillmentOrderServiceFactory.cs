using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IAssignedFulfillmentOrderServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IAssignedFulfillmentOrderService Create(ShopifyRestApiCredentials credentials);
}

public class AssignedFulfillmentOrderServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IAssignedFulfillmentOrderServiceFactory
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
