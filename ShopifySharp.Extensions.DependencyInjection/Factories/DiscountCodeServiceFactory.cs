using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IDiscountCodeServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IDiscountCodeService Create(ShopifyRestApiCredentials credentials);
}

public class DiscountCodeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IDiscountCodeServiceFactory
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
