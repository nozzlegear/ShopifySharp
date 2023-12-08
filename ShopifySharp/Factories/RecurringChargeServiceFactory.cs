using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IRecurringChargeServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IRecurringChargeService Create(ShopifyRestApiCredentials credentials);
}

public class RecurringChargeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IRecurringChargeServiceFactory
{
    public virtual IRecurringChargeService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new RecurringChargeService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
