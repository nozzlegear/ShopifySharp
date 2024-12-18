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

public class PartnerServiceFactory(IServiceProvider? serviceProvider) : IPartnerServiceFactory
{
    [Obsolete]
    private readonly IRequestExecutionPolicy? _requestExecutionPolicy;

    [Obsolete]
    private readonly IShopifyDomainUtility? _shopifyDomainUtility;

    [Obsolete("This constructor is deprecated and will be removed in a future version of ShopifySharp.")]
    public PartnerServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null)
        : this(null)
    {
        _requestExecutionPolicy = requestExecutionPolicy;
        _shopifyDomainUtility = shopifyDomainUtility;
    }

    /// <inheritDoc />
    public virtual IPartnerService Create(long organizationId, string accessToken) =>
        Create(new ShopifyPartnerApiCredentials(organizationId, accessToken));

    /// <inheritDoc />
    public virtual IPartnerService Create(ShopifyPartnerApiCredentials credentials)
    {
        var shopifyDomainUtility = _shopifyDomainUtility ?? InternalServiceResolver.GetService<IShopifyDomainUtility>(serviceProvider);
        IPartnerService service = shopifyDomainUtility is null ? new PartnerService(credentials.PartnerOrganizationId, credentials.AccessToken) : new PartnerService(credentials.PartnerOrganizationId, credentials.AccessToken, shopifyDomainUtility);

        var requestExecutionPolicy = _requestExecutionPolicy ?? InternalServiceResolver.GetService<IRequestExecutionPolicy>(serviceProvider);

        if (requestExecutionPolicy is not null)
            service.SetExecutionPolicy(requestExecutionPolicy);

        return service;
    }
}
