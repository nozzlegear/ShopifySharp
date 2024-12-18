#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

public interface IPartnerServiceFactory
{
    /// Creates a new instance of the <see cref="IPartnerService" /> with the given credentials.
    /// <param name="partnerOrganizationId">Your Shopify Partner organization ID. This can be found on your Shopify Partner account setti ngs page.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IPartnerService Create(long partnerOrganizationId, string accessToken);

    /// Creates a new instance of the <see cref="IPartnerService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IPartnerService Create(ShopifyPartnerApiCredentials credentials);
}

public class PartnerServiceFactory : IPartnerServiceFactory
{
    private readonly IShopifyDomainUtility? _shopifyDomainUtility;
    private readonly IRequestExecutionPolicy? _requestExecutionPolicy;
    private readonly IServiceProvider? _serviceProvider;

    // ReSharper disable ConvertToPrimaryConstructor
    public PartnerServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy, IShopifyDomainUtility? shopifyDomainUtility = null)
    {
        _shopifyDomainUtility = shopifyDomainUtility;
        _requestExecutionPolicy = requestExecutionPolicy;
    }

    public PartnerServiceFactory(IServiceProvider serviceProvider)
    {
        _shopifyDomainUtility = InternalServiceResolver.GetService<IShopifyDomainUtility>(serviceProvider);
        _requestExecutionPolicy = InternalServiceResolver.GetService<IRequestExecutionPolicy>(serviceProvider);
        _serviceProvider = serviceProvider;
    }

    /// <inheritDoc />
    public virtual IPartnerService Create(long organizationId, string accessToken) =>
        Create(new ShopifyPartnerApiCredentials(organizationId, accessToken));

    /// <inheritDoc />
    public virtual IPartnerService Create(ShopifyPartnerApiCredentials credentials)
    {
        IPartnerService service = new PartnerService(credentials, _shopifyDomainUtility);

        if (_requestExecutionPolicy is not null)
            service.SetExecutionPolicy(_requestExecutionPolicy);

        return service;
    }
}
