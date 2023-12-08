#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IPriceRuleServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IPriceRuleService Create(ShopifyRestApiCredentials credentials);
}

public class PriceRuleServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IPriceRuleServiceFactory
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
