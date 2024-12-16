#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Factories;

public interface ICheckoutSalesChannelServiceFactory : IServiceFactory<ICheckoutSalesChannelService>;

public class CheckoutSalesChannelServiceFactory(IServiceProvider? serviceProvider) : IServiceFactory<ICheckoutSalesChannelService>
{
    [Obsolete]
    private readonly IRequestExecutionPolicy? _requestExecutionPolicy;

    [Obsolete]
    private readonly IShopifyDomainUtility? _shopifyDomainUtility;

    [Obsolete("This constructor is deprecated and will be removed in a future version of ShopifySharp.")]
    public CheckoutSalesChannelServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null)
        : this(null)
    {
        _requestExecutionPolicy = requestExecutionPolicy;
        _shopifyDomainUtility = shopifyDomainUtility;
    }

    /// <inheritDoc />
    public virtual ICheckoutSalesChannelService Create(string shopDomain, string accessToken) =>
        Create(new ShopifyApiCredentials(shopDomain, accessToken));

    /// <inheritDoc />
    public virtual ICheckoutSalesChannelService Create(ShopifyApiCredentials credentials)
    {
        var shopifyDomainUtility = _shopifyDomainUtility ?? InternalServiceResolver.GetService<IShopifyDomainUtility>(serviceProvider);
        ICheckoutSalesChannelService service = shopifyDomainUtility is null ? new CheckoutSalesChannelService(credentials.ShopDomain, credentials.AccessToken) : new CheckoutSalesChannelService(credentials.ShopDomain, credentials.AccessToken, shopifyDomainUtility);

        var requestExecutionPolicy = _requestExecutionPolicy ?? InternalServiceResolver.GetService<IRequestExecutionPolicy>(serviceProvider);

        if (requestExecutionPolicy is not null)
            service.SetExecutionPolicy(requestExecutionPolicy);

        return service;
    }
}
