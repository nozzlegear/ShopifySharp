using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IChargeServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IChargeService Create(ShopifyRestApiCredentials credentials);
}

public class ChargeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IChargeServiceFactory
{
    public virtual IChargeService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ChargeService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
