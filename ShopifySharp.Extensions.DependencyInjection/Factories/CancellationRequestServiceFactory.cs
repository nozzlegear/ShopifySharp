using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface ICancellationRequestServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICancellationRequestService Create(ShopifyRestApiCredentials credentials);
}

public class CancellationRequestServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICancellationRequestServiceFactory
{
    public virtual ICancellationRequestService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CancellationRequestService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
