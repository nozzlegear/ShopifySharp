using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IFulfillmentRequestServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IFulfillmentRequestService Create(ShopifyRestApiCredentials credentials);
}

public class FulfillmentRequestServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IFulfillmentRequestServiceFactory
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
