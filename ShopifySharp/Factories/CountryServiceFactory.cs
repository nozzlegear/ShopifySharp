using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICountryServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICountryService Create(ShopifyRestApiCredentials credentials);
}

public class CountryServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICountryServiceFactory
{
    public virtual ICountryService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CountryService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
