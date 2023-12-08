using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IPolicyServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IPolicyService Create(ShopifyRestApiCredentials credentials);
}

public class PolicyServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IPolicyServiceFactory
{
    public virtual IPolicyService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new PolicyService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
