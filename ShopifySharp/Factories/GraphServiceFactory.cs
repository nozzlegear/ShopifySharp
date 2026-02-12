#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using JetBrains.Annotations;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

public interface IGraphServiceFactory : IServiceFactory<IGraphService>;

[PublicAPI]
public class GraphServiceFactory : IGraphServiceFactory
{
    private readonly IShopifyDomainUtility? _shopifyDomainUtility;
    private readonly IRequestExecutionPolicy? _requestExecutionPolicy;
    private readonly IServiceProvider? _serviceProvider;

    // ReSharper disable ConvertToPrimaryConstructor
    public GraphServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy, IShopifyDomainUtility? shopifyDomainUtility = null)
    {
        _shopifyDomainUtility = shopifyDomainUtility;
        _requestExecutionPolicy = requestExecutionPolicy;
    }

    public GraphServiceFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _requestExecutionPolicy = InternalServiceResolver.GetService<IRequestExecutionPolicy>(serviceProvider);
    }

    /// <inheritDoc />
    public virtual IGraphService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual IGraphService Create(ShopifyApiCredentials credentials)
    {
        IGraphService service = _serviceProvider is not null
            ? new GraphService(credentials, _serviceProvider)
            : new GraphService(credentials, DefaultShopifyApiVersion.DefaultVersion, _shopifyDomainUtility);

        if (_requestExecutionPolicy is not null)
            service.SetExecutionPolicy(_requestExecutionPolicy);

        return service;
    }
}
