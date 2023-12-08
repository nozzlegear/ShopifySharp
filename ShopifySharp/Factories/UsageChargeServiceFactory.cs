#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IUsageChargeServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IUsageChargeService Create(ShopifyRestApiCredentials credentials);
}

public class UsageChargeServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IUsageChargeServiceFactory
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
