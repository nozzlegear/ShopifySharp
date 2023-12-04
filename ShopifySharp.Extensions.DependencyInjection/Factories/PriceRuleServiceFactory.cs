using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IPriceRuleServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IPriceRuleService Create(ShopifyRestApiCredentials credentials);
}

public class PriceRuleServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IPriceRuleServiceFactory
{
    public virtual IPriceRuleService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new PriceRuleService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
