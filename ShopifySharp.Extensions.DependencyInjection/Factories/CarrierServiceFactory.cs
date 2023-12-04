using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface ICarrierServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICarrierService Create(ShopifyRestApiCredentials credentials);
}

public class CarrierServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICarrierServiceFactory
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
