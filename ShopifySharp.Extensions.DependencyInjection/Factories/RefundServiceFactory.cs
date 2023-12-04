using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IRefundServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IRefundService Create(ShopifyRestApiCredentials credentials);
}

public class RefundServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IRefundServiceFactory
{
    public virtual IRefundService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new RefundService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
