using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICheckoutSalesChannelServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICheckoutSalesChannelService Create(ShopifyRestApiCredentials credentials);
}

public class CheckoutSalesChannelServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICheckoutSalesChannelServiceFactory
{
    public virtual ICheckoutSalesChannelService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CheckoutSalesChannelService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
