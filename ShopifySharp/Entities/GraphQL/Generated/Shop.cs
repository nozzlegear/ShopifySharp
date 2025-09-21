#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a collection of general settings and information about the shop.
/// </summary>
public record Shop : IGraphQLUnionCase, IGraphQLObject, IHasMetafieldDefinitions, IHasMetafields, IHasPublishedTranslations, INode
{
    /// <summary>
    /// Account owner information.
    /// </summary>
    [JsonPropertyName("accountOwner")]
    public StaffMember? accountOwner { get; set; } = null;

    /// <summary>
    /// A list of the shop's active alert messages that appear in the Shopify admin.
    /// </summary>
    [JsonPropertyName("alerts")]
    public ICollection<ShopAlert>? alerts { get; set; } = null;

    /// <summary>
    /// A list of the shop's product categories. Limit: 1000 product categories.
    /// </summary>
    [JsonPropertyName("allProductCategories")]
    [Obsolete("Use `allProductCategoriesList` instead.")]
    public ICollection<ProductCategory>? allProductCategories { get; set; } = null;

    /// <summary>
    /// A list of the shop's product categories. Limit: 1000 product categories.
    /// </summary>
    [JsonPropertyName("allProductCategoriesList")]
    public ICollection<TaxonomyCategory>? allProductCategoriesList { get; set; } = null;

    /// <summary>
    /// The token required to query the shop's reports or dashboards.
    /// </summary>
    [JsonPropertyName("analyticsToken")]
    [Obsolete("Not supported anymore.")]
    public string? analyticsToken { get; set; } = null;

    /// <summary>
    /// The paginated list of fulfillment orders assigned to the shop locations owned by the app.
    /// Assigned fulfillment orders are fulfillment orders that are set to be fulfilled from locations
    /// managed by
    /// [fulfillment services](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentService)
    /// that are registered by the app.
    /// One app (api_client) can host multiple fulfillment services on a shop.
    /// Each fulfillment service manages a dedicated location on a shop.
    /// Assigned fulfillment orders can have associated
    /// [fulfillment requests](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderRequestStatus),
    /// or might currently not be requested to be fulfilled.
    /// The app must have `read_assigned_fulfillment_orders`
    /// [access scope](https://shopify.dev/docs/api/usage/access-scopes)
    /// to be able to retrieve fulfillment orders assigned to its locations.
    /// All assigned fulfillment orders (except those with the `CLOSED` status) will be returned by default.
    /// Perform filtering with the `assignmentStatus` argument
    /// to receive only fulfillment orders that have been requested to be fulfilled.
    /// </summary>
    [JsonPropertyName("assignedFulfillmentOrders")]
    [Obsolete("Use `QueryRoot.assignedFulfillmentOrders` instead. Details: https://shopify.dev/changelog/moving-the-shop-assignedfulfillmentorders-connection-to-queryroot")]
    public FulfillmentOrderConnection? assignedFulfillmentOrders { get; set; } = null;

    /// <summary>
    /// The list of sales channels not currently installed on the shop.
    /// </summary>
    [JsonPropertyName("availableChannelApps")]
    public AppConnection? availableChannelApps { get; set; } = null;

    /// <summary>
    /// The shop's billing address information.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public ShopAddress? billingAddress { get; set; } = null;

    /// <summary>
    /// List of all channel definitions associated with a shop.
    /// </summary>
    [JsonPropertyName("channelDefinitionsForInstalledChannels")]
    public ICollection<AvailableChannelDefinitionsByChannel>? channelDefinitionsForInstalledChannels { get; set; } = null;

    /// <summary>
    /// List of the shop's active sales channels.
    /// </summary>
    [JsonPropertyName("channels")]
    [Obsolete("Use `QueryRoot.channels` instead.")]
    public ChannelConnection? channels { get; set; } = null;

    /// <summary>
    /// Specifies whether the shop supports checkouts via Checkout API.
    /// </summary>
    [JsonPropertyName("checkoutApiSupported")]
    public bool? checkoutApiSupported { get; set; } = null;

    /// <summary>
    /// List of the shop's collections.
    /// </summary>
    [JsonPropertyName("collections")]
    [Obsolete("Use `QueryRoot.collections` instead.")]
    public CollectionConnection? collections { get; set; } = null;

    /// <summary>
    /// The public-facing contact email address for the shop.
    /// Customers will use this email to communicate with the shop owner.
    /// </summary>
    [JsonPropertyName("contactEmail")]
    public string? contactEmail { get; set; } = null;

