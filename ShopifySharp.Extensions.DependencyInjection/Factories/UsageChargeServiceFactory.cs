using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IUsageChargeServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IUsageChargeService Create(ShopifyRestApiCredentials credentials);
}

public class UsageChargeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IUsageChargeServiceFactory
{
    public virtual IUsageChargeService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new UsageChargeService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
