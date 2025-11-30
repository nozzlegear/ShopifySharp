#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopQueryBuilder() : GraphQueryBuilder<Shop>("shop")
{
    public ShopQueryBuilder AddFieldAccountOwner(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("accountOwner", build);
        return this;
    }

    public ShopQueryBuilder AddFieldAlerts(Func<ShopAlertQueryBuilder, ShopAlertQueryBuilder> build)
    {
        AddField<ShopAlert, ShopAlertQueryBuilder>("alerts", build);
        return this;
    }

    public ShopQueryBuilder AddFieldAllProductCategories(Func<ProductCategoryQueryBuilder, ProductCategoryQueryBuilder> build)
    {
        AddField<ProductCategory, ProductCategoryQueryBuilder>("allProductCategories", build);
        return this;
    }

    public ShopQueryBuilder AddFieldAllProductCategoriesList(Func<TaxonomyCategoryQueryBuilder, TaxonomyCategoryQueryBuilder> build)
    {
        AddField<TaxonomyCategory, TaxonomyCategoryQueryBuilder>("allProductCategoriesList", build);
        return this;
    }

    [Obsolete("Not supported anymore.")]
    public ShopQueryBuilder AddFieldAnalyticsToken()
    {
        AddField("analyticsToken");
        return this;
    }

    public ShopQueryBuilder AddFieldAssignedFulfillmentOrders(Func<FulfillmentOrderConnectionQueryBuilder, FulfillmentOrderConnectionQueryBuilder> build)
    {
        AddField<FulfillmentOrderConnection, FulfillmentOrderConnectionQueryBuilder>("assignedFulfillmentOrders", build);
        return this;
    }

    public ShopQueryBuilder AddFieldAvailableChannelApps(Func<AppConnectionQueryBuilder, AppConnectionQueryBuilder> build)
    {
        AddField<AppConnection, AppConnectionQueryBuilder>("availableChannelApps", build);
        return this;
    }

    public ShopQueryBuilder AddFieldBillingAddress(Func<ShopAddressQueryBuilder, ShopAddressQueryBuilder> build)
    {
        AddField<ShopAddress, ShopAddressQueryBuilder>("billingAddress", build);
        return this;
    }

    public ShopQueryBuilder AddFieldChannelDefinitionsForInstalledChannels(Func<AvailableChannelDefinitionsByChannelQueryBuilder, AvailableChannelDefinitionsByChannelQueryBuilder> build)
    {
        AddField<AvailableChannelDefinitionsByChannel, AvailableChannelDefinitionsByChannelQueryBuilder>("channelDefinitionsForInstalledChannels", build);
        return this;
    }

    public ShopQueryBuilder AddFieldChannels(Func<ChannelConnectionQueryBuilder, ChannelConnectionQueryBuilder> build)
    {
        AddField<ChannelConnection, ChannelConnectionQueryBuilder>("channels", build);
        return this;
    }

    public ShopQueryBuilder AddFieldCheckoutApiSupported()
    {
        AddField("checkoutApiSupported");
        return this;
    }

    public ShopQueryBuilder AddFieldCollections(Func<CollectionConnectionQueryBuilder, CollectionConnectionQueryBuilder> build)
    {
        AddField<CollectionConnection, CollectionConnectionQueryBuilder>("collections", build);
        return this;
    }

    public ShopQueryBuilder AddFieldContactEmail()
    {
        AddField("contactEmail");
        return this;
    }

    public ShopQueryBuilder AddFieldCountriesInShippingZones(Func<CountriesInShippingZonesQueryBuilder, CountriesInShippingZonesQueryBuilder> build)
    {
        AddField<CountriesInShippingZones, CountriesInShippingZonesQueryBuilder>("countriesInShippingZones", build);
        return this;
    }

    public ShopQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public ShopQueryBuilder AddFieldCurrencyCode()
    {
        AddField("currencyCode");
        return this;
    }

    public ShopQueryBuilder AddFieldCurrencyFormats(Func<CurrencyFormatsQueryBuilder, CurrencyFormatsQueryBuilder> build)
    {
        AddField<CurrencyFormats, CurrencyFormatsQueryBuilder>("currencyFormats", build);
        return this;
    }

    public ShopQueryBuilder AddFieldCurrencySettings(Func<CurrencySettingConnectionQueryBuilder, CurrencySettingConnectionQueryBuilder> build)
    {
        AddField<CurrencySettingConnection, CurrencySettingConnectionQueryBuilder>("currencySettings", build);
        return this;
    }

    public ShopQueryBuilder AddFieldCustomerAccounts()
    {
        AddField("customerAccounts");
        return this;
    }

    public ShopQueryBuilder AddFieldCustomerAccountsV2(Func<CustomerAccountsV2QueryBuilder, CustomerAccountsV2QueryBuilder> build)
    {
        AddField<CustomerAccountsV2, CustomerAccountsV2QueryBuilder>("customerAccountsV2", build);
        return this;
    }

    public ShopQueryBuilder AddFieldCustomers(Func<CustomerConnectionQueryBuilder, CustomerConnectionQueryBuilder> build)
    {
        AddField<CustomerConnection, CustomerConnectionQueryBuilder>("customers", build);
        return this;
    }

    public ShopQueryBuilder AddFieldCustomerTags(Func<StringConnectionQueryBuilder, StringConnectionQueryBuilder> build)
    {
        AddField<StringConnection, StringConnectionQueryBuilder>("customerTags", build);
        return this;
    }

    public ShopQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public ShopQueryBuilder AddFieldDomains(Func<DomainQueryBuilder, DomainQueryBuilder> build)
    {
        AddField<Domain, DomainQueryBuilder>("domains", build);
        return this;
    }

    public ShopQueryBuilder AddFieldDraftOrders(Func<DraftOrderConnectionQueryBuilder, DraftOrderConnectionQueryBuilder> build)
    {
        AddField<DraftOrderConnection, DraftOrderConnectionQueryBuilder>("draftOrders", build);
        return this;
    }

    public ShopQueryBuilder AddFieldDraftOrderTags(Func<StringConnectionQueryBuilder, StringConnectionQueryBuilder> build)
    {
        AddField<StringConnection, StringConnectionQueryBuilder>("draftOrderTags", build);
        return this;
    }

    public ShopQueryBuilder AddFieldEmail()
    {
        AddField("email");
        return this;
    }

    public ShopQueryBuilder AddFieldEnabledPresentmentCurrencies()
    {
        AddField("enabledPresentmentCurrencies");
        return this;
    }

    public ShopQueryBuilder AddFieldEntitlements(Func<EntitlementsTypeQueryBuilder, EntitlementsTypeQueryBuilder> build)
    {
        AddField<EntitlementsType, EntitlementsTypeQueryBuilder>("entitlements", build);
        return this;
    }

    public ShopQueryBuilder AddFieldFeatures(Func<ShopFeaturesQueryBuilder, ShopFeaturesQueryBuilder> build)
    {
        AddField<ShopFeatures, ShopFeaturesQueryBuilder>("features", build);
        return this;
    }

    public ShopQueryBuilder AddFieldFulfillmentOrders(Func<FulfillmentOrderConnectionQueryBuilder, FulfillmentOrderConnectionQueryBuilder> build)
    {
        AddField<FulfillmentOrderConnection, FulfillmentOrderConnectionQueryBuilder>("fulfillmentOrders", build);
        return this;
    }

    public ShopQueryBuilder AddFieldFulfillmentServices(Func<FulfillmentServiceQueryBuilder, FulfillmentServiceQueryBuilder> build)
    {
        AddField<FulfillmentService, FulfillmentServiceQueryBuilder>("fulfillmentServices", build);
        return this;
    }

    public ShopQueryBuilder AddFieldIanaTimezone()
    {
        AddField("ianaTimezone");
        return this;
    }

    public ShopQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopQueryBuilder AddFieldInventoryItems(Func<InventoryItemConnectionQueryBuilder, InventoryItemConnectionQueryBuilder> build)
    {
        AddField<InventoryItemConnection, InventoryItemConnectionQueryBuilder>("inventoryItems", build);
        return this;
    }

    public ShopQueryBuilder AddFieldLimitedPendingOrderCount(Func<LimitedPendingOrderCountQueryBuilder, LimitedPendingOrderCountQueryBuilder> build)
    {
        AddField<LimitedPendingOrderCount, LimitedPendingOrderCountQueryBuilder>("limitedPendingOrderCount", build);
        return this;
    }

    public ShopQueryBuilder AddFieldLocations(Func<LocationConnectionQueryBuilder, LocationConnectionQueryBuilder> build)
    {
        AddField<LocationConnection, LocationConnectionQueryBuilder>("locations", build);
        return this;
    }

    public ShopQueryBuilder AddFieldMarketingSmsConsentEnabledAtCheckout()
    {
        AddField("marketingSmsConsentEnabledAtCheckout");
        return this;
    }

    public ShopQueryBuilder AddFieldMerchantApprovalSignals(Func<MerchantApprovalSignalsQueryBuilder, MerchantApprovalSignalsQueryBuilder> build)
    {
        AddField<MerchantApprovalSignals, MerchantApprovalSignalsQueryBuilder>("merchantApprovalSignals", build);
        return this;
    }

    public ShopQueryBuilder AddFieldMetafield(Func<MetafieldQueryBuilder, MetafieldQueryBuilder> build)
    {
        AddField<Metafield, MetafieldQueryBuilder>("metafield", build);
        return this;
    }

    public ShopQueryBuilder AddFieldMetafieldDefinitions(Func<MetafieldDefinitionConnectionQueryBuilder, MetafieldDefinitionConnectionQueryBuilder> build)
    {
        AddField<MetafieldDefinitionConnection, MetafieldDefinitionConnectionQueryBuilder>("metafieldDefinitions", build);
        return this;
    }

    public ShopQueryBuilder AddFieldMetafields(Func<MetafieldConnectionQueryBuilder, MetafieldConnectionQueryBuilder> build)
    {
        AddField<MetafieldConnection, MetafieldConnectionQueryBuilder>("metafields", build);
        return this;
    }

    public ShopQueryBuilder AddFieldMyshopifyDomain()
    {
        AddField("myshopifyDomain");
        return this;
    }

    public ShopQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ShopQueryBuilder AddFieldNavigationSettings(Func<NavigationItemQueryBuilder, NavigationItemQueryBuilder> build)
    {
        AddField<NavigationItem, NavigationItemQueryBuilder>("navigationSettings", build);
        return this;
    }

    public ShopQueryBuilder AddFieldOrderNumberFormatPrefix()
    {
        AddField("orderNumberFormatPrefix");
        return this;
    }

    public ShopQueryBuilder AddFieldOrderNumberFormatSuffix()
    {
        AddField("orderNumberFormatSuffix");
        return this;
    }

    public ShopQueryBuilder AddFieldOrders(Func<OrderConnectionQueryBuilder, OrderConnectionQueryBuilder> build)
    {
        AddField<OrderConnection, OrderConnectionQueryBuilder>("orders", build);
        return this;
    }

    public ShopQueryBuilder AddFieldOrderTags(Func<StringConnectionQueryBuilder, StringConnectionQueryBuilder> build)
    {
        AddField<StringConnection, StringConnectionQueryBuilder>("orderTags", build);
        return this;
    }

    public ShopQueryBuilder AddFieldPaymentSettings(Func<PaymentSettingsQueryBuilder, PaymentSettingsQueryBuilder> build)
    {
        AddField<PaymentSettings, PaymentSettingsQueryBuilder>("paymentSettings", build);
        return this;
    }

    public ShopQueryBuilder AddFieldPlan(Func<ShopPlanQueryBuilder, ShopPlanQueryBuilder> build)
    {
        AddField<ShopPlan, ShopPlanQueryBuilder>("plan", build);
        return this;
    }

    public ShopQueryBuilder AddFieldPrimaryDomain(Func<DomainQueryBuilder, DomainQueryBuilder> build)
    {
        AddField<Domain, DomainQueryBuilder>("primaryDomain", build);
        return this;
    }

    public ShopQueryBuilder AddFieldProductImages(Func<ImageConnectionQueryBuilder, ImageConnectionQueryBuilder> build)
    {
        AddField<ImageConnection, ImageConnectionQueryBuilder>("productImages", build);
        return this;
    }

    public ShopQueryBuilder AddFieldProducts(Func<ProductConnectionQueryBuilder, ProductConnectionQueryBuilder> build)
    {
        AddField<ProductConnection, ProductConnectionQueryBuilder>("products", build);
        return this;
    }

    public ShopQueryBuilder AddFieldProductTags(Func<StringConnectionQueryBuilder, StringConnectionQueryBuilder> build)
    {
        AddField<StringConnection, StringConnectionQueryBuilder>("productTags", build);
        return this;
    }

    public ShopQueryBuilder AddFieldProductTypes(Func<StringConnectionQueryBuilder, StringConnectionQueryBuilder> build)
    {
        AddField<StringConnection, StringConnectionQueryBuilder>("productTypes", build);
        return this;
    }

    public ShopQueryBuilder AddFieldProductVariants(Func<ProductVariantConnectionQueryBuilder, ProductVariantConnectionQueryBuilder> build)
    {
        AddField<ProductVariantConnection, ProductVariantConnectionQueryBuilder>("productVariants", build);
        return this;
    }

    public ShopQueryBuilder AddFieldProductVendors(Func<StringConnectionQueryBuilder, StringConnectionQueryBuilder> build)
    {
        AddField<StringConnection, StringConnectionQueryBuilder>("productVendors", build);
        return this;
    }

    [Obsolete("Use `QueryRoot.publicationsCount` instead.")]
    public ShopQueryBuilder AddFieldPublicationCount()
    {
        AddField("publicationCount");
        return this;
    }

    public ShopQueryBuilder AddFieldResourceLimits(Func<ShopResourceLimitsQueryBuilder, ShopResourceLimitsQueryBuilder> build)
    {
        AddField<ShopResourceLimits, ShopResourceLimitsQueryBuilder>("resourceLimits", build);
        return this;
    }

    public ShopQueryBuilder AddFieldRichTextEditorUrl()
    {
        AddField("richTextEditorUrl");
        return this;
    }

    public ShopQueryBuilder AddFieldSearch(Func<SearchResultConnectionQueryBuilder, SearchResultConnectionQueryBuilder> build)
    {
        AddField<SearchResultConnection, SearchResultConnectionQueryBuilder>("search", build);
        return this;
    }

    public ShopQueryBuilder AddFieldSearchFilters(Func<SearchFilterOptionsQueryBuilder, SearchFilterOptionsQueryBuilder> build)
    {
        AddField<SearchFilterOptions, SearchFilterOptionsQueryBuilder>("searchFilters", build);
        return this;
    }

    public ShopQueryBuilder AddFieldSetupRequired()
    {
        AddField("setupRequired");
        return this;
    }

    public ShopQueryBuilder AddFieldShipsToCountries()
    {
        AddField("shipsToCountries");
        return this;
    }

    public ShopQueryBuilder AddFieldShopOwnerName()
    {
        AddField("shopOwnerName");
        return this;
    }

    public ShopQueryBuilder AddFieldShopPolicies(Func<ShopPolicyQueryBuilder, ShopPolicyQueryBuilder> build)
    {
        AddField<ShopPolicy, ShopPolicyQueryBuilder>("shopPolicies", build);
        return this;
    }

    public ShopQueryBuilder AddFieldStaffMembers(Func<StaffMemberConnectionQueryBuilder, StaffMemberConnectionQueryBuilder> build)
    {
        AddField<StaffMemberConnection, StaffMemberConnectionQueryBuilder>("staffMembers", build);
        return this;
    }

    public ShopQueryBuilder AddFieldStorefrontAccessTokens(Func<StorefrontAccessTokenConnectionQueryBuilder, StorefrontAccessTokenConnectionQueryBuilder> build)
    {
        AddField<StorefrontAccessTokenConnection, StorefrontAccessTokenConnectionQueryBuilder>("storefrontAccessTokens", build);
        return this;
    }

    [Obsolete("Use `url` instead.")]
    public ShopQueryBuilder AddFieldStorefrontUrl()
    {
        AddField("storefrontUrl");
        return this;
    }

    public ShopQueryBuilder AddFieldTaxesIncluded()
    {
        AddField("taxesIncluded");
        return this;
    }

    public ShopQueryBuilder AddFieldTaxShipping()
    {
        AddField("taxShipping");
        return this;
    }

    public ShopQueryBuilder AddFieldTimezoneAbbreviation()
    {
        AddField("timezoneAbbreviation");
        return this;
    }

    public ShopQueryBuilder AddFieldTimezoneOffset()
    {
        AddField("timezoneOffset");
        return this;
    }

    public ShopQueryBuilder AddFieldTimezoneOffsetMinutes()
    {
        AddField("timezoneOffsetMinutes");
        return this;
    }

    public ShopQueryBuilder AddFieldTransactionalSmsDisabled()
    {
        AddField("transactionalSmsDisabled");
        return this;
    }

    public ShopQueryBuilder AddFieldTranslations(Func<TranslationQueryBuilder, TranslationQueryBuilder> build)
    {
        AddField<Translation, TranslationQueryBuilder>("translations", build);
        return this;
    }

    public ShopQueryBuilder AddFieldUnitSystem()
    {
        AddField("unitSystem");
        return this;
    }

    public ShopQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    public ShopQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }

    public ShopQueryBuilder AddFieldWeightUnit()
    {
        AddField("weightUnit");
        return this;
    }
}