
#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

public interface IApplicationCreditServiceFactory : IServiceFactory<IApplicationCreditService>;

public class ApplicationCreditServiceFactory(IDependencyContainer? dependencyContainer) : IServiceFactory<IApplicationCreditService>
{
    [Obsolete("This constructor is deprecated and will be removed in a future version of ShopifySharp.")]
    public ApplicationCreditServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null)
        : this(new InternalDependencyContainer(requestExecutionPolicy, shopifyDomainUtility))
    {

    }

    /// <inheritDoc />
    public virtual IApplicationCreditService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual IApplicationCreditService Create(ShopifyApiCredentials credentials)
    {
        var shopifyDomainUtility = dependencyContainer?.TryGetService<IShopifyDomainUtility>();
        IApplicationCreditService service = shopifyDomainUtility is null ? new ApplicationCreditService(credentials.ShopDomain, credentials.AccessToken) : new ApplicationCreditService(credentials.ShopDomain, credentials.AccessToken, shopifyDomainUtility);
        var requestExecutionPolicy = dependencyContainer?.TryGetService<IRequestExecutionPolicy>();

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
