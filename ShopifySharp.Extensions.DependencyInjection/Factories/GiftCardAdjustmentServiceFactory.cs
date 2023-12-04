using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IGiftCardAdjustmentServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IGiftCardAdjustmentService Create(ShopifyRestApiCredentials credentials);
}

public class GiftCardAdjustmentServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IGiftCardAdjustmentServiceFactory
{
    public virtual IGiftCardAdjustmentService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new GiftCardAdjustmentService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