    /// <summary>
    /// Countries that have been defined in shipping zones for the shop.
    /// </summary>
    [JsonPropertyName("countriesInShippingZones")]
    public CountriesInShippingZones? countriesInShippingZones { get; set; } = null;

    /// <summary>
    /// The date and time when the shop was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The three letter code for the currency that the shop sells in.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public CurrencyCode? currencyCode { get; set; } = null;

    /// <summary>
    /// How currencies are displayed on your store.
    /// </summary>
    [JsonPropertyName("currencyFormats")]
    public CurrencyFormats? currencyFormats { get; set; } = null;

    /// <summary>
    /// The presentment currency settings for the shop excluding the shop's own currency.
    /// </summary>
    [JsonPropertyName("currencySettings")]
    public CurrencySettingConnection? currencySettings { get; set; } = null;

    /// <summary>
    /// Whether customer accounts are required, optional, or disabled for the shop.
    /// </summary>
    [JsonPropertyName("customerAccounts")]
    public ShopCustomerAccountsSetting? customerAccounts { get; set; } = null;

    /// <summary>
    /// Information about the shop's customer accounts.
    /// </summary>
    [JsonPropertyName("customerAccountsV2")]
    public CustomerAccountsV2? customerAccountsV2 { get; set; } = null;

    /// <summary>
    /// Customer accounts associated to the shop.
    /// </summary>
    [JsonPropertyName("customers")]
    [Obsolete("Use `QueryRoot.customers` instead.")]
    public CustomerConnection? customers { get; set; } = null;

    /// <summary>
    /// A list of tags that have been added to customer accounts.
    /// </summary>
    [JsonPropertyName("customerTags")]
    public StringConnection? customerTags { get; set; } = null;

    /// <summary>
    /// The shop's meta description used in search engine results.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The domains configured for the shop.
    /// </summary>
    [JsonPropertyName("domains")]
    [Obsolete("Use `domainsPaginated` instead.")]
    public ICollection<Domain>? domains { get; set; } = null;

    /// <summary>
    /// List of saved draft orders on the shop.
    /// </summary>
    [JsonPropertyName("draftOrders")]
    [Obsolete("Use `QueryRoot.draftOrders` instead.")]
    public DraftOrderConnection? draftOrders { get; set; } = null;

    /// <summary>
    /// A list of tags that have been added to draft orders.
    /// </summary>
    [JsonPropertyName("draftOrderTags")]
    public StringConnection? draftOrderTags { get; set; } = null;

    /// <summary>
    /// The shop owner's email address.
    /// Shopify will use this email address to communicate with the shop owner.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// The presentment currencies enabled for the shop.
    /// </summary>
    [JsonPropertyName("enabledPresentmentCurrencies")]
    public ICollection<CurrencyCode>? enabledPresentmentCurrencies { get; set; } = null;

    /// <summary>
    /// The entitlements for a shop.
    /// </summary>
    [JsonPropertyName("entitlements")]
    public EntitlementsType? entitlements { get; set; } = null;

    /// <summary>
    /// The set of features enabled for the shop.
    /// </summary>
    [JsonPropertyName("features")]
    public ShopFeatures? features { get; set; } = null;

    /// <summary>
    /// The paginated list of merchant-managed and third-party fulfillment orders.
    /// </summary>
    [JsonPropertyName("fulfillmentOrders")]
    [Obsolete("Use `QueryRoot.fulfillmentOrders` instead.")]
    public FulfillmentOrderConnection? fulfillmentOrders { get; set; } = null;

    /// <summary>
    /// List of the shop's installed fulfillment services.
    /// </summary>
    [JsonPropertyName("fulfillmentServices")]
    public ICollection<FulfillmentService>? fulfillmentServices { get; set; } = null;

