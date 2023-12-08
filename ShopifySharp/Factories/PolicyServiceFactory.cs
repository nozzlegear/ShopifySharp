// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IPolicyServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IPolicyService Create(ShopifyRestApiCredentials credentials);
}

public class PolicyServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IPolicyServiceFactory
{
    public virtual IPolicyService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new PolicyService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
