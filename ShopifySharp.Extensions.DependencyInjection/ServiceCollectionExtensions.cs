using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyInjection;
using ShopifySharp.Factories;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMethodReturnValue.Global

namespace ShopifySharp.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddShopifySharpRequestExecutionPolicy(this IServiceCollection services, IRequestExecutionPolicy requestExecutionPolicy)
    {
        services.TryAddSingleton(requestExecutionPolicy);
        return services;
    }

    public static IServiceCollection AddShopifySharpServiceFactories(
        this IServiceCollection services,
        #if NETSTANDARD2_1_OR_GREATER
        IRequestExecutionPolicy? requestExecutionPolicy = null
        #else
        IRequestExecutionPolicy requestExecutionPolicy = null
        #endif
    )
    {
        if (requestExecutionPolicy is not null)
        {
            services.AddShopifySharpRequestExecutionPolicy(requestExecutionPolicy);
        }

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

    public static IServiceCollection AddShopifySharp(this IServiceCollection services)
    {
        return services.AddShopifySharpServiceFactories();
    }
}
