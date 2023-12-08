using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IInventoryItemServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IInventoryItemService Create(ShopifyRestApiCredentials credentials);
}

public class InventoryItemServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IInventoryItemServiceFactory
{
    public virtual IInventoryItemService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new InventoryItemService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
