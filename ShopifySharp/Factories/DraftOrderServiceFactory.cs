// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IDraftOrderServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IDraftOrderService Create(ShopifyApiCredentials credentials);
}

public class DraftOrderServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IDraftOrderServiceFactory
{
    public virtual IDraftOrderService Create(ShopifyApiCredentials credentials)
    {
        var service = new DraftOrderService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