    /// <summary>
    /// The shop's time zone as defined by the IANA.
    /// </summary>
    [JsonPropertyName("ianaTimezone")]
    public string? ianaTimezone { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// List of the shop's inventory items.
    /// </summary>
    [JsonPropertyName("inventoryItems")]
    [Obsolete("Use `QueryRoot.inventoryItems` instead.")]
    public InventoryItemConnection? inventoryItems { get; set; } = null;

    /// <summary>
    /// The number of pendings orders on the shop.
    /// Limited to a maximum of 10000.
    /// </summary>
    [JsonPropertyName("limitedPendingOrderCount")]
    [Obsolete("Use `QueryRoot.pendingOrdersCount` instead.")]
    public LimitedPendingOrderCount? limitedPendingOrderCount { get; set; } = null;

    /// <summary>
    /// List of active locations of the shop.
    /// </summary>
    [JsonPropertyName("locations")]
    [Obsolete("Use `QueryRoot.locations` instead.")]
    public LocationConnection? locations { get; set; } = null;

    /// <summary>
    /// Whether SMS marketing has been enabled on the shop's checkout configuration settings.
    /// </summary>
    [JsonPropertyName("marketingSmsConsentEnabledAtCheckout")]
    public bool? marketingSmsConsentEnabledAtCheckout { get; set; } = null;

    /// <summary>
    /// The approval signals for a shop to support onboarding to channel apps.
    /// </summary>
    [JsonPropertyName("merchantApprovalSignals")]
    public MerchantApprovalSignals? merchantApprovalSignals { get; set; } = null;

    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; } = null;

