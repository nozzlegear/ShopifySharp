// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICarrierServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICarrierService Create(ShopifyRestApiCredentials credentials);
}

public class CarrierServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ICarrierServiceFactory
{
    public virtual ICarrierService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CarrierService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
