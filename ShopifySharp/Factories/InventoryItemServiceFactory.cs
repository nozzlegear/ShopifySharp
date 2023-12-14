// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IInventoryItemServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IInventoryItemService Create(ShopifyApiCredentials credentials);
}

public class InventoryItemServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IInventoryItemServiceFactory
{
    public virtual IInventoryItemService Create(ShopifyApiCredentials credentials)
    {
        var service = new InventoryItemService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
