// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICancellationRequestServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICancellationRequestService Create(ShopifyRestApiCredentials credentials);
}

public class CancellationRequestServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ICancellationRequestServiceFactory
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
