using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IShippingZoneServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IShippingZoneService Create(ShopifyRestApiCredentials credentials);
}

public class ShippingZoneServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IShippingZoneServiceFactory
{
    public virtual IShippingZoneService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ShippingZoneService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
