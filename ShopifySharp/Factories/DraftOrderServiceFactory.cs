using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IDraftOrderServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IDraftOrderService Create(ShopifyRestApiCredentials credentials);
}

public class DraftOrderServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IDraftOrderServiceFactory
{
    public virtual IDraftOrderService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new DraftOrderService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
