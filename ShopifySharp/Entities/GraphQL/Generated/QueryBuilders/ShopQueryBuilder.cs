#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopQueryBuilder() : GraphQueryBuilder<Shop>("query shop")
{
    public ShopQueryBuilder AddFieldAccountOwner()
    {
        AddField("accountOwner");
        return this;
    }

    public ShopQueryBuilder AddFieldAlerts()
    {
        AddField("alerts");
        return this;
    }

    [Obsolete("Use `allProductCategoriesList` instead.")]
    public ShopQueryBuilder AddFieldAllProductCategories()
    {
        AddField("allProductCategories");
        return this;
    }

    public ShopQueryBuilder AddFieldAllProductCategoriesList()
    {
        AddField("allProductCategoriesList");
        return this;
    }

    [Obsolete("Not supported anymore.")]
    public ShopQueryBuilder AddFieldAnalyticsToken()
    {
        AddField("analyticsToken");
        return this;
    }

    [Obsolete("Use `QueryRoot.assignedFulfillmentOrders` instead. Details: https://shopify.dev/changelog/moving-the-shop-assignedfulfillmentorders-connection-to-queryroot")]
    public ShopQueryBuilder AddFieldAssignedFulfillmentOrders()
    {
        AddField("assignedFulfillmentOrders");
        return this;
    }

    public ShopQueryBuilder AddFieldAvailableChannelApps()
    {
        AddField("availableChannelApps");
        return this;
    }

    public ShopQueryBuilder AddFieldBillingAddress()
    {
        AddField("billingAddress");
        return this;
    }

    public ShopQueryBuilder AddFieldChannelDefinitionsForInstalledChannels()
    {
        AddField("channelDefinitionsForInstalledChannels");
        return this;
    }

    [Obsolete("Use `QueryRoot.channels` instead.")]
    public ShopQueryBuilder AddFieldChannels()
    {
        AddField("channels");
        return this;
    }

    public ShopQueryBuilder AddFieldCheckoutApiSupported()
    {
        AddField("checkoutApiSupported");
        return this;
    }

    [Obsolete("Use `QueryRoot.collections` instead.")]
    public ShopQueryBuilder AddFieldCollections()
    {
        AddField("collections");
        return this;
    }

    public ShopQueryBuilder AddFieldContactEmail()
    {
        AddField("contactEmail");
        return this;
    }

    public ShopQueryBuilder AddFieldCountriesInShippingZones()
    {
        AddField("countriesInShippingZones");
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

    public ShopQueryBuilder AddFieldCurrencyFormats()
    {
        AddField("currencyFormats");
        return this;
    }

    public ShopQueryBuilder AddFieldCurrencySettings()
    {
        AddField("currencySettings");
        return this;
    }

    public ShopQueryBuilder AddFieldCustomerAccounts()
    {
        AddField("customerAccounts");
        return this;
    }

    public ShopQueryBuilder AddFieldCustomerAccountsV2()
    {
        AddField("customerAccountsV2");
        return this;
    }

    [Obsolete("Use `QueryRoot.customers` instead.")]
    public ShopQueryBuilder AddFieldCustomers()
    {
        AddField("customers");
        return this;
    }

    public ShopQueryBuilder AddFieldCustomerTags()
    {
        AddField("customerTags");
        return this;
    }

    public ShopQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    [Obsolete("Use `domainsPaginated` instead.")]
    public ShopQueryBuilder AddFieldDomains()
    {
        AddField("domains");
        return this;
    }

    [Obsolete("Use `QueryRoot.draftOrders` instead.")]
    public ShopQueryBuilder AddFieldDraftOrders()
    {
        AddField("draftOrders");
        return this;
    }

    public ShopQueryBuilder AddFieldDraftOrderTags()
    {
        AddField("draftOrderTags");
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

    public ShopQueryBuilder AddFieldEntitlements()
    {
        AddField("entitlements");
        return this;
    }

    public ShopQueryBuilder AddFieldFeatures()
    {
        AddField("features");
        return this;
    }

    [Obsolete("Use `QueryRoot.fulfillmentOrders` instead.")]
    public ShopQueryBuilder AddFieldFulfillmentOrders()
    {
        AddField("fulfillmentOrders");
        return this;
    }

    public ShopQueryBuilder AddFieldFulfillmentServices()
    {
        AddField("fulfillmentServices");
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

    [Obsolete("Use `QueryRoot.inventoryItems` instead.")]
    public ShopQueryBuilder AddFieldInventoryItems()
    {
        AddField("inventoryItems");
        return this;
    }

    [Obsolete("Use `QueryRoot.pendingOrdersCount` instead.")]
    public ShopQueryBuilder AddFieldLimitedPendingOrderCount()
    {
        AddField("limitedPendingOrderCount");
        return this;
    }

    [Obsolete("Use `QueryRoot.locations` instead.")]
    public ShopQueryBuilder AddFieldLocations()
    {
        AddField("locations");
        return this;
    }

    public ShopQueryBuilder AddFieldMarketingSmsConsentEnabledAtCheckout()
    {
        AddField("marketingSmsConsentEnabledAtCheckout");
        return this;
    }

    public ShopQueryBuilder AddFieldMerchantApprovalSignals()
    {
        AddField("merchantApprovalSignals");
        return this;
    }

    public ShopQueryBuilder AddFieldMetafield()
    {
        AddField("metafield");
        return this;
    }

    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public ShopQueryBuilder AddFieldMetafieldDefinitions()
    {
        AddField("metafieldDefinitions");
        return this;
    }

    public ShopQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
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

    public ShopQueryBuilder AddFieldNavigationSettings()
    {
        AddField("navigationSettings");
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

    [Obsolete("Use `QueryRoot.orders` instead.")]
    public ShopQueryBuilder AddFieldOrders()
    {
        AddField("orders");
        return this;
    }

    public ShopQueryBuilder AddFieldOrderTags()
    {
        AddField("orderTags");
        return this;
    }

    public ShopQueryBuilder AddFieldPaymentSettings()
    {
        AddField("paymentSettings");
        return this;
    }

    public ShopQueryBuilder AddFieldPlan()
    {
        AddField("plan");
        return this;
    }

    public ShopQueryBuilder AddFieldPrimaryDomain()
    {
        AddField("primaryDomain");
        return this;
    }

    [Obsolete("Use `files` instead. See [filesQuery](https://shopify.dev/docs/api/admin-graphql/latest/queries/files) and its [query](https://shopify.dev/docs/api/admin-graphql/latest/queries/files#argument-query) argument for more information.")]
    public ShopQueryBuilder AddFieldProductImages()
    {
        AddField("productImages");
        return this;
    }

    [Obsolete("Use `QueryRoot.products`.")]
    public ShopQueryBuilder AddFieldProducts()
    {
        AddField("products");
        return this;
    }

    [Obsolete("Use `QueryRoot.productTags` instead.")]
    public ShopQueryBuilder AddFieldProductTags()
    {
        AddField("productTags");
        return this;
    }

    [Obsolete("Use `QueryRoot.productTypes` instead.")]
    public ShopQueryBuilder AddFieldProductTypes()
    {
        AddField("productTypes");
        return this;
    }

    [Obsolete("Use `QueryRoot.productVariants` instead.")]
    public ShopQueryBuilder AddFieldProductVariants()
    {
        AddField("productVariants");
        return this;
    }

    [Obsolete("Use `QueryRoot.productVendors` instead.")]
    public ShopQueryBuilder AddFieldProductVendors()
    {
        AddField("productVendors");
        return this;
    }

    [Obsolete("Use `QueryRoot.publicationsCount` instead.")]
    public ShopQueryBuilder AddFieldPublicationCount()
    {
        AddField("publicationCount");
        return this;
    }

    public ShopQueryBuilder AddFieldResourceLimits()
    {
        AddField("resourceLimits");
        return this;
    }

    public ShopQueryBuilder AddFieldRichTextEditorUrl()
    {
        AddField("richTextEditorUrl");
        return this;
    }

    public ShopQueryBuilder AddFieldSearch()
    {
        AddField("search");
        return this;
    }

    public ShopQueryBuilder AddFieldSearchFilters()
    {
        AddField("searchFilters");
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

    public ShopQueryBuilder AddFieldShopPolicies()
    {
        AddField("shopPolicies");
        return this;
    }

    [Obsolete("Use `QueryRoot.staffMembers` instead.")]
    public ShopQueryBuilder AddFieldStaffMembers()
    {
        AddField("staffMembers");
        return this;
    }

    public ShopQueryBuilder AddFieldStorefrontAccessTokens()
    {
        AddField("storefrontAccessTokens");
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

    public ShopQueryBuilder AddFieldTranslations()
    {
        AddField("translations");
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