    /// <summary>
    /// List of metafield definitions.
    /// </summary>
    [JsonPropertyName("metafieldDefinitions")]
    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public MetafieldDefinitionConnection? metafieldDefinitions { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// The shop's .myshopify.com domain name.
    /// </summary>
    [JsonPropertyName("myshopifyDomain")]
    public string? myshopifyDomain { get; set; } = null;

    /// <summary>
    /// The shop's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The shop's settings related to navigation.
    /// </summary>
    [JsonPropertyName("navigationSettings")]
    public ICollection<NavigationItem>? navigationSettings { get; set; } = null;

    /// <summary>
    /// The prefix that appears before order numbers.
    /// </summary>
    [JsonPropertyName("orderNumberFormatPrefix")]
    public string? orderNumberFormatPrefix { get; set; } = null;

    /// <summary>
    /// The suffix that appears after order numbers.
    /// </summary>
    [JsonPropertyName("orderNumberFormatSuffix")]
    public string? orderNumberFormatSuffix { get; set; } = null;

    /// <summary>
    /// A list of the shop's orders.
    /// </summary>
    [JsonPropertyName("orders")]
    [Obsolete("Use `QueryRoot.orders` instead.")]
    public OrderConnection? orders { get; set; } = null;

    /// <summary>
    /// A list of tags that have been added to orders.
    /// </summary>
    [JsonPropertyName("orderTags")]
    public StringConnection? orderTags { get; set; } = null;

    /// <summary>
    /// The shop's settings related to payments.
    /// </summary>
    [JsonPropertyName("paymentSettings")]
    public PaymentSettings? paymentSettings { get; set; } = null;

    /// <summary>
    /// The shop's billing plan.
    /// </summary>
    [JsonPropertyName("plan")]
    public ShopPlan? plan { get; set; } = null;

    /// <summary>
    /// The primary domain of the shop's online store.
    /// </summary>
    [JsonPropertyName("primaryDomain")]
    public Domain? primaryDomain { get; set; } = null;

    /// <summary>
    /// The list of all images of all products for the shop.
    /// </summary>
    [JsonPropertyName("productImages")]
    [Obsolete("Use `files` instead. See [filesQuery](https://shopify.dev/docs/api/admin-graphql/latest/queries/files) and its [query](https://shopify.dev/docs/api/admin-graphql/latest/queries/files#argument-query) argument for more information.")]
    public ImageConnection? productImages { get; set; } = null;

    /// <summary>
    /// List of the shop's products.
    /// </summary>
    [JsonPropertyName("products")]
    [Obsolete("Use `QueryRoot.products`.")]
    public ProductConnection? products { get; set; } = null;

    /// <summary>
    /// A list of tags that have been added to products.
    /// </summary>
    [JsonPropertyName("productTags")]
    [Obsolete("Use `QueryRoot.productTags` instead.")]
    public StringConnection? productTags { get; set; } = null;

    /// <summary>
    /// The list of types added to products.
    /// </summary>
    [JsonPropertyName("productTypes")]
    [Obsolete("Use `QueryRoot.productTypes` instead.")]
    public StringConnection? productTypes { get; set; } = null;

    /// <summary>
    /// List of the shop's product variants.
    /// </summary>
    [JsonPropertyName("productVariants")]
    [Obsolete("Use `QueryRoot.productVariants` instead.")]
    public ProductVariantConnection? productVariants { get; set; } = null;

    /// <summary>
    /// The list of vendors added to products.
    /// </summary>
    [JsonPropertyName("productVendors")]
    [Obsolete("Use `QueryRoot.productVendors` instead.")]
    public StringConnection? productVendors { get; set; } = null;

    /// <summary>
    /// The number of publications for the shop.
    /// </summary>
    [JsonPropertyName("publicationCount")]
    [Obsolete("Use `QueryRoot.publicationsCount` instead.")]
    public int? publicationCount { get; set; } = null;

    /// <summary>
    /// The shop's limits for specific resources. For example, the maximum number
    /// ofvariants allowed per product, or the maximum number of locations allowed.
    /// </summary>
    [JsonPropertyName("resourceLimits")]
    public ShopResourceLimits? resourceLimits { get; set; } = null;

    /// <summary>
    /// The URL of the rich text editor that can be used for mobile devices.
    /// </summary>
    [JsonPropertyName("richTextEditorUrl")]
    public string? richTextEditorUrl { get; set; } = null;

    /// <summary>
    /// Fetches a list of admin search results by a specified query.
    /// </summary>
    [JsonPropertyName("search")]
    public SearchResultConnection? search { get; set; } = null;

    /// <summary>
    /// The list of search filter options for the shop. These can be used to filter productvisibility for the shop.
    /// </summary>
    [JsonPropertyName("searchFilters")]
    public SearchFilterOptions? searchFilters { get; set; } = null;

    /// <summary>
    /// Whether the shop has outstanding setup steps.
    /// </summary>
    [JsonPropertyName("setupRequired")]
    public bool? setupRequired { get; set; } = null;

    /// <summary>
    /// The list of countries that the shop ships to.
    /// </summary>
    [JsonPropertyName("shipsToCountries")]
    public ICollection<CountryCode>? shipsToCountries { get; set; } = null;

    /// <summary>
    /// The name of the shop owner.
    /// </summary>
    [JsonPropertyName("shopOwnerName")]
    public string? shopOwnerName { get; set; } = null;

    /// <summary>
    /// The list of all legal policies associated with a shop.
    /// </summary>
    [JsonPropertyName("shopPolicies")]
    public ICollection<ShopPolicy>? shopPolicies { get; set; } = null;

    /// <summary>
    /// The paginated list of the shop's staff members.
    /// </summary>
    [JsonPropertyName("staffMembers")]
    [Obsolete("Use `QueryRoot.staffMembers` instead.")]
    public StaffMemberConnection? staffMembers { get; set; } = null;

    /// <summary>
    /// The storefront access token of a private application. These are scoped per-application.
    /// </summary>
    [JsonPropertyName("storefrontAccessTokens")]
    public StorefrontAccessTokenConnection? storefrontAccessTokens { get; set; } = null;

    /// <summary>
    /// The URL of the shop's storefront.
    /// </summary>
    [JsonPropertyName("storefrontUrl")]
    [Obsolete("Use `url` instead.")]
    public string? storefrontUrl { get; set; } = null;

    /// <summary>
    /// Whether applicable taxes are included in the shop's product prices.
    /// </summary>
    [JsonPropertyName("taxesIncluded")]
    public bool? taxesIncluded { get; set; } = null;

    /// <summary>
    /// Whether the shop charges taxes for shipping.
    /// </summary>
    [JsonPropertyName("taxShipping")]
    public bool? taxShipping { get; set; } = null;

    /// <summary>
    /// The shop's time zone abbreviation.
    /// </summary>
    [JsonPropertyName("timezoneAbbreviation")]
    public string? timezoneAbbreviation { get; set; } = null;

    /// <summary>
    /// The shop's time zone offset.
    /// </summary>
    [JsonPropertyName("timezoneOffset")]
    public string? timezoneOffset { get; set; } = null;

    /// <summary>
    /// The shop's time zone offset expressed as a number of minutes.
    /// </summary>
    [JsonPropertyName("timezoneOffsetMinutes")]
    public int? timezoneOffsetMinutes { get; set; } = null;

    /// <summary>
    /// Whether transactional SMS sent by Shopify have been disabled for a shop.
    /// </summary>
    [JsonPropertyName("transactionalSmsDisabled")]
    public bool? transactionalSmsDisabled { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The shop's unit system for weights and measures.
    /// </summary>
    [JsonPropertyName("unitSystem")]
    public UnitSystem? unitSystem { get; set; } = null;

    /// <summary>
    /// The date and time when the shop was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; } = null;

    /// <summary>
    /// The URL of the shop's online store.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;

    /// <summary>
    /// The shop's primary unit of weight for products and shipping.
    /// </summary>
    [JsonPropertyName("weightUnit")]
    public WeightUnit? weightUnit { get; set; } = null;
}