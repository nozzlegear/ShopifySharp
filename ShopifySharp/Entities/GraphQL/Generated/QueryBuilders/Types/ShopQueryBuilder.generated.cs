#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ShopQueryBuilder : FieldsQueryBuilderBase<Shop, ShopQueryBuilder>
    {
        protected override ShopQueryBuilder Self => this;

        public ShopQueryBuilder() : this("shop")
        {
        }

        public ShopQueryBuilder(string name) : base(new Query<Shop>(name))
        {
        }

        public ShopQueryBuilder(IQuery<Shop> query) : base(query)
        {
        }

        public ShopQueryBuilder AccountOwner(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("accountOwner");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public ShopQueryBuilder Alerts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopAlertQueryBuilder> build)
        {
            var query = new Query<ShopAlert>("alerts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopAlertQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopAlert>(query);
            return this;
        }

        public ShopQueryBuilder AllProductCategories(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductCategoryQueryBuilder> build)
        {
            var query = new Query<ProductCategory>("allProductCategories");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductCategory>(query);
            return this;
        }

        public ShopQueryBuilder AllProductCategoriesList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategory>("allProductCategoriesList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategory>(query);
            return this;
        }

        [Obsolete("Not supported anymore.")]
        public ShopQueryBuilder AnalyticsToken()
        {
            base.InnerQuery.AddField("analyticsToken");
            return this;
        }

        public ShopQueryBuilder AssignedFulfillmentOrders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("assignedFulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public ShopQueryBuilder AvailableChannelApps(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppConnectionQueryBuilder> build)
        {
            var query = new Query<AppConnection>("availableChannelApps");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppConnection>(query);
            return this;
        }

        public ShopQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopAddressQueryBuilder> build)
        {
            var query = new Query<ShopAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopAddress>(query);
            return this;
        }

        public ShopQueryBuilder ChannelDefinitionsForInstalledChannels(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AvailableChannelDefinitionsByChannelQueryBuilder> build)
        {
            var query = new Query<AvailableChannelDefinitionsByChannel>("channelDefinitionsForInstalledChannels");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AvailableChannelDefinitionsByChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AvailableChannelDefinitionsByChannel>(query);
            return this;
        }

        public ShopQueryBuilder Channels(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelConnectionQueryBuilder> build)
        {
            var query = new Query<ChannelConnection>("channels");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelConnection>(query);
            return this;
        }

        public ShopQueryBuilder CheckoutApiSupported()
        {
            base.InnerQuery.AddField("checkoutApiSupported");
            return this;
        }

        public ShopQueryBuilder Collections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public ShopQueryBuilder ContactEmail()
        {
            base.InnerQuery.AddField("contactEmail");
            return this;
        }

        public ShopQueryBuilder CountriesInShippingZones(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountriesInShippingZonesQueryBuilder> build)
        {
            var query = new Query<CountriesInShippingZones>("countriesInShippingZones");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountriesInShippingZonesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountriesInShippingZones>(query);
            return this;
        }

        public ShopQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ShopQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public ShopQueryBuilder CurrencyFormats(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CurrencyFormatsQueryBuilder> build)
        {
            var query = new Query<CurrencyFormats>("currencyFormats");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CurrencyFormatsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CurrencyFormats>(query);
            return this;
        }

        public ShopQueryBuilder CurrencySettings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CurrencySettingConnectionQueryBuilder> build)
        {
            var query = new Query<CurrencySettingConnection>("currencySettings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CurrencySettingConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CurrencySettingConnection>(query);
            return this;
        }

        public ShopQueryBuilder CustomerAccounts()
        {
            base.InnerQuery.AddField("customerAccounts");
            return this;
        }

        public ShopQueryBuilder CustomerAccountsV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountsV2QueryBuilder> build)
        {
            var query = new Query<CustomerAccountsV2>("customerAccountsV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountsV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerAccountsV2>(query);
            return this;
        }

        public ShopQueryBuilder Customers(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerConnection>("customers");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerConnection>(query);
            return this;
        }

        public ShopQueryBuilder CustomerTags(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("customerTags");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public ShopQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public ShopQueryBuilder Domains(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DomainQueryBuilder> build)
        {
            var query = new Query<Domain>("domains");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DomainQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Domain>(query);
            return this;
        }

        public ShopQueryBuilder DraftOrderTags(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("draftOrderTags");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public ShopQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public ShopQueryBuilder EnabledPresentmentCurrencies()
        {
            base.InnerQuery.AddField("enabledPresentmentCurrencies");
            return this;
        }

        public ShopQueryBuilder Entitlements(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EntitlementsTypeQueryBuilder> build)
        {
            var query = new Query<EntitlementsType>("entitlements");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EntitlementsTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EntitlementsType>(query);
            return this;
        }

        public ShopQueryBuilder Features(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopFeaturesQueryBuilder> build)
        {
            var query = new Query<ShopFeatures>("features");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopFeaturesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopFeatures>(query);
            return this;
        }

        public ShopQueryBuilder FulfillmentOrders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("fulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public ShopQueryBuilder FulfillmentServices(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("fulfillmentServices");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public ShopQueryBuilder IanaTimezone()
        {
            base.InnerQuery.AddField("ianaTimezone");
            return this;
        }

        public ShopQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopQueryBuilder InventoryItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryItemConnection>("inventoryItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItemConnection>(query);
            return this;
        }

        public ShopQueryBuilder LimitedPendingOrderCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LimitedPendingOrderCountQueryBuilder> build)
        {
            var query = new Query<LimitedPendingOrderCount>("limitedPendingOrderCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LimitedPendingOrderCountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LimitedPendingOrderCount>(query);
            return this;
        }

        public ShopQueryBuilder Locations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("locations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public ShopQueryBuilder MarketingSmsConsentEnabledAtCheckout()
        {
            base.InnerQuery.AddField("marketingSmsConsentEnabledAtCheckout");
            return this;
        }

        public ShopQueryBuilder MerchantApprovalSignals(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MerchantApprovalSignalsQueryBuilder> build)
        {
            var query = new Query<MerchantApprovalSignals>("merchantApprovalSignals");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MerchantApprovalSignalsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MerchantApprovalSignals>(query);
            return this;
        }

        public ShopQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public ShopQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public ShopQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public ShopQueryBuilder MyshopifyDomain()
        {
            base.InnerQuery.AddField("myshopifyDomain");
            return this;
        }

        public ShopQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ShopQueryBuilder NavigationSettings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.NavigationItemQueryBuilder> build)
        {
            var query = new Query<NavigationItem>("navigationSettings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.NavigationItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<NavigationItem>(query);
            return this;
        }

        public ShopQueryBuilder OrderNumberFormatPrefix()
        {
            base.InnerQuery.AddField("orderNumberFormatPrefix");
            return this;
        }

        public ShopQueryBuilder OrderNumberFormatSuffix()
        {
            base.InnerQuery.AddField("orderNumberFormatSuffix");
            return this;
        }

        public ShopQueryBuilder Orders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public ShopQueryBuilder OrderTags(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("orderTags");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public ShopQueryBuilder PaymentSettings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentSettingsQueryBuilder> build)
        {
            var query = new Query<PaymentSettings>("paymentSettings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentSettingsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentSettings>(query);
            return this;
        }

        public ShopQueryBuilder Plan(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPlanQueryBuilder> build)
        {
            var query = new Query<ShopPlan>("plan");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPlanQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPlan>(query);
            return this;
        }

        public ShopQueryBuilder PrimaryDomain(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DomainQueryBuilder> build)
        {
            var query = new Query<Domain>("primaryDomain");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DomainQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Domain>(query);
            return this;
        }

        public ShopQueryBuilder ProductImages(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageConnectionQueryBuilder> build)
        {
            var query = new Query<ImageConnection>("productImages");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ImageConnection>(query);
            return this;
        }

        public ShopQueryBuilder Products(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("products");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public ShopQueryBuilder ProductTags(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("productTags");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public ShopQueryBuilder ProductTypes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("productTypes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public ShopQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }

        public ShopQueryBuilder ProductVendors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("productVendors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        [Obsolete("Use `QueryRoot.publicationsCount` instead.")]
        public ShopQueryBuilder PublicationCount()
        {
            base.InnerQuery.AddField("publicationCount");
            return this;
        }

        public ShopQueryBuilder ResourceLimits(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopResourceLimitsQueryBuilder> build)
        {
            var query = new Query<ShopResourceLimits>("resourceLimits");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopResourceLimitsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopResourceLimits>(query);
            return this;
        }

        public ShopQueryBuilder RichTextEditorUrl()
        {
            base.InnerQuery.AddField("richTextEditorUrl");
            return this;
        }

        public ShopQueryBuilder Search(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SearchResultConnectionQueryBuilder> build)
        {
            var query = new Query<SearchResultConnection>("search");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SearchResultConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SearchResultConnection>(query);
            return this;
        }

        public ShopQueryBuilder SearchFilters(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SearchFilterOptionsQueryBuilder> build)
        {
            var query = new Query<SearchFilterOptions>("searchFilters");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SearchFilterOptionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SearchFilterOptions>(query);
            return this;
        }

        public ShopQueryBuilder SetupRequired()
        {
            base.InnerQuery.AddField("setupRequired");
            return this;
        }

        public ShopQueryBuilder ShipsToCountries()
        {
            base.InnerQuery.AddField("shipsToCountries");
            return this;
        }

        public ShopQueryBuilder ShopAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopAddressQueryBuilder> build)
        {
            var query = new Query<ShopAddress>("shopAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopAddress>(query);
            return this;
        }

        public ShopQueryBuilder ShopOwnerName()
        {
            base.InnerQuery.AddField("shopOwnerName");
            return this;
        }

        public ShopQueryBuilder ShopPolicies(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPolicyQueryBuilder> build)
        {
            var query = new Query<ShopPolicy>("shopPolicies");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPolicy>(query);
            return this;
        }

        public ShopQueryBuilder StaffMembers(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberConnectionQueryBuilder> build)
        {
            var query = new Query<StaffMemberConnection>("staffMembers");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMemberConnection>(query);
            return this;
        }

        public ShopQueryBuilder StorefrontAccessTokens(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StorefrontAccessTokenConnectionQueryBuilder> build)
        {
            var query = new Query<StorefrontAccessTokenConnection>("storefrontAccessTokens");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StorefrontAccessTokenConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StorefrontAccessTokenConnection>(query);
            return this;
        }

        [Obsolete("Use `url` instead.")]
        public ShopQueryBuilder StorefrontUrl()
        {
            base.InnerQuery.AddField("storefrontUrl");
            return this;
        }

        public ShopQueryBuilder TaxesIncluded()
        {
            base.InnerQuery.AddField("taxesIncluded");
            return this;
        }

        public ShopQueryBuilder TaxShipping()
        {
            base.InnerQuery.AddField("taxShipping");
            return this;
        }

        public ShopQueryBuilder TimezoneAbbreviation()
        {
            base.InnerQuery.AddField("timezoneAbbreviation");
            return this;
        }

        public ShopQueryBuilder TimezoneOffset()
        {
            base.InnerQuery.AddField("timezoneOffset");
            return this;
        }

        public ShopQueryBuilder TimezoneOffsetMinutes()
        {
            base.InnerQuery.AddField("timezoneOffsetMinutes");
            return this;
        }

        public ShopQueryBuilder TransactionalSmsDisabled()
        {
            base.InnerQuery.AddField("transactionalSmsDisabled");
            return this;
        }

        public ShopQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public ShopQueryBuilder UnitSystem()
        {
            base.InnerQuery.AddField("unitSystem");
            return this;
        }

        public ShopQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ShopQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }

        public ShopQueryBuilder WeightUnit()
        {
            base.InnerQuery.AddField("weightUnit");
            return this;
        }
    }
}