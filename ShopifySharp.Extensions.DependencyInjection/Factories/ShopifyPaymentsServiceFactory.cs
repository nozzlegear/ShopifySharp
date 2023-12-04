using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IShopifyPaymentsServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IShopifyPaymentsService Create(ShopifyRestApiCredentials credentials);
}

public class ShopifyPaymentsServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IShopifyPaymentsServiceFactory
{
    public virtual IShopifyPaymentsService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ShopifyPaymentsService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
