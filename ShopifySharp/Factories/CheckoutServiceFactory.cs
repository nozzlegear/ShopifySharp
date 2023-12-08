using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICheckoutServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICheckoutService Create(ShopifyRestApiCredentials credentials);
}

public class CheckoutServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICheckoutServiceFactory
{
    public virtual ICheckoutService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CheckoutService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
