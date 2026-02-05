#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ShopOperationQueryBuilder : FieldsQueryBuilderBase<Shop, ShopOperationQueryBuilder>, IGraphOperationQueryBuilder<Shop>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override ShopOperationQueryBuilder Self => this;

        public ShopOperationQueryBuilder() : this("shop")
        {
        }

        public ShopOperationQueryBuilder(string name) : base(new Query<Shop>(name))
        {
        }

        public ShopOperationQueryBuilder(IQuery<Shop> query) : base(query)
        {
        }

        public ShopOperationQueryBuilder AccountOwner(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("accountOwner");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public ShopOperationQueryBuilder Alerts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopAlertQueryBuilder> build)
        {
            var query = new Query<ShopAlert>("alerts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopAlertQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopAlert>(query);
            return this;
        }

        public ShopOperationQueryBuilder AllProductCategories(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductCategoryQueryBuilder> build)
        {
            var query = new Query<ProductCategory>("allProductCategories");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductCategory>(query);
            return this;
        }

        public ShopOperationQueryBuilder AllProductCategoriesList(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategory>("allProductCategoriesList");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategory>(query);
            return this;
        }

        [Obsolete("Not supported anymore.")]
        public ShopOperationQueryBuilder AnalyticsToken()
        {
            base.InnerQuery.AddField("analyticsToken");
            return this;
        }

        public ShopOperationQueryBuilder AssignedFulfillmentOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("assignedFulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder AvailableChannelApps(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppConnectionQueryBuilder> build)
        {
            var query = new Query<AppConnection>("availableChannelApps");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopAddressQueryBuilder> build)
        {
            var query = new Query<ShopAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopAddress>(query);
            return this;
        }

        public ShopOperationQueryBuilder ChannelDefinitionsForInstalledChannels(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AvailableChannelDefinitionsByChannelQueryBuilder> build)
        {
            var query = new Query<AvailableChannelDefinitionsByChannel>("channelDefinitionsForInstalledChannels");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AvailableChannelDefinitionsByChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AvailableChannelDefinitionsByChannel>(query);
            return this;
        }

        public ShopOperationQueryBuilder Channels(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelConnectionQueryBuilder> build)
        {
            var query = new Query<ChannelConnection>("channels");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder CheckoutApiSupported()
        {
            base.InnerQuery.AddField("checkoutApiSupported");
            return this;
        }

        public ShopOperationQueryBuilder Collections(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder ContactEmail()
        {
            base.InnerQuery.AddField("contactEmail");
            return this;
        }

        public ShopOperationQueryBuilder CountriesInShippingZones(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountriesInShippingZonesQueryBuilder> build)
        {
            var query = new Query<CountriesInShippingZones>("countriesInShippingZones");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountriesInShippingZonesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountriesInShippingZones>(query);
            return this;
        }

        public ShopOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ShopOperationQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public ShopOperationQueryBuilder CurrencyFormats(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CurrencyFormatsQueryBuilder> build)
        {
            var query = new Query<CurrencyFormats>("currencyFormats");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CurrencyFormatsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CurrencyFormats>(query);
            return this;
        }

        public ShopOperationQueryBuilder CurrencySettings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CurrencySettingConnectionQueryBuilder> build)
        {
            var query = new Query<CurrencySettingConnection>("currencySettings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CurrencySettingConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CurrencySettingConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder CustomerAccounts()
        {
            base.InnerQuery.AddField("customerAccounts");
            return this;
        }

        public ShopOperationQueryBuilder CustomerAccountsV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerAccountsV2QueryBuilder> build)
        {
            var query = new Query<CustomerAccountsV2>("customerAccountsV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerAccountsV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerAccountsV2>(query);
            return this;
        }

        public ShopOperationQueryBuilder Customers(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerConnection>("customers");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder CustomerTags(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("customerTags");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public ShopOperationQueryBuilder Domains(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DomainQueryBuilder> build)
        {
            var query = new Query<Domain>("domains");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DomainQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Domain>(query);
            return this;
        }

        public ShopOperationQueryBuilder DraftOrderTags(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("draftOrderTags");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public ShopOperationQueryBuilder EnabledPresentmentCurrencies()
        {
            base.InnerQuery.AddField("enabledPresentmentCurrencies");
            return this;
        }

        public ShopOperationQueryBuilder Entitlements(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EntitlementsTypeQueryBuilder> build)
        {
            var query = new Query<EntitlementsType>("entitlements");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EntitlementsTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EntitlementsType>(query);
            return this;
        }

        public ShopOperationQueryBuilder Features(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopFeaturesQueryBuilder> build)
        {
            var query = new Query<ShopFeatures>("features");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopFeaturesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopFeatures>(query);
            return this;
        }

        public ShopOperationQueryBuilder FulfillmentOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("fulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder FulfillmentServices(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("fulfillmentServices");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public ShopOperationQueryBuilder IanaTimezone()
        {
            base.InnerQuery.AddField("ianaTimezone");
            return this;
        }

        public ShopOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopOperationQueryBuilder InventoryItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryItemConnection>("inventoryItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItemConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder LimitedPendingOrderCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LimitedPendingOrderCountQueryBuilder> build)
        {
            var query = new Query<LimitedPendingOrderCount>("limitedPendingOrderCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LimitedPendingOrderCountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LimitedPendingOrderCount>(query);
            return this;
        }

        public ShopOperationQueryBuilder Locations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("locations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder MarketingSmsConsentEnabledAtCheckout()
        {
            base.InnerQuery.AddField("marketingSmsConsentEnabledAtCheckout");
            return this;
        }

        public ShopOperationQueryBuilder MerchantApprovalSignals(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MerchantApprovalSignalsQueryBuilder> build)
        {
            var query = new Query<MerchantApprovalSignals>("merchantApprovalSignals");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MerchantApprovalSignalsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MerchantApprovalSignals>(query);
            return this;
        }

        public ShopOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public ShopOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder MyshopifyDomain()
        {
            base.InnerQuery.AddField("myshopifyDomain");
            return this;
        }

        public ShopOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ShopOperationQueryBuilder NavigationSettings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NavigationItemQueryBuilder> build)
        {
            var query = new Query<NavigationItem>("navigationSettings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NavigationItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<NavigationItem>(query);
            return this;
        }

        public ShopOperationQueryBuilder OrderNumberFormatPrefix()
        {
            base.InnerQuery.AddField("orderNumberFormatPrefix");
            return this;
        }

        public ShopOperationQueryBuilder OrderNumberFormatSuffix()
        {
            base.InnerQuery.AddField("orderNumberFormatSuffix");
            return this;
        }

        public ShopOperationQueryBuilder Orders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder OrderTags(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("orderTags");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder PaymentSettings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentSettingsQueryBuilder> build)
        {
            var query = new Query<PaymentSettings>("paymentSettings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentSettingsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentSettings>(query);
            return this;
        }

        public ShopOperationQueryBuilder Plan(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPlanQueryBuilder> build)
        {
            var query = new Query<ShopPlan>("plan");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPlanQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPlan>(query);
            return this;
        }

        public ShopOperationQueryBuilder PrimaryDomain(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DomainQueryBuilder> build)
        {
            var query = new Query<Domain>("primaryDomain");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DomainQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Domain>(query);
            return this;
        }

        public ShopOperationQueryBuilder ProductImages(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageConnectionQueryBuilder> build)
        {
            var query = new Query<ImageConnection>("productImages");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ImageConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder Products(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("products");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder ProductTags(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("productTags");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder ProductTypes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("productTypes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder ProductVendors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("productVendors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        [Obsolete("Use `QueryRoot.publicationsCount` instead.")]
        public ShopOperationQueryBuilder PublicationCount()
        {
            base.InnerQuery.AddField("publicationCount");
            return this;
        }

        public ShopOperationQueryBuilder ResourceLimits(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopResourceLimitsQueryBuilder> build)
        {
            var query = new Query<ShopResourceLimits>("resourceLimits");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopResourceLimitsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopResourceLimits>(query);
            return this;
        }

        public ShopOperationQueryBuilder RichTextEditorUrl()
        {
            base.InnerQuery.AddField("richTextEditorUrl");
            return this;
        }

        public ShopOperationQueryBuilder Search(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SearchResultConnectionQueryBuilder> build)
        {
            var query = new Query<SearchResultConnection>("search");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SearchResultConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SearchResultConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder SearchFilters(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SearchFilterOptionsQueryBuilder> build)
        {
            var query = new Query<SearchFilterOptions>("searchFilters");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SearchFilterOptionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SearchFilterOptions>(query);
            return this;
        }

        public ShopOperationQueryBuilder SetupRequired()
        {
            base.InnerQuery.AddField("setupRequired");
            return this;
        }

        public ShopOperationQueryBuilder ShipsToCountries()
        {
            base.InnerQuery.AddField("shipsToCountries");
            return this;
        }

        public ShopOperationQueryBuilder ShopAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopAddressQueryBuilder> build)
        {
            var query = new Query<ShopAddress>("shopAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopAddress>(query);
            return this;
        }

        public ShopOperationQueryBuilder ShopOwnerName()
        {
            base.InnerQuery.AddField("shopOwnerName");
            return this;
        }

        public ShopOperationQueryBuilder ShopPolicies(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPolicyQueryBuilder> build)
        {
            var query = new Query<ShopPolicy>("shopPolicies");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPolicy>(query);
            return this;
        }

        public ShopOperationQueryBuilder StaffMembers(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberConnectionQueryBuilder> build)
        {
            var query = new Query<StaffMemberConnection>("staffMembers");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMemberConnection>(query);
            return this;
        }

        public ShopOperationQueryBuilder StorefrontAccessTokens(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StorefrontAccessTokenConnectionQueryBuilder> build)
        {
            var query = new Query<StorefrontAccessTokenConnection>("storefrontAccessTokens");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StorefrontAccessTokenConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StorefrontAccessTokenConnection>(query);
            return this;
        }

        [Obsolete("Use `url` instead.")]
        public ShopOperationQueryBuilder StorefrontUrl()
        {
            base.InnerQuery.AddField("storefrontUrl");
            return this;
        }

        public ShopOperationQueryBuilder TaxesIncluded()
        {
            base.InnerQuery.AddField("taxesIncluded");
            return this;
        }

        public ShopOperationQueryBuilder TaxShipping()
        {
            base.InnerQuery.AddField("taxShipping");
            return this;
        }

        public ShopOperationQueryBuilder TimezoneAbbreviation()
        {
            base.InnerQuery.AddField("timezoneAbbreviation");
            return this;
        }

        public ShopOperationQueryBuilder TimezoneOffset()
        {
            base.InnerQuery.AddField("timezoneOffset");
            return this;
        }

        public ShopOperationQueryBuilder TimezoneOffsetMinutes()
        {
            base.InnerQuery.AddField("timezoneOffsetMinutes");
            return this;
        }

        public ShopOperationQueryBuilder TransactionalSmsDisabled()
        {
            base.InnerQuery.AddField("transactionalSmsDisabled");
            return this;
        }

        public ShopOperationQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public ShopOperationQueryBuilder UnitSystem()
        {
            base.InnerQuery.AddField("unitSystem");
            return this;
        }

        public ShopOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ShopOperationQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }

        public ShopOperationQueryBuilder WeightUnit()
        {
            base.InnerQuery.AddField("weightUnit");
            return this;
        }
    }
}