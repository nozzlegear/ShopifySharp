using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IApplicationCreditServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IApplicationCreditService Create(ShopifyRestApiCredentials credentials);
}

public class ApplicationCreditServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IApplicationCreditServiceFactory
{
    public virtual IApplicationCreditService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ApplicationCreditService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
