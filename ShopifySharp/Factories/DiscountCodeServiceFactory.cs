#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IDiscountCodeServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IDiscountCodeService Create(ShopifyRestApiCredentials credentials);
}

public class DiscountCodeServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IDiscountCodeServiceFactory
{
    public virtual IDiscountCodeService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new DiscountCodeService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
