#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

public interface IOrderServiceFactory : IServiceFactory<IOrderService>;

public class OrderServiceFactory : IOrderServiceFactory
{
    private readonly IShopifyDomainUtility? _shopifyDomainUtility;
    private readonly IRequestExecutionPolicy? _requestExecutionPolicy;
    private readonly IServiceProvider? _serviceProvider;

    // ReSharper disable ConvertToPrimaryConstructor
    public OrderServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy, IShopifyDomainUtility? shopifyDomainUtility = null)
    {
        _shopifyDomainUtility = shopifyDomainUtility;
        _requestExecutionPolicy = requestExecutionPolicy;
    }

    public OrderServiceFactory(IServiceProvider serviceProvider)
    {
        _shopifyDomainUtility = InternalServiceResolver.GetService<IShopifyDomainUtility>(serviceProvider);
        _requestExecutionPolicy = InternalServiceResolver.GetService<IRequestExecutionPolicy>(serviceProvider);
        _serviceProvider = serviceProvider;
    }

    /// <inheritDoc />
    public virtual IOrderService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual IOrderService Create(ShopifyApiCredentials credentials)
    {
        IOrderService service = new OrderService(credentials, _shopifyDomainUtility);

        if (_requestExecutionPolicy is not null)
            service.SetExecutionPolicy(_requestExecutionPolicy);

        return service;
    }
}
