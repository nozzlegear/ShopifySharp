// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IGiftCardAdjustmentServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IGiftCardAdjustmentService Create(ShopifyRestApiCredentials credentials);
}

public class GiftCardAdjustmentServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IGiftCardAdjustmentServiceFactory
{
    public virtual IGiftCardAdjustmentService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new GiftCardAdjustmentService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
