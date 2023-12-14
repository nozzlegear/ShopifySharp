// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IGiftCardServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IGiftCardService Create(ShopifyApiCredentials credentials);
}

public class GiftCardServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IGiftCardServiceFactory
{
    public virtual IGiftCardService Create(ShopifyApiCredentials credentials)
    {
        var service = new GiftCardService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
