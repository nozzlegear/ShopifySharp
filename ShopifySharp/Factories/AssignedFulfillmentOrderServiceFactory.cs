#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

public interface IAssignedFulfillmentOrderServiceFactory : IServiceFactory<IAssignedFulfillmentOrderService>;

public class AssignedFulfillmentOrderServiceFactory(IServiceProvider? serviceProvider) : IServiceFactory<IAssignedFulfillmentOrderService>
{
    [Obsolete]
    private readonly IRequestExecutionPolicy? _requestExecutionPolicy;

    [Obsolete]
    private readonly IShopifyDomainUtility? _shopifyDomainUtility;

    [Obsolete("This constructor is deprecated and will be removed in a future version of ShopifySharp.")]
    public AssignedFulfillmentOrderServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null)
        : this(null)
    {
        _requestExecutionPolicy = requestExecutionPolicy;
        _shopifyDomainUtility = shopifyDomainUtility;
    }

    /// <inheritDoc />
    public virtual IAssignedFulfillmentOrderService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual IAssignedFulfillmentOrderService Create(ShopifyApiCredentials credentials)
    {
        var shopifyDomainUtility = _shopifyDomainUtility ?? InternalServiceResolver.GetService<IShopifyDomainUtility>(serviceProvider);
        IAssignedFulfillmentOrderService service = shopifyDomainUtility is null ? new AssignedFulfillmentOrderService(credentials.ShopDomain, credentials.AccessToken) : new AssignedFulfillmentOrderService(credentials.ShopDomain, credentials.AccessToken, shopifyDomainUtility);

        var requestExecutionPolicy = _requestExecutionPolicy ?? InternalServiceResolver.GetService<IRequestExecutionPolicy>(serviceProvider);

        if (requestExecutionPolicy is not null)
            service.SetExecutionPolicy(requestExecutionPolicy);

        return service;
    }
}
