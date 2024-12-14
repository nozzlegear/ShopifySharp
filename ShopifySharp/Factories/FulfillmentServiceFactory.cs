
#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

public interface IFulfillmentServiceFactory : IServiceFactory<IFulfillmentService>;

public class FulfillmentServiceFactory(IDependencyContainer? dependencyContainer) : IServiceFactory<IFulfillmentService>
{
    [Obsolete("This constructor is deprecated and will be removed in a future version of ShopifySharp.")]
    public FulfillmentServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null)
        : this(new InternalDependencyContainer(requestExecutionPolicy, shopifyDomainUtility))
    {

    }

    /// <inheritDoc />
    public virtual IFulfillmentService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual IFulfillmentService Create(ShopifyApiCredentials credentials)
    {
        var shopifyDomainUtility = dependencyContainer?.TryGetService<IShopifyDomainUtility>();
        IFulfillmentService service = shopifyDomainUtility is null ? new FulfillmentService(credentials.ShopDomain, credentials.AccessToken) : new FulfillmentService(credentials.ShopDomain, credentials.AccessToken, shopifyDomainUtility);
        var requestExecutionPolicy = dependencyContainer?.TryGetService<IRequestExecutionPolicy>();

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
