
#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

public interface ICheckoutServiceFactory : IServiceFactory<ICheckoutService>;

public class CheckoutServiceFactory(IDependencyContainer? dependencyContainer) : IServiceFactory<ICheckoutService>
{
    [Obsolete("This constructor is deprecated and will be removed in a future version of ShopifySharp.")]
    public CheckoutServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null)
        : this(new InternalDependencyContainer(requestExecutionPolicy, shopifyDomainUtility))
    {

    }

    /// <inheritDoc />
    public virtual ICheckoutService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual ICheckoutService Create(ShopifyApiCredentials credentials)
    {
        var shopifyDomainUtility = dependencyContainer?.TryGetService<IShopifyDomainUtility>();
        ICheckoutService service = shopifyDomainUtility is null ? new CheckoutService(credentials.ShopDomain, credentials.AccessToken) : new CheckoutService(credentials.ShopDomain, credentials.AccessToken, shopifyDomainUtility);
        var requestExecutionPolicy = dependencyContainer?.TryGetService<IRequestExecutionPolicy>();

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
