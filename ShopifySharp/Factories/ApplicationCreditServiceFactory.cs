// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IApplicationCreditServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IApplicationCreditService Create(ShopifyApiCredentials credentials);
}

public class ApplicationCreditServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IApplicationCreditServiceFactory
{
    public virtual IApplicationCreditService Create(ShopifyApiCredentials credentials)
    {
        var service = new ApplicationCreditService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
