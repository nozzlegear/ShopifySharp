#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif
using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IPartnerServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IPartnerService Create(ShopifyPartnerApiCredentials credentials);
}

public class PartnerServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IPartnerServiceFactory
{
    public virtual IPartnerService Create(ShopifyPartnerApiCredentials credentials)
    {
        var service = new PartnerService(credentials.PartnerOrganizationId, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
