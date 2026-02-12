#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using JetBrains.Annotations;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

public interface IFulfillmentRequestServiceFactory : IServiceFactory<IFulfillmentRequestService>;

[PublicAPI]
public class FulfillmentRequestServiceFactory : IFulfillmentRequestServiceFactory
{
    private readonly IShopifyDomainUtility? _shopifyDomainUtility;
    private readonly IRequestExecutionPolicy? _requestExecutionPolicy;
    private readonly IServiceProvider? _serviceProvider;

    // ReSharper disable ConvertToPrimaryConstructor
    public FulfillmentRequestServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy, IShopifyDomainUtility? shopifyDomainUtility = null)
    {
        _shopifyDomainUtility = shopifyDomainUtility;
        _requestExecutionPolicy = requestExecutionPolicy;
    }

    public FulfillmentRequestServiceFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _requestExecutionPolicy = InternalServiceResolver.GetService<IRequestExecutionPolicy>(serviceProvider);
    }

    /// <inheritDoc />
    public virtual IFulfillmentRequestService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual IFulfillmentRequestService Create(ShopifyApiCredentials credentials)
    {
        IFulfillmentRequestService service = _serviceProvider is not null
            ? new FulfillmentRequestService(credentials, _serviceProvider)
            : new FulfillmentRequestService(credentials, _shopifyDomainUtility);

        if (_requestExecutionPolicy is not null)
            service.SetExecutionPolicy(_requestExecutionPolicy);

        return service;
    }
}
