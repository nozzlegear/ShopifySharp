// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICheckoutServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICheckoutService Create(ShopifyRestApiCredentials credentials);
}

public class CheckoutServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ICheckoutServiceFactory
{
    public virtual ICheckoutService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CheckoutService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
