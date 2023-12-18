using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyInjection;
using ShopifySharp.Factories;
using ShopifySharp.Utilities;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMethodReturnValue.Global

namespace ShopifySharp.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds a <see cref="IRequestExecutionPolicy"/> to your Dependency Injection container. ShopifySharp service factories
    /// managed by your container will use this policy when creating ShopifySharp services.
    /// </summary>
    /// <typeparam name="T">A class that implements ShopifySharp's <see cref="IRequestExecutionPolicy"/> interface.</typeparam>
    public static IServiceCollection AddShopifySharpRequestExecutionPolicy<T>(this IServiceCollection services)
        where T : class, IRequestExecutionPolicy
    {
        // TODO: add ServiceLifetime parameter
        services.TryAddSingleton<IRequestExecutionPolicy, T>();
        return services;
    }

    /// <summary>
    /// Adds ShopifySharp's utilities to your Dependency Injection container. Includes the following utilities:
    /// <list type="bullet">
    /// <item><see cref="IShopifyOauthUtility"/></item>
    /// <item><see cref="IShopifyDomainUtility"/></item>
    /// <item><see cref="IShopifyRequestValidationUtility"/></item>
    /// </list>
    /// </summary>
    public static IServiceCollection AddShopifySharpUtilities(this IServiceCollection services)
    {
        // TODO: add ServiceLifetime parameter
        services.TryAddSingleton<IShopifyOauthUtility, ShopifyOauthUtility>();
        services.TryAddSingleton<IShopifyDomainUtility, ShopifyDomainUtility>();
        services.TryAddSingleton<IShopifyRequestValidationUtility, ShopifyRequestValidationUtility>();

        return services;
    }

    /// <summary>
    /// Adds ShopifySharp's service factories to your Dependency Injection container. If you've added an <see cref="IRequestExecutionPolicy"/>,
    /// the service factories will use it when creating ShopifySharp services.
    /// </summary>
    public static IServiceCollection AddShopifySharpServiceFactories(this IServiceCollection services)
    {
        // TODO: add ServiceLifetime parameter
        services.TryAddSingleton<IAccessScopeServiceFactory, AccessScopeServiceFactory>();
        services.TryAddSingleton<IApplicationCreditServiceFactory, ApplicationCreditServiceFactory>();
        services.TryAddSingleton<IArticleServiceFactory, ArticleServiceFactory>();
        services.TryAddSingleton<IAssetServiceFactory, AssetServiceFactory>();
        services.TryAddSingleton<IAssignedFulfillmentOrderServiceFactory, AssignedFulfillmentOrderServiceFactory>();
        services.TryAddSingleton<IBlogServiceFactory, BlogServiceFactory>();
        services.TryAddSingleton<ICancellationRequestServiceFactory, CancellationRequestServiceFactory>();
        services.TryAddSingleton<ICarrierServiceFactory, CarrierServiceFactory>();
        services.TryAddSingleton<IChargeServiceFactory, ChargeServiceFactory>();
        services.TryAddSingleton<ICheckoutSalesChannelServiceFactory, CheckoutSalesChannelServiceFactory>();
        services.TryAddSingleton<ICheckoutServiceFactory, CheckoutServiceFactory>();
        services.TryAddSingleton<ICollectServiceFactory, CollectServiceFactory>();
        services.TryAddSingleton<ICollectionListingServiceFactory, CollectionListingServiceFactory>();
        services.TryAddSingleton<ICollectionServiceFactory, CollectionServiceFactory>();
        services.TryAddSingleton<ICountryServiceFactory, CountryServiceFactory>();
        services.TryAddSingleton<ICustomCollectionServiceFactory, CustomCollectionServiceFactory>();
        services.TryAddSingleton<ICustomerAddressServiceFactory, CustomerAddressServiceFactory>();
        services.TryAddSingleton<ICustomerSavedSearchServiceFactory, CustomerSavedSearchServiceFactory>();
        services.TryAddSingleton<ICustomerServiceFactory, CustomerServiceFactory>();
        services.TryAddSingleton<IDiscountCodeServiceFactory, DiscountCodeServiceFactory>();
        services.TryAddSingleton<IDraftOrderServiceFactory, DraftOrderServiceFactory>();
        services.TryAddSingleton<IEventServiceFactory, EventServiceFactory>();
        services.TryAddSingleton<IFulfillmentEventServiceFactory, FulfillmentEventServiceFactory>();
        services.TryAddSingleton<IFulfillmentOrderServiceFactory, FulfillmentOrderServiceFactory>();
        services.TryAddSingleton<IFulfillmentRequestServiceFactory, FulfillmentRequestServiceFactory>();
        services.TryAddSingleton<IFulfillmentServiceFactory, FulfillmentServiceFactory>();
        services.TryAddSingleton<IFulfillmentServiceServiceFactory, FulfillmentServiceServiceFactory>();
        services.TryAddSingleton<IGiftCardAdjustmentServiceFactory, GiftCardAdjustmentServiceFactory>();
        services.TryAddSingleton<IGiftCardServiceFactory, GiftCardServiceFactory>();
        services.TryAddSingleton<IGraphServiceFactory, GraphServiceFactory>();
        services.TryAddSingleton<IInventoryItemServiceFactory, InventoryItemServiceFactory>();
        services.TryAddSingleton<IInventoryLevelServiceFactory, InventoryLevelServiceFactory>();
        services.TryAddSingleton<ILocationServiceFactory, LocationServiceFactory>();
        services.TryAddSingleton<IMetaFieldServiceFactory, MetaFieldServiceFactory>();
        services.TryAddSingleton<IOrderRiskServiceFactory, OrderRiskServiceFactory>();
        services.TryAddSingleton<IOrderServiceFactory, OrderServiceFactory>();
        services.TryAddSingleton<IPageServiceFactory, PageServiceFactory>();
        services.TryAddSingleton<IPartnerServiceFactory, PartnerServiceFactory>();
        services.TryAddSingleton<IPolicyServiceFactory, PolicyServiceFactory>();
        services.TryAddSingleton<IPriceRuleServiceFactory, PriceRuleServiceFactory>();
        services.TryAddSingleton<IProductImageServiceFactory, ProductImageServiceFactory>();
        services.TryAddSingleton<IProductListingServiceFactory, ProductListingServiceFactory>();
        services.TryAddSingleton<IProductServiceFactory, ProductServiceFactory>();
        services.TryAddSingleton<IProductVariantServiceFactory, ProductVariantServiceFactory>();
        services.TryAddSingleton<IRecurringChargeServiceFactory, RecurringChargeServiceFactory>();
        services.TryAddSingleton<IRedirectServiceFactory, RedirectServiceFactory>();
        services.TryAddSingleton<IRefundServiceFactory, RefundServiceFactory>();
        services.TryAddSingleton<IScriptTagServiceFactory, ScriptTagServiceFactory>();
        services.TryAddSingleton<IShippingZoneServiceFactory, ShippingZoneServiceFactory>();
        services.TryAddSingleton<IShopServiceFactory, ShopServiceFactory>();
        services.TryAddSingleton<IShopifyPaymentsServiceFactory, ShopifyPaymentsServiceFactory>();
        services.TryAddSingleton<ISmartCollectionServiceFactory, SmartCollectionServiceFactory>();
        services.TryAddSingleton<IStorefrontAccessTokenServiceFactory, StorefrontAccessTokenServiceFactory>();
        services.TryAddSingleton<ITenderTransactionServiceFactory, TenderTransactionServiceFactory>();
        services.TryAddSingleton<IThemeServiceFactory, ThemeServiceFactory>();
        services.TryAddSingleton<ITransactionServiceFactory, TransactionServiceFactory>();
        services.TryAddSingleton<IUsageChargeServiceFactory, UsageChargeServiceFactory>();
        services.TryAddSingleton<IUserServiceFactory, UserServiceFactory>();
        services.TryAddSingleton<IWebhookServiceFactory, WebhookServiceFactory>();

        return services;
    }

    /// <summary>
    /// Adds all of ShopifySharp's Dependency Injection services to your DI container. This is a convenience method and
    /// simply calls the following extensions sequentially:
    /// <list type="bullet">
    /// <item><see cref="AddShopifySharpRequestExecutionPolicy{T}"/></item>
    /// <item><see cref="AddShopifySharpUtilities"/></item>
    /// <item><see cref="AddShopifySharpServiceFactories"/></item>
    /// </list>
    /// </summary>
    /// <param name="services"></param>
    /// <typeparam name="T"></typeparam>
    public static IServiceCollection AddShopifySharp<T>(this IServiceCollection services)
        where T : class, IRequestExecutionPolicy
    {
        return services
            .AddShopifySharpRequestExecutionPolicy<T>()
            .AddShopifySharpUtilities()
            .AddShopifySharpServiceFactories();
    }
}
