#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The schema's entry-point for queries. This acts as the public, top-level API from which all queries must start.
/// </summary>
public record QueryRoot : IGraphQLObject
{
    /// <summary>
    /// List of abandoned checkouts. Includes checkouts that were recovered after being abandoned.
    /// </summary>
    [JsonPropertyName("abandonedCheckouts")]
    public AbandonedCheckoutConnection? abandonedCheckouts { get; set; } = null;

    /// <summary>
    /// Returns the count of abandoned checkouts for the given shop. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("abandonedCheckoutsCount")]
    public Count? abandonedCheckoutsCount { get; set; } = null;

    /// <summary>
    /// Returns an abandonment by ID.
    /// </summary>
    [JsonPropertyName("abandonment")]
    public Abandonment? abandonment { get; set; } = null;

    /// <summary>
    /// Returns an Abandonment by the Abandoned Checkout ID.
    /// </summary>
    [JsonPropertyName("abandonmentByAbandonedCheckoutId")]
    public Abandonment? abandonmentByAbandonedCheckoutId { get; set; } = null;

    /// <summary>
    /// Lookup an App by ID or return the currently authenticated App.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// Fetches app by handle.
    /// Returns null if the app doesn't exist.
    /// </summary>
    [JsonPropertyName("appByHandle")]
    public App? appByHandle { get; set; } = null;

    /// <summary>
    /// Fetches an app by its client ID.
    /// Returns null if the app doesn't exist.
    /// </summary>
    [JsonPropertyName("appByKey")]
    public App? appByKey { get; set; } = null;

    /// <summary>
    /// An app discount type.
    /// </summary>
    [JsonPropertyName("appDiscountType")]
    public AppDiscountType? appDiscountType { get; set; } = null;

    /// <summary>
    /// A list of app discount types installed by apps.
    /// </summary>
    [JsonPropertyName("appDiscountTypes")]
    public ICollection<AppDiscountType>? appDiscountTypes { get; set; } = null;

    /// <summary>
    /// A list of app discount types installed by apps.
    /// </summary>
    [JsonPropertyName("appDiscountTypesNodes")]
    public AppDiscountTypeConnection? appDiscountTypesNodes { get; set; } = null;

    /// <summary>
    /// Lookup an AppInstallation by ID or return the AppInstallation for the currently authenticated App.
    /// </summary>
    [JsonPropertyName("appInstallation")]
    public AppInstallation? appInstallation { get; set; } = null;

    /// <summary>
    /// A list of app installations. To use this query, you need to contact [Shopify
    /// Support](https://partners.shopify.com/current/support/) to grant your custom
    /// app the `read_apps` access scope. Public apps can't be granted this access scope.
    /// </summary>
    [JsonPropertyName("appInstallations")]
    public AppInstallationConnection? appInstallations { get; set; } = null;

    /// <summary>
    /// Returns an Article resource by ID.
    /// </summary>
    [JsonPropertyName("article")]
    public Article? article { get; set; } = null;

    /// <summary>
    /// List of article authors for the shop.
    /// </summary>
    [JsonPropertyName("articleAuthors")]
    public ArticleAuthorConnection? articleAuthors { get; set; } = null;

    /// <summary>
    /// List of the shop's articles.
    /// </summary>
    [JsonPropertyName("articles")]
    public ArticleConnection? articles { get; set; } = null;

    /// <summary>
    /// List of all article tags.
    /// </summary>
    [JsonPropertyName("articleTags")]
    public ICollection<string>? articleTags { get; set; } = null;

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
    /// The app must have the `read_assigned_fulfillment_orders`
    /// [access scope](https://shopify.dev/docs/api/usage/access-scopes)
    /// to be able to retrieve the fulfillment orders assigned to its locations.
    /// All assigned fulfillment orders (except those with the `CLOSED` status) will be returned by default.
    /// Perform filtering with the `assignmentStatus` argument
    /// to receive only fulfillment orders that have been requested to be fulfilled.
    /// </summary>
    [JsonPropertyName("assignedFulfillmentOrders")]
    public FulfillmentOrderConnection? assignedFulfillmentOrders { get; set; } = null;

    /// <summary>
    /// Returns an automatic discount resource by ID.
    /// </summary>
    [JsonPropertyName("automaticDiscount")]
    [Obsolete("Use `automaticDiscountNode` instead.")]
    public DiscountAutomatic? automaticDiscount { get; set; } = null;

    /// <summary>
    /// Returns a `DiscountAutomaticNode` resource by ID.
    /// </summary>
    [JsonPropertyName("automaticDiscountNode")]
    public DiscountAutomaticNode? automaticDiscountNode { get; set; } = null;

    /// <summary>
    /// Returns a list of [automatic discounts](https://help.shopify.com/manual/discounts/discount-types#automatic-discounts).
    /// </summary>
    [JsonPropertyName("automaticDiscountNodes")]
    public DiscountAutomaticNodeConnection? automaticDiscountNodes { get; set; } = null;

    /// <summary>
    /// List of automatic discounts.
    /// </summary>
    [JsonPropertyName("automaticDiscounts")]
    [Obsolete("Use `automaticDiscountNodes` instead.")]
    public DiscountAutomaticConnection? automaticDiscounts { get; set; } = null;

    /// <summary>
    /// List of the shop's automatic discount saved searches.
    /// </summary>
    [JsonPropertyName("automaticDiscountSavedSearches")]
    public SavedSearchConnection? automaticDiscountSavedSearches { get; set; } = null;

    /// <summary>
    /// The regions that can be used as the backup region of the shop.
    /// </summary>
    [JsonPropertyName("availableBackupRegions")]
    public ICollection<IMarketRegion>? availableBackupRegions { get; set; } = null;

    /// <summary>
    /// Returns a list of activated carrier services and associated shop locations that support them.
    /// </summary>
    [JsonPropertyName("availableCarrierServices")]
    public ICollection<DeliveryCarrierServiceAndLocations>? availableCarrierServices { get; set; } = null;

    /// <summary>
    /// A list of available locales.
    /// </summary>
    [JsonPropertyName("availableLocales")]
    public ICollection<Locale>? availableLocales { get; set; } = null;

    /// <summary>
    /// The backup region of the shop.
    /// </summary>
    [JsonPropertyName("backupRegion")]
    public IMarketRegion? backupRegion { get; set; } = null;

    /// <summary>
    /// Returns a Blog resource by ID.
    /// </summary>
    [JsonPropertyName("blog")]
    public Blog? blog { get; set; } = null;

    /// <summary>
    /// List of the shop's blogs.
    /// </summary>
    [JsonPropertyName("blogs")]
    public BlogConnection? blogs { get; set; } = null;

    /// <summary>
    /// Count of blogs. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("blogsCount")]
    public Count? blogsCount { get; set; } = null;

    /// <summary>
    /// Returns a list of Business Entities associated with the shop.
    /// </summary>
    [JsonPropertyName("businessEntities")]
    public ICollection<BusinessEntity>? businessEntities { get; set; } = null;

    /// <summary>
    /// Returns a Business Entity by ID.
    /// </summary>
    [JsonPropertyName("businessEntity")]
    public BusinessEntity? businessEntity { get; set; } = null;

    /// <summary>
    /// Returns a `DeliveryCarrierService` resource by ID.
    /// </summary>
    [JsonPropertyName("carrierService")]
    public DeliveryCarrierService? carrierService { get; set; } = null;

    /// <summary>
    /// Retrieve a list of CarrierServices.
    /// </summary>
    [JsonPropertyName("carrierServices")]
    public DeliveryCarrierServiceConnection? carrierServices { get; set; } = null;

    /// <summary>
    /// List of Cart transform objects owned by the current API client.
    /// </summary>
    [JsonPropertyName("cartTransforms")]
    public CartTransformConnection? cartTransforms { get; set; } = null;

    /// <summary>
    /// Returns a `CashTrackingSession` resource by ID.
    /// </summary>
    [JsonPropertyName("cashTrackingSession")]
    public CashTrackingSession? cashTrackingSession { get; set; } = null;

    /// <summary>
    /// Returns a shop's cash tracking sessions for locations with a POS Pro subscription.
    /// Tip: To query for cash tracking sessions in bulk, you can
    /// [perform a bulk operation](https://shopify.dev/docs/api/usage/bulk-operations/queries).
    /// </summary>
    [JsonPropertyName("cashTrackingSessions")]
    public CashTrackingSessionConnection? cashTrackingSessions { get; set; } = null;

    /// <summary>
    /// Retrieves a [catalog](https://shopify.dev/docs/api/admin-graphql/latest/interfaces/Catalog) by its ID.
    /// A catalog represents a list of products with publishing and pricing information,
    /// and can be associated with a context, such as a market, company location, or app.
    /// Use the `catalog` query to retrieve information associated with the following workflows:
    /// - Managing product publications across different contexts
    /// - Setting up contextual pricing with price lists
    /// - Managing market-specific product availability
    /// - Configuring B2B customer catalogs
    /// There are several types of catalogs:
    /// - [`MarketCatalog`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MarketCatalog)
    /// - [`AppCatalog`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AppCatalog)
    /// - [`CompanyLocationCatalog`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CompanyLocationCatalog)
    /// Learn more about [catalogs for different markets](https://shopify.dev/docs/apps/build/markets/catalogs-different-markets).
    /// </summary>
    [JsonPropertyName("catalog")]
    public ICatalog? catalog { get; set; } = null;

    /// <summary>
    /// Returns the most recent catalog operations for the shop.
    /// </summary>
    [JsonPropertyName("catalogOperations")]
    public ICollection<IResourceOperation>? catalogOperations { get; set; } = null;

    /// <summary>
    /// The catalogs belonging to the shop.
    /// </summary>
    [JsonPropertyName("catalogs")]
    public CatalogConnection? catalogs { get; set; } = null;

    /// <summary>
    /// The count of catalogs belonging to the shop. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("catalogsCount")]
    public Count? catalogsCount { get; set; } = null;

    /// <summary>
    /// Lookup a channel by ID.
    /// </summary>
    [JsonPropertyName("channel")]
    [Obsolete("Use `publication` instead.")]
    public Channel? channel { get; set; } = null;

    /// <summary>
    /// List of the active sales channels.
    /// </summary>
    [JsonPropertyName("channels")]
    [Obsolete("Use `publications` instead.")]
    public ChannelConnection? channels { get; set; } = null;

    /// <summary>
    /// Returns the visual customizations for checkout for a given checkout profile.
    /// To learn more about updating checkout branding settings, refer to the
    /// [checkoutBrandingUpsert](https://shopify.dev/api/admin-graphql/unstable/mutations/checkoutBrandingUpsert)
    /// mutation and the checkout branding [tutorial](https://shopify.dev/docs/apps/checkout/styling).
    /// </summary>
    [JsonPropertyName("checkoutBranding")]
    public CheckoutBranding? checkoutBranding { get; set; } = null;

    /// <summary>
    /// A checkout profile on a shop.
    /// </summary>
    [JsonPropertyName("checkoutProfile")]
    public CheckoutProfile? checkoutProfile { get; set; } = null;

    /// <summary>
    /// List of checkout profiles on a shop.
    /// </summary>
    [JsonPropertyName("checkoutProfiles")]
    public CheckoutProfileConnection? checkoutProfiles { get; set; } = null;

    /// <summary>
    /// Returns a [code discount](https://help.shopify.com/manual/discounts/discount-types#discount-codes) resource by ID.
    /// </summary>
    [JsonPropertyName("codeDiscountNode")]
    public DiscountCodeNode? codeDiscountNode { get; set; } = null;

    /// <summary>
    /// Returns a code discount identified by its discount code.
    /// </summary>
    [JsonPropertyName("codeDiscountNodeByCode")]
    public DiscountCodeNode? codeDiscountNodeByCode { get; set; } = null;

    /// <summary>
    /// Returns a list of [code-based discounts](https://help.shopify.com/manual/discounts/discount-types#discount-codes).
    /// </summary>
    [JsonPropertyName("codeDiscountNodes")]
    public DiscountCodeNodeConnection? codeDiscountNodes { get; set; } = null;

    /// <summary>
    /// List of the shop's code discount saved searches.
    /// </summary>
    [JsonPropertyName("codeDiscountSavedSearches")]
    public SavedSearchConnection? codeDiscountSavedSearches { get; set; } = null;

    /// <summary>
    /// Retrieves a [collection](https://shopify.dev/docs/api/admin-graphql/latest/objects/Collection) by its ID.
    /// A collection represents a grouping of [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
    /// that merchants can display and sell as a group in their [online
    /// store](https://shopify.dev/docs/apps/build/online-store) and
    /// other [sales channels](https://shopify.dev/docs/apps/build/sales-channels).
    /// Use the `collection` query when you need to:
    /// - Manage collection publishing across sales channels
    /// - Access collection metadata and SEO information
    /// - Work with collection rules and product relationships
    /// A collection can be either a custom ([manual](https://help.shopify.com/manual/products/collections/manual-shopify-collection))
    /// collection where products are manually added, or a smart ([automated](https://help.shopify.com/manual/products/collections/automated-collections))
    /// collection where products are automatically included based on defined rules.
    /// Each collection has associated metadata including
    /// title, description, handle, image, and [metafields](https://shopify.dev/docs/apps/build/custom-data/metafields).
    /// </summary>
    [JsonPropertyName("collection")]
    public Collection? collection { get; set; } = null;

    /// <summary>
    /// Return a collection by its handle.
    /// </summary>
    [JsonPropertyName("collectionByHandle")]
    [Obsolete("Use `collectionByIdentifier` instead.")]
    public Collection? collectionByHandle { get; set; } = null;

    /// <summary>
    /// Return a collection by an identifier.
    /// </summary>
    [JsonPropertyName("collectionByIdentifier")]
    public Collection? collectionByIdentifier { get; set; } = null;

    /// <summary>
    /// Lists all rules that can be used to create smart collections.
    /// </summary>
    [JsonPropertyName("collectionRulesConditions")]
    public ICollection<CollectionRuleConditions>? collectionRulesConditions { get; set; } = null;

    /// <summary>
    /// Retrieves a list of [collections](https://shopify.dev/docs/api/admin-graphql/latest/objects/Collection)
    /// in a store. Collections are groups of [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
    /// that merchants can organize for display in their [online store](https://shopify.dev/docs/apps/build/online-store) and
    /// other [sales channels](https://shopify.dev/docs/apps/build/sales-channels).
    /// For example, an athletics store might create different collections for running attire, shoes, and accessories.
    /// Use the `collections` query when you need to:
    /// - Build a browsing interface for a store's product groupings.
    /// - Create collection searching, sorting, and filtering experiences (for example, by title, type, or published status).
    /// - Sync collection data with external systems.
    /// - Manage both custom ([manual](https://help.shopify.com/manual/products/collections/manual-shopify-collection))
    /// and smart ([automated](https://help.shopify.com/manual/products/collections/automated-collections)) collections.
    /// The `collections` query supports [pagination](https://shopify.dev/docs/api/usage/pagination-graphql)
    /// for large catalogs and [saved searches](https://shopify.dev/docs/api/admin-graphql/latest/queries/collections#arguments-savedSearchId)
    /// for frequently used collection queries.
    /// The `collections` query returns collections with their associated metadata, including:
    /// - Basic collection information (title, description, handle, and type)
    /// - Collection image and SEO metadata
    /// - Product count and product relationships
    /// - Collection rules (for smart collections)
    /// - Publishing status and publication details
    /// - Metafields and custom attributes
    /// Learn more about [using metafields with smart collections](https://shopify.dev/docs/apps/build/custom-data/metafields/use-metafield-capabilities).
    /// </summary>
    [JsonPropertyName("collections")]
    public CollectionConnection? collections { get; set; } = null;

    /// <summary>
    /// Returns a list of the shop's collection saved searches.
    /// </summary>
    [JsonPropertyName("collectionSavedSearches")]
    public SavedSearchConnection? collectionSavedSearches { get; set; } = null;

    /// <summary>
    /// Count of collections. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("collectionsCount")]
    public Count? collectionsCount { get; set; } = null;

    /// <summary>
    /// Returns a Comment resource by ID.
    /// </summary>
    [JsonPropertyName("comment")]
    public Comment? comment { get; set; } = null;

    /// <summary>
    /// List of the shop's comments.
    /// </summary>
    [JsonPropertyName("comments")]
    public CommentConnection? comments { get; set; } = null;

    /// <summary>
    /// Returns the list of companies in the shop.
    /// </summary>
    [JsonPropertyName("companies")]
    public CompanyConnection? companies { get; set; } = null;

    /// <summary>
    /// The number of companies for a shop. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("companiesCount")]
    public Count? companiesCount { get; set; } = null;

    /// <summary>
    /// Returns a `Company` resource by ID.
    /// </summary>
    [JsonPropertyName("company")]
    public Company? company { get; set; } = null;

    /// <summary>
    /// Returns a `CompanyContact` resource by ID.
    /// </summary>
    [JsonPropertyName("companyContact")]
    public CompanyContact? companyContact { get; set; } = null;

    /// <summary>
    /// Returns a `CompanyContactRole` resource by ID.
    /// </summary>
    [JsonPropertyName("companyContactRole")]
    public CompanyContactRole? companyContactRole { get; set; } = null;

    /// <summary>
    /// Returns a `CompanyLocation` resource by ID.
    /// </summary>
    [JsonPropertyName("companyLocation")]
    public CompanyLocation? companyLocation { get; set; } = null;

    /// <summary>
    /// Returns the list of company locations in the shop.
    /// </summary>
    [JsonPropertyName("companyLocations")]
    public CompanyLocationConnection? companyLocations { get; set; } = null;

    /// <summary>
    /// Returns the customer privacy consent policies of a shop.
    /// </summary>
    [JsonPropertyName("consentPolicy")]
    public ICollection<ConsentPolicy>? consentPolicy { get; set; } = null;

    /// <summary>
    /// List of countries and regions for which consent policies can be created or updated.
    /// </summary>
    [JsonPropertyName("consentPolicyRegions")]
    public ICollection<ConsentPolicyRegion>? consentPolicyRegions { get; set; } = null;

    /// <summary>
    /// Return the AppInstallation for the currently authenticated App.
    /// </summary>
    [JsonPropertyName("currentAppInstallation")]
    public AppInstallation? currentAppInstallation { get; set; } = null;

    /// <summary>
    /// Returns the current app's most recent BulkOperation. Apps can run one bulk
    /// query and one bulk mutation operation at a time, by shop.
    /// </summary>
    [JsonPropertyName("currentBulkOperation")]
    public BulkOperation? currentBulkOperation { get; set; } = null;

    /// <summary>
    /// The staff member making the API request.
    /// </summary>
    [JsonPropertyName("currentStaffMember")]
    public StaffMember? currentStaffMember { get; set; } = null;

    /// <summary>
    /// Returns a `Customer` resource by ID.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// Returns a customer account page.
    /// </summary>
    [JsonPropertyName("customerAccountPage")]
    public ICustomerAccountPage? customerAccountPage { get; set; } = null;

    /// <summary>
    /// List of the shop's customer account pages.
    /// </summary>
    [JsonPropertyName("customerAccountPages")]
    public CustomerAccountPageConnection? customerAccountPages { get; set; } = null;

    /// <summary>
    /// Return a customer by an identifier.
    /// </summary>
    [JsonPropertyName("customerByIdentifier")]
    public Customer? customerByIdentifier { get; set; } = null;

    /// <summary>
    /// Returns the status of a customer merge request job.
    /// </summary>
    [JsonPropertyName("customerMergeJobStatus")]
    public CustomerMergeRequest? customerMergeJobStatus { get; set; } = null;

    /// <summary>
    /// Returns a preview of a customer merge request.
    /// </summary>
    [JsonPropertyName("customerMergePreview")]
    public CustomerMergePreview? customerMergePreview { get; set; } = null;

    /// <summary>
    /// Returns a CustomerPaymentMethod resource by its ID.
    /// </summary>
    [JsonPropertyName("customerPaymentMethod")]
    public CustomerPaymentMethod? customerPaymentMethod { get; set; } = null;

    /// <summary>
    /// Returns a list of
    /// [customers](https://shopify.dev/api/admin-graphql/latest/objects/Customer) in
    /// your Shopify store, including key information such as name, email, location,
    /// and purchase history.
    /// Use this query to segment your audience, personalize marketing campaigns, or
    /// analyze customer behavior by applying filters based on location, order
    /// history, marketing preferences and tags.
    /// The `customers` query supports
    /// [pagination](https://shopify.dev/api/usage/pagination-graphql) and [sorting](https://shopify.dev/api/admin-graphql/latest/enums/CustomerSortKeys).
    /// </summary>
    [JsonPropertyName("customers")]
    public CustomerConnection? customers { get; set; } = null;

    /// <summary>
    /// List of the shop's customer saved searches.
    /// </summary>
    [JsonPropertyName("customerSavedSearches")]
    public SavedSearchConnection? customerSavedSearches { get; set; } = null;

    /// <summary>
    /// The number of customers. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("customersCount")]
    public Count? customersCount { get; set; } = null;

    /// <summary>
    /// The list of members, such as customers, that's associated with an individual segment.
    /// The maximum page size is 1000.
    /// </summary>
    [JsonPropertyName("customerSegmentMembers")]
    public CustomerSegmentMemberConnection? customerSegmentMembers { get; set; } = null;

    /// <summary>
    /// Whether a member, which is a customer, belongs to a segment.
    /// </summary>
    [JsonPropertyName("customerSegmentMembership")]
    public SegmentMembershipResponse? customerSegmentMembership { get; set; } = null;

    /// <summary>
    /// Returns a segment members query resource by ID.
    /// </summary>
    [JsonPropertyName("customerSegmentMembersQuery")]
    public CustomerSegmentMembersQuery? customerSegmentMembersQuery { get; set; } = null;

    /// <summary>
    /// The paginated list of deletion events.
    /// </summary>
    [JsonPropertyName("deletionEvents")]
    [Obsolete("Use `events` instead.")]
    public DeletionEventConnection? deletionEvents { get; set; } = null;

    /// <summary>
    /// The delivery customization.
    /// </summary>
    [JsonPropertyName("deliveryCustomization")]
    public DeliveryCustomization? deliveryCustomization { get; set; } = null;

    /// <summary>
    /// The delivery customizations.
    /// </summary>
    [JsonPropertyName("deliveryCustomizations")]
    public DeliveryCustomizationConnection? deliveryCustomizations { get; set; } = null;

    /// <summary>
    /// Returns a Delivery Profile resource by ID.
    /// </summary>
    [JsonPropertyName("deliveryProfile")]
    public DeliveryProfile? deliveryProfile { get; set; } = null;

    /// <summary>
    /// Returns a list of saved delivery profiles.
    /// </summary>
    [JsonPropertyName("deliveryProfiles")]
    public DeliveryProfileConnection? deliveryProfiles { get; set; } = null;

    /// <summary>
    /// Returns delivery promise participants.
    /// </summary>
    [JsonPropertyName("deliveryPromiseParticipants")]
    public DeliveryPromiseParticipantConnection? deliveryPromiseParticipants { get; set; } = null;

    /// <summary>
    /// Lookup a delivery promise provider.
    /// </summary>
    [JsonPropertyName("deliveryPromiseProvider")]
    public DeliveryPromiseProvider? deliveryPromiseProvider { get; set; } = null;

    /// <summary>
    /// Represents the delivery promise settings for a shop.
    /// </summary>
    [JsonPropertyName("deliveryPromiseSettings")]
    public DeliveryPromiseSetting? deliveryPromiseSettings { get; set; } = null;

    /// <summary>
    /// Returns the shop-wide shipping settings.
    /// </summary>
    [JsonPropertyName("deliverySettings")]
    public DeliverySetting? deliverySettings { get; set; } = null;

    /// <summary>
    /// The total number of discount codes for the shop. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("discountCodesCount")]
    public Count? discountCodesCount { get; set; } = null;

    /// <summary>
    /// Returns a discount resource by ID.
    /// </summary>
    [JsonPropertyName("discountNode")]
    public DiscountNode? discountNode { get; set; } = null;

    /// <summary>
    /// Returns a list of discounts.
    /// </summary>
    [JsonPropertyName("discountNodes")]
    public DiscountNodeConnection? discountNodes { get; set; } = null;

    /// <summary>
    /// The total number of discounts for the shop. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("discountNodesCount")]
    public Count? discountNodesCount { get; set; } = null;

    /// <summary>
    /// Returns a `DiscountRedeemCodeBulkCreation` resource by ID.
    /// </summary>
    [JsonPropertyName("discountRedeemCodeBulkCreation")]
    public DiscountRedeemCodeBulkCreation? discountRedeemCodeBulkCreation { get; set; } = null;

    /// <summary>
    /// List of the shop's redeemed discount code saved searches.
    /// </summary>
    [JsonPropertyName("discountRedeemCodeSavedSearches")]
    public SavedSearchConnection? discountRedeemCodeSavedSearches { get; set; } = null;

    /// <summary>
    /// Returns a `ShopifyPaymentsDispute` resource by ID.
    /// </summary>
    [JsonPropertyName("dispute")]
    public ShopifyPaymentsDispute? dispute { get; set; } = null;

    /// <summary>
    /// Returns a `ShopifyPaymentsDisputeEvidence` resource by ID.
    /// </summary>
    [JsonPropertyName("disputeEvidence")]
    public ShopifyPaymentsDisputeEvidence? disputeEvidence { get; set; } = null;

    /// <summary>
    /// All disputes related to the Shop.
    /// </summary>
    [JsonPropertyName("disputes")]
    public ShopifyPaymentsDisputeConnection? disputes { get; set; } = null;

    /// <summary>
    /// Lookup a Domain by ID.
    /// </summary>
    [JsonPropertyName("domain")]
    public Domain? domain { get; set; } = null;

    /// <summary>
    /// Retrieves a [draft order](https://shopify.dev/docs/api/admin-graphql/latest/objects/DraftOrder) by its ID.
    /// A draft order is an order created by a merchant on behalf of their
    /// customers. Draft orders contain all necessary order details (products, pricing, customer information)
    /// but require payment to be accepted before they can be converted into
    /// [completed orders](https://shopify.dev/docs/api/admin-graphql/latest/mutations/draftOrderComplete).
    /// Use the `draftOrder` query to retrieve information associated with the following workflows:
    /// - Creating orders for phone, in-person, or chat sales
    /// - Sending invoices to customers with secure checkout links
    /// - Managing custom items and additional costs
    /// - Selling products at discount or wholesale rates
    /// - Processing pre-orders and saving drafts for later completion
    /// A draft order is associated with a
    /// [customer](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)
    /// and contains multiple [line items](https://shopify.dev/docs/api/admin-graphql/latest/objects/DraftOrderLineItem).
    /// Each draft order has a [status](https://shopify.dev/docs/api/admin-graphql/latest/objects/DraftOrder#field-DraftOrder.fields.status),
    /// which indicates its progress through the sales workflow.
    /// </summary>
    [JsonPropertyName("draftOrder")]
    public DraftOrder? draftOrder { get; set; } = null;

    /// <summary>
    /// Returns a list of available delivery options for a draft order.
    /// </summary>
    [JsonPropertyName("draftOrderAvailableDeliveryOptions")]
    public DraftOrderAvailableDeliveryOptions? draftOrderAvailableDeliveryOptions { get; set; } = null;

    /// <summary>
    /// List of saved draft orders.
    /// </summary>
    [JsonPropertyName("draftOrders")]
    public DraftOrderConnection? draftOrders { get; set; } = null;

    /// <summary>
    /// List of the shop's draft order saved searches.
    /// </summary>
    [JsonPropertyName("draftOrderSavedSearches")]
    public SavedSearchConnection? draftOrderSavedSearches { get; set; } = null;

    /// <summary>
    /// Returns the number of draft orders that match the query. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("draftOrdersCount")]
    public Count? draftOrdersCount { get; set; } = null;

    /// <summary>
    /// Returns a `DraftOrderTag` resource by ID.
    /// </summary>
    [JsonPropertyName("draftOrderTag")]
    public DraftOrderTag? draftOrderTag { get; set; } = null;

    /// <summary>
    /// Get a single event by its id.
    /// </summary>
    [JsonPropertyName("event")]
    public IEvent? @event { get; set; } = null;

    /// <summary>
    /// The paginated list of events associated with the store.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// Count of events. Limited to a maximum of 10000.
    /// </summary>
    [JsonPropertyName("eventsCount")]
    public Count? eventsCount { get; set; } = null;

    /// <summary>
    /// Retrieves a paginated list of files that have been uploaded to a Shopify store. Files represent digital assets
    /// that merchants can upload to their store for various purposes including product images, marketing materials,
    /// documents, and brand assets.
    /// Use the `files` query to retrieve information associated with the following workflows:
    /// - [Managing product media and images](https://shopify.dev/docs/apps/build/online-store/product-media)
    /// - [Theme development and asset management](https://shopify.dev/docs/storefronts/themes/store/success/brand-assets)
    /// - Brand asset management and [checkout branding](https://shopify.dev/docs/apps/build/checkout/styling/add-favicon)
    /// Files can include multiple [content types](https://shopify.dev/docs/api/admin-graphql/latest/enums/FileContentType),
    /// such as images, videos, 3D models, and generic files. Each file has
    /// properties like dimensions, file size, alt text for accessibility, and upload status. Files can be filtered
    /// by [media type](https://shopify.dev/docs/api/admin-graphql/latest/enums/MediaContentType) and can be associated with
    /// [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product),
    /// [themes](https://shopify.dev/docs/api/admin-graphql/latest/objects/OnlineStoreTheme),
    /// and other store resources.
    /// </summary>
    [JsonPropertyName("files")]
    public FileConnection? files { get; set; } = null;

    /// <summary>
    /// A list of the shop's file saved searches.
    /// </summary>
    [JsonPropertyName("fileSavedSearches")]
    public SavedSearchConnection? fileSavedSearches { get; set; } = null;

    /// <summary>
    /// Returns the access policy for a finance app .
    /// </summary>
    [JsonPropertyName("financeAppAccessPolicy")]
    public FinanceAppAccessPolicy? financeAppAccessPolicy { get; set; } = null;

    /// <summary>
    /// Returns the KYC information for the shop's Shopify Payments account, used in embedded finance apps.
    /// </summary>
    [JsonPropertyName("financeKycInformation")]
    public FinanceKycInformation? financeKycInformation { get; set; } = null;

    /// <summary>
    /// Returns a Fulfillment resource by ID.
    /// </summary>
    [JsonPropertyName("fulfillment")]
    public Fulfillment? fulfillment { get; set; } = null;

    /// <summary>
    /// The fulfillment constraint rules that belong to a shop.
    /// </summary>
    [JsonPropertyName("fulfillmentConstraintRules")]
    public ICollection<FulfillmentConstraintRule>? fulfillmentConstraintRules { get; set; } = null;

    /// <summary>
    /// Returns a `FulfillmentOrder` resource by ID.
    /// </summary>
    [JsonPropertyName("fulfillmentOrder")]
    public FulfillmentOrder? fulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The paginated list of all fulfillment orders.
    /// The returned fulfillment orders are filtered according to the
    /// [fulfillment order access scopes](https://shopify.dev/api/admin-graphql/latest/objects/fulfillmentorder#api-access-scopes)
    /// granted to the app.
    /// Use this query to retrieve fulfillment orders assigned to merchant-managed locations,
    /// third-party fulfillment service locations, or all kinds of locations together.
    /// For fetching only the fulfillment orders assigned to the app's locations, use the
    /// [assignedFulfillmentOrders](https://shopify.dev/api/admin-graphql/2024-07/objects/queryroot#connection-assignedfulfillmentorders)
    /// connection.
    /// </summary>
    [JsonPropertyName("fulfillmentOrders")]
    public FulfillmentOrderConnection? fulfillmentOrders { get; set; } = null;

    /// <summary>
    /// Returns a FulfillmentService resource by ID.
    /// </summary>
    [JsonPropertyName("fulfillmentService")]
    public FulfillmentService? fulfillmentService { get; set; } = null;

    /// <summary>
    /// Returns a gift card resource by ID.
    /// </summary>
    [JsonPropertyName("giftCard")]
    public GiftCard? giftCard { get; set; } = null;

    /// <summary>
    /// The configuration for the shop's gift cards.
    /// </summary>
    [JsonPropertyName("giftCardConfiguration")]
    public GiftCardConfiguration? giftCardConfiguration { get; set; } = null;

    /// <summary>
    /// Returns a list of gift cards.
    /// </summary>
    [JsonPropertyName("giftCards")]
    public GiftCardConnection? giftCards { get; set; } = null;

    /// <summary>
    /// The total number of gift cards issued for the shop. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("giftCardsCount")]
    public Count? giftCardsCount { get; set; } = null;

    /// <summary>
    /// Returns an
    /// [InventoryItem](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryItem)
    /// object by ID.
    /// </summary>
    [JsonPropertyName("inventoryItem")]
    public InventoryItem? inventoryItem { get; set; } = null;

    /// <summary>
    /// Returns a list of inventory items.
    /// </summary>
    [JsonPropertyName("inventoryItems")]
    public InventoryItemConnection? inventoryItems { get; set; } = null;

    /// <summary>
    /// Returns an
    /// [InventoryLevel](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryLevel)
    /// object by ID.
    /// </summary>
    [JsonPropertyName("inventoryLevel")]
    public InventoryLevel? inventoryLevel { get; set; } = null;

    /// <summary>
    /// General inventory properties for the shop.
    /// </summary>
    [JsonPropertyName("inventoryProperties")]
    public InventoryProperties? inventoryProperties { get; set; } = null;

    /// <summary>
    /// Returns an inventory shipment by ID.
    /// </summary>
    [JsonPropertyName("inventoryShipment")]
    public InventoryShipment? inventoryShipment { get; set; } = null;

    /// <summary>
    /// Returns an inventory transfer by ID.
    /// </summary>
    [JsonPropertyName("inventoryTransfer")]
    public InventoryTransfer? inventoryTransfer { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of transfers.
    /// </summary>
    [JsonPropertyName("inventoryTransfers")]
    public InventoryTransferConnection? inventoryTransfers { get; set; } = null;

    /// <summary>
    /// Returns a Job resource by ID. Used to check the status of internal jobs and any applicable changes.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// Returns an inventory Location resource by ID.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// Return a location by an identifier.
    /// </summary>
    [JsonPropertyName("locationByIdentifier")]
    public Location? locationByIdentifier { get; set; } = null;

    /// <summary>
    /// Returns a list of active inventory locations.
    /// </summary>
    [JsonPropertyName("locations")]
    public LocationConnection? locations { get; set; } = null;

    /// <summary>
    /// Returns a list of all origin locations available for a delivery profile.
    /// </summary>
    [JsonPropertyName("locationsAvailableForDeliveryProfiles")]
    [Obsolete("Use `locationsAvailableForDeliveryProfilesConnection` instead.")]
    public ICollection<Location>? locationsAvailableForDeliveryProfiles { get; set; } = null;

    /// <summary>
    /// Returns a list of all origin locations available for a delivery profile.
    /// </summary>
    [JsonPropertyName("locationsAvailableForDeliveryProfilesConnection")]
    public LocationConnection? locationsAvailableForDeliveryProfilesConnection { get; set; } = null;

    /// <summary>
    /// Returns the count of locations for the given shop. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("locationsCount")]
    public Count? locationsCount { get; set; } = null;

    /// <summary>
    /// Returns a list of fulfillment orders that are on hold.
    /// </summary>
    [JsonPropertyName("manualHoldsFulfillmentOrders")]
    public FulfillmentOrderConnection? manualHoldsFulfillmentOrders { get; set; } = null;

    /// <summary>
    /// Returns a market resource by ID.
    /// </summary>
    [JsonPropertyName("market")]
    public Market? market { get; set; } = null;

    /// <summary>
    /// Returns the applicable market for a customer based on where they are in the world.
    /// </summary>
    [JsonPropertyName("marketByGeography")]
    [Obsolete("This `market_by_geography` field will be removed in a future version of the API.")]
    public Market? marketByGeography { get; set; } = null;

    /// <summary>
    /// A list of marketing activities associated with the marketing app.
    /// </summary>
    [JsonPropertyName("marketingActivities")]
    public MarketingActivityConnection? marketingActivities { get; set; } = null;

    /// <summary>
    /// Returns a `MarketingActivity` resource by ID.
    /// </summary>
    [JsonPropertyName("marketingActivity")]
    public MarketingActivity? marketingActivity { get; set; } = null;

    /// <summary>
    /// Returns a `MarketingEvent` resource by ID.
    /// </summary>
    [JsonPropertyName("marketingEvent")]
    public MarketingEvent? marketingEvent { get; set; } = null;

    /// <summary>
    /// A list of marketing events associated with the marketing app.
    /// </summary>
    [JsonPropertyName("marketingEvents")]
    public MarketingEventConnection? marketingEvents { get; set; } = null;

    /// <summary>
    /// A resource that can have localized values for different markets.
    /// </summary>
    [JsonPropertyName("marketLocalizableResource")]
    public MarketLocalizableResource? marketLocalizableResource { get; set; } = null;

    /// <summary>
    /// Resources that can have localized values for different markets.
    /// </summary>
    [JsonPropertyName("marketLocalizableResources")]
    public MarketLocalizableResourceConnection? marketLocalizableResources { get; set; } = null;

    /// <summary>
    /// Resources that can have localized values for different markets.
    /// </summary>
    [JsonPropertyName("marketLocalizableResourcesByIds")]
    public MarketLocalizableResourceConnection? marketLocalizableResourcesByIds { get; set; } = null;

    /// <summary>
    /// The markets configured for the shop.
    /// </summary>
    [JsonPropertyName("markets")]
    public MarketConnection? markets { get; set; } = null;

    /// <summary>
    /// The resolved values for a buyer signal.
    /// </summary>
    [JsonPropertyName("marketsResolvedValues")]
    public MarketsResolvedValues? marketsResolvedValues { get; set; } = null;

    /// <summary>
    /// Returns a Menu resource by ID.
    /// </summary>
    [JsonPropertyName("menu")]
    public Menu? menu { get; set; } = null;

    /// <summary>
    /// The shop's menus.
    /// </summary>
    [JsonPropertyName("menus")]
    public MenuConnection? menus { get; set; } = null;

    /// <summary>
    /// Returns a metafield definition by identifier.
    /// </summary>
    [JsonPropertyName("metafieldDefinition")]
    public MetafieldDefinition? metafieldDefinition { get; set; } = null;

    /// <summary>
    /// Returns a list of metafield definitions.
    /// </summary>
    [JsonPropertyName("metafieldDefinitions")]
    public MetafieldDefinitionConnection? metafieldDefinitions { get; set; } = null;

    /// <summary>
    /// Each metafield definition has a type, which defines the type of information that it can store.
    /// This type is enforced across every instance of the resource that owns the metafield definition.
    /// Refer to the [list of supported metafield types](https://shopify.dev/apps/metafields/types).
    /// </summary>
    [JsonPropertyName("metafieldDefinitionTypes")]
    public ICollection<MetafieldDefinitionType>? metafieldDefinitionTypes { get; set; } = null;

    /// <summary>
    /// Retrieves a metaobject by ID.
    /// </summary>
    [JsonPropertyName("metaobject")]
    public Metaobject? metaobject { get; set; } = null;

    /// <summary>
    /// Retrieves a metaobject by handle.
    /// </summary>
    [JsonPropertyName("metaobjectByHandle")]
    public Metaobject? metaobjectByHandle { get; set; } = null;

    /// <summary>
    /// Retrieves a metaobject definition by ID.
    /// </summary>
    [JsonPropertyName("metaobjectDefinition")]
    public MetaobjectDefinition? metaobjectDefinition { get; set; } = null;

    /// <summary>
    /// Finds a metaobject definition by type.
    /// </summary>
    [JsonPropertyName("metaobjectDefinitionByType")]
    public MetaobjectDefinition? metaobjectDefinitionByType { get; set; } = null;

    /// <summary>
    /// All metaobject definitions.
    /// </summary>
    [JsonPropertyName("metaobjectDefinitions")]
    public MetaobjectDefinitionConnection? metaobjectDefinitions { get; set; } = null;

    /// <summary>
    /// All metaobjects for the shop.
    /// </summary>
    [JsonPropertyName("metaobjects")]
    public MetaobjectConnection? metaobjects { get; set; } = null;

    /// <summary>
    /// Return a mobile platform application by its ID.
    /// </summary>
    [JsonPropertyName("mobilePlatformApplication")]
    public MobilePlatformApplication? mobilePlatformApplication { get; set; } = null;

    /// <summary>
    /// List the mobile platform applications.
    /// </summary>
    [JsonPropertyName("mobilePlatformApplications")]
    public MobilePlatformApplicationConnection? mobilePlatformApplications { get; set; } = null;

    /// <summary>
    /// Returns a specific node (any object that implements the
    /// [Node](https://shopify.dev/api/admin-graphql/latest/interfaces/Node)
    /// interface) by ID, in accordance with the
    /// [Relay specification](https://relay.dev/docs/guides/graphql-server-specification/#object-identification).
    /// This field is commonly used for refetching an object.
    /// </summary>
    [JsonPropertyName("node")]
    public INode? node { get; set; } = null;

    /// <summary>
    /// Returns the list of nodes (any objects that implement the
    /// [Node](https://shopify.dev/api/admin-graphql/latest/interfaces/Node)
    /// interface) with the given IDs, in accordance with the
    /// [Relay specification](https://relay.dev/docs/guides/graphql-server-specification/#object-identification).
    /// </summary>
    [JsonPropertyName("nodes")]
    public ICollection<INode>? nodes { get; set; } = null;

    /// <summary>
    /// The shop's online store channel.
    /// </summary>
    [JsonPropertyName("onlineStore")]
    public OnlineStore? onlineStore { get; set; } = null;

    /// <summary>
    /// The `order` query retrieves an
    /// [order](https://shopify.dev/docs/api/admin-graphql/latest/objects/order) by
    /// its ID. This query provides access to comprehensive order information such as
    /// customer details, line items, financial data, and fulfillment status.
    /// Use the `order` query to retrieve information associated with the following processes:
    /// - [Order management and fulfillment](https://shopify.dev/docs/apps/build/orders-fulfillment/order-management-apps)
    /// - [Financial reporting](https://help.shopify.com/manual/finance)
    /// - [Customer purchase history](https://help.shopify.com/manual/reports-and-analytics/shopify-reports/report-types/default-reports/customers-reports)
    /// and [transaction analysis](https://shopify.dev/docs/apps/launch/billing/view-charges-earnings#transaction-data-through-the-graphql-admin-api)
    /// - [Shipping](https://shopify.dev/docs/apps/build/checkout/delivery-shipping) and [inventory management](https://shopify.dev/docs/apps/build/orders-fulfillment/inventory-management-apps)
    /// You can only retrieve the last 60 days worth of orders from a store by
    /// default. If you want to access older orders, then you need to [request access to all
    /// orders](https://shopify.dev/docs/api/usage/access-scopes#orders-permissions).
    /// For large order datasets, consider using [bulk operations](https://shopify.dev/docs/api/usage/bulk-operations/queries).
    /// Bulk operations handle pagination automatically and allow you to retrieve data
    /// asynchronously without being constrained by API rate limits.
    /// Learn more about [creating orders](https://shopify.dev/docs/api/admin-graphql/latest/mutations/ordercreate)
    /// and [building order management
    /// apps](https://shopify.dev/docs/apps/build/orders-fulfillment).
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// Return an order by an identifier.
    /// </summary>
    [JsonPropertyName("orderByIdentifier")]
    public Order? orderByIdentifier { get; set; } = null;

    /// <summary>
    /// Returns a payment status by payment reference ID. Used to check the status of a deferred payment.
    /// </summary>
    [JsonPropertyName("orderPaymentStatus")]
    public OrderPaymentStatus? orderPaymentStatus { get; set; } = null;

    /// <summary>
    /// Returns a list of
    /// [orders](https://shopify.dev/api/admin-graphql/latest/objects/Order) placed in
    /// the store, including data such as order status, customer, and line item details.
    /// Use the `orders` query to build reports, analyze sales performance, or
    /// automate fulfillment workflows. The `orders` query supports
    /// [pagination](https://shopify.dev/docs/api/usage/pagination-graphql),
    /// [sorting](https://shopify.dev/docs/api/admin-graphql/latest/queries/orders#argument-sortkey), and [filtering](https://shopify.dev/docs/api/admin-graphql/latest/queries/orders#argument-query).
    /// </summary>
    [JsonPropertyName("orders")]
    public OrderConnection? orders { get; set; } = null;

    /// <summary>
    /// List of the shop's order saved searches.
    /// </summary>
    [JsonPropertyName("orderSavedSearches")]
    public SavedSearchConnection? orderSavedSearches { get; set; } = null;

    /// <summary>
    /// Returns the count of orders for the given shop. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("ordersCount")]
    public Count? ordersCount { get; set; } = null;

    /// <summary>
    /// Returns a Page resource by ID.
    /// </summary>
    [JsonPropertyName("page")]
    public Page? page { get; set; } = null;

    /// <summary>
    /// List of the shop's pages.
    /// </summary>
    [JsonPropertyName("pages")]
    public PageConnection? pages { get; set; } = null;

    /// <summary>
    /// Count of pages. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("pagesCount")]
    public Count? pagesCount { get; set; } = null;

    /// <summary>
    /// The payment customization.
    /// </summary>
    [JsonPropertyName("paymentCustomization")]
    public PaymentCustomization? paymentCustomization { get; set; } = null;

    /// <summary>
    /// The payment customizations.
    /// </summary>
    [JsonPropertyName("paymentCustomizations")]
    public PaymentCustomizationConnection? paymentCustomizations { get; set; } = null;

    /// <summary>
    /// The list of payment terms templates eligible for all shops and users.
    /// </summary>
    [JsonPropertyName("paymentTermsTemplates")]
    public ICollection<PaymentTermsTemplate>? paymentTermsTemplates { get; set; } = null;

    /// <summary>
    /// The number of pendings orders. Limited to a maximum of 10000.
    /// </summary>
    [JsonPropertyName("pendingOrdersCount")]
    public Count? pendingOrdersCount { get; set; } = null;

    /// <summary>
    /// Returns a `PointOfSaleDevice` resource by ID.
    /// </summary>
    [JsonPropertyName("pointOfSaleDevice")]
    public PointOfSaleDevice? pointOfSaleDevice { get; set; } = null;

    /// <summary>
    /// Returns a price list resource by ID.
    /// </summary>
    [JsonPropertyName("priceList")]
    public PriceList? priceList { get; set; } = null;

    /// <summary>
    /// All price lists for a shop.
    /// </summary>
    [JsonPropertyName("priceLists")]
    public PriceListConnection? priceLists { get; set; } = null;

    /// <summary>
    /// The primary market of the shop.
    /// </summary>
    [JsonPropertyName("primaryMarket")]
    [Obsolete("Use `backupRegion` instead.")]
    public Market? primaryMarket { get; set; } = null;

    /// <summary>
    /// Privacy related settings for a shop.
    /// </summary>
    [JsonPropertyName("privacySettings")]
    public PrivacySettings? privacySettings { get; set; } = null;

    /// <summary>
    /// Retrieves a [product](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) by its ID.
    /// A product is an item that a merchant can sell in their store.
    /// Use the `product` query when you need to:
    /// - Access essential product data (for example, title, description, price, images, SEO metadata, and metafields).
    /// - Build product detail pages and manage inventory.
    /// - Handle international sales with localized pricing and content.
    /// - Manage product variants and product options.
    /// Learn more about working with [Shopify's product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/product-model-components).
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// Return a product by its handle.
    /// </summary>
    [JsonPropertyName("productByHandle")]
    [Obsolete("Use `productByIdentifier` instead.")]
    public Product? productByHandle { get; set; } = null;

    /// <summary>
    /// Return a product by an identifier.
    /// </summary>
    [JsonPropertyName("productByIdentifier")]
    public Product? productByIdentifier { get; set; } = null;

    /// <summary>
    /// Returns the product duplicate job.
    /// </summary>
    [JsonPropertyName("productDuplicateJob")]
    public ProductDuplicateJob? productDuplicateJob { get; set; } = null;

    /// <summary>
    /// Returns a ProductFeed resource by ID.
    /// </summary>
    [JsonPropertyName("productFeed")]
    public ProductFeed? productFeed { get; set; } = null;

    /// <summary>
    /// The product feeds for the shop.
    /// </summary>
    [JsonPropertyName("productFeeds")]
    public ProductFeedConnection? productFeeds { get; set; } = null;

    /// <summary>
    /// Returns a ProductOperation resource by ID.
    /// This can be used to query the
    /// [ProductSetOperation](https://shopify.dev/api/admin-graphql/current/objects/ProductSetOperation), using
    /// the ID that was returned
    /// [when the product was created or updated](https://shopify.dev/api/admin/migrate/new-product-model/sync-data#create-a-product-with-variants-and-options-asynchronously)
    /// by the
    /// [ProductSet](https://shopify.dev/api/admin-graphql/current/mutations/productSet) mutation.
    /// The `status` field indicates whether the operation is `CREATED`, `ACTIVE`, or `COMPLETE`.
    /// The `product` field provides the details of the created or updated product.
    /// For the
    /// [ProductSetOperation](https://shopify.dev/api/admin-graphql/current/objects/ProductSetOperation), the
    /// `userErrors` field provides mutation errors that occurred during the operation.
    /// </summary>
    [JsonPropertyName("productOperation")]
    public IProductOperation? productOperation { get; set; } = null;

    /// <summary>
    /// Returns the product resource feedback for the currently authenticated app.
    /// </summary>
    [JsonPropertyName("productResourceFeedback")]
    public ProductResourceFeedback? productResourceFeedback { get; set; } = null;

    /// <summary>
    /// Retrieves a list of [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
    /// in a store. Products are the items that merchants can sell in their store.
    /// Use the `products` query when you need to:
    /// - Build a browsing interface for a product catalog.
    /// - Create product
    /// [searching](https://shopify.dev/docs/api/usage/search-syntax), [sorting](https://shopify.dev/docs/api/admin-graphql/latest/queries/products#arguments-sortKey), and [filtering](https://shopify.dev/docs/api/admin-graphql/latest/queries/products#arguments-query) experiences.
    /// - Implement product recommendations.
    /// - Sync product data with external systems.
    /// The `products` query supports [pagination](https://shopify.dev/docs/api/usage/pagination-graphql)
    /// to handle large product catalogs and [saved searches](https://shopify.dev/docs/api/admin-graphql/latest/queries/products#arguments-savedSearchId)
    /// for frequently used product queries.
    /// The `products` query returns products with their associated metadata, including:
    /// - Basic product information (for example, title, description, vendor, and type)
    /// - Product options and product variants, with their prices and inventory
    /// - Media attachments (for example, images and videos)
    /// - SEO metadata
    /// - Product categories and tags
    /// - Product availability and publishing statuses
    /// Learn more about working with [Shopify's product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/product-model-components).
    /// </summary>
    [JsonPropertyName("products")]
    public ProductConnection? products { get; set; } = null;

    /// <summary>
    /// Returns a list of the shop's product saved searches.
    /// </summary>
    [JsonPropertyName("productSavedSearches")]
    public SavedSearchConnection? productSavedSearches { get; set; } = null;

    /// <summary>
    /// Count of products. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("productsCount")]
    public Count? productsCount { get; set; } = null;

    /// <summary>
    /// A list of tags that have been added to products.
    /// The maximum page size is 5000.
    /// </summary>
    [JsonPropertyName("productTags")]
    public StringConnection? productTags { get; set; } = null;

    /// <summary>
    /// The list of types added to products.
    /// The maximum page size is 1000.
    /// </summary>
    [JsonPropertyName("productTypes")]
    public StringConnection? productTypes { get; set; } = null;

    /// <summary>
    /// Retrieves a [product variant](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant) by its ID.
    /// A product variant is a specific version of a
    /// [product](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) that comes in more than
    /// one [option](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOption),
    /// such as size or color. For example, if a merchant sells t-shirts with options for size and color,
    /// then a small, blue t-shirt would be one product variant and a large, blue t-shirt would be another.
    /// Use the `productVariant` query when you need to:
    /// - Access essential product variant data (for example, title, price, image, and metafields).
    /// - Build product detail pages and manage inventory.
    /// - Handle international sales with localized pricing and content.
    /// - Manage product variants that are part of a bundle or selling plan.
    /// Learn more about working with [Shopify's product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/product-model-components).
    /// </summary>
    [JsonPropertyName("productVariant")]
    public ProductVariant? productVariant { get; set; } = null;

    /// <summary>
    /// Return a product variant by an identifier.
    /// </summary>
    [JsonPropertyName("productVariantByIdentifier")]
    public ProductVariant? productVariantByIdentifier { get; set; } = null;

    /// <summary>
    /// Retrieves a list of [product variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant)
    /// associated with a [product](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product).
    /// A product variant is a specific version of a product that comes in more than
    /// one [option](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOption),
    /// such as size or color. For example, if a merchant sells t-shirts with options for size and color,
    /// then a small, blue t-shirt would be one product variant and a large, blue t-shirt would be another.
    /// Use the `productVariants` query when you need to:
    /// - Search for product variants by attributes such as SKU, barcode, or inventory quantity.
    /// - Filter product variants by attributes, such as whether they're gift cards or have custom metafields.
    /// - Fetch product variants for bulk operations, such as updating prices or inventory.
    /// - Preload data for product variants, such as inventory items, selected options, or associated products.
    /// The `productVariants` query supports [pagination](https://shopify.dev/docs/api/usage/pagination-graphql)
    /// to handle large product catalogs and [saved searches](https://shopify.dev/docs/api/admin-graphql/latest/queries/productVariants#arguments-savedSearchId)
    /// for frequently used product variant queries.
    /// The `productVariants` query returns product variants with their associated metadata, including:
    /// - Basic product variant information (for example, title, SKU, barcode, price, and inventory)
    /// - Media attachments (for example, images and videos)
    /// - Associated products, selling plans, bundles, and metafields
    /// Learn more about working with [Shopify's product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/product-model-components).
    /// </summary>
    [JsonPropertyName("productVariants")]
    public ProductVariantConnection? productVariants { get; set; } = null;

    /// <summary>
    /// Count of product variants. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("productVariantsCount")]
    public Count? productVariantsCount { get; set; } = null;

    /// <summary>
    /// The list of vendors added to products.
    /// The maximum page size is 1000.
    /// </summary>
    [JsonPropertyName("productVendors")]
    public StringConnection? productVendors { get; set; } = null;

    /// <summary>
    /// The list of publicly-accessible Admin API versions, including supported
    /// versions, the release candidate, and unstable versions.
    /// </summary>
    [JsonPropertyName("publicApiVersions")]
    public ICollection<ApiVersion>? publicApiVersions { get; set; } = null;

    /// <summary>
    /// Lookup a publication by ID.
    /// </summary>
    [JsonPropertyName("publication")]
    public Publication? publication { get; set; } = null;

    /// <summary>
    /// List of publications.
    /// </summary>
    [JsonPropertyName("publications")]
    public PublicationConnection? publications { get; set; } = null;

    /// <summary>
    /// Count of publications. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("publicationsCount")]
    public Count? publicationsCount { get; set; } = null;

    /// <summary>
    /// Returns a count of published products by publication ID. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("publishedProductsCount")]
    public Count? publishedProductsCount { get; set; } = null;

    /// <summary>
    /// Retrieves a [refund](https://shopify.dev/docs/api/admin-graphql/latest/objects/Refund) by its ID.
    /// A refund represents a financial record of money returned to a customer from an order.
    /// It provides a comprehensive view of all refunded amounts, transactions, and restocking
    /// instructions associated with returning products or correcting order issues.
    /// Use the `refund` query to retrieve information associated with the following workflows:
    /// - Displaying refund details in order management interfaces
    /// - Building customer service tools for reviewing refund history
    /// - Creating reports on refunded amounts and reasons
    /// - Auditing refund transactions and payment gateway records
    /// - Tracking inventory impacts from refunded items
    /// A refund is associated with an
    /// [order](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order)
    /// and includes [refund line items](https://shopify.dev/docs/api/admin-graphql/latest/objects/RefundLineItem)
    /// that specify which items were refunded. Each refund processes through
    /// [order transactions](https://shopify.dev/docs/api/admin-graphql/latest/objects/OrderTransaction)
    /// that handle the actual money transfer back to the customer.
    /// </summary>
    [JsonPropertyName("refund")]
    public Refund? refund { get; set; } = null;

    /// <summary>
    /// Retrieves a return by its ID. A return represents the intent of a buyer to ship one or more items from an
    /// order back to a merchant or a third-party fulfillment location.
    /// Use the `return` query to retrieve information associated with the following workflows:
    /// - [Managing returns](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/build-return-management)
    /// - [Processing exchanges](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/manage-exchanges)
    /// - [Tracking reverse fulfillment orders](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/manage-reverse-fulfillment-orders)
    /// A return is associated with an
    /// [order](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order)
    /// and can include multiple return [line items](https://shopify.dev/docs/api/admin-graphql/latest/objects/LineItem).
    /// Each return has a [status](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps#return-statuses),
    /// which indicates the state of the return.
    /// </summary>
    [JsonPropertyName("return")]
    public Return? @return { get; set; } = null;

    /// <summary>
    /// Lookup a returnable fulfillment by ID.
    /// </summary>
    [JsonPropertyName("returnableFulfillment")]
    public ReturnableFulfillment? returnableFulfillment { get; set; } = null;

    /// <summary>
    /// List of returnable fulfillments.
    /// </summary>
    [JsonPropertyName("returnableFulfillments")]
    public ReturnableFulfillmentConnection? returnableFulfillments { get; set; } = null;

    /// <summary>
    /// The calculated monetary value to be exchanged due to the return.
    /// </summary>
    [JsonPropertyName("returnCalculate")]
    public CalculatedReturn? returnCalculate { get; set; } = null;

    /// <summary>
    /// Lookup a reverse delivery by ID.
    /// </summary>
    [JsonPropertyName("reverseDelivery")]
    public ReverseDelivery? reverseDelivery { get; set; } = null;

    /// <summary>
    /// Lookup a reverse fulfillment order by ID.
    /// </summary>
    [JsonPropertyName("reverseFulfillmentOrder")]
    public ReverseFulfillmentOrder? reverseFulfillmentOrder { get; set; } = null;

    /// <summary>
    /// <div class="note"><h4>Theme app extensions</h4>
    ///   <p>If your app integrates with a Shopify theme and you plan to submit it to
    /// the Shopify App Store, you must use theme app extensions instead of Script
    /// tags. Script tags can only be used with vintage themes. <a 
    ///href="/apps/online-store#what-integration-method-should-i-use" 
    ///target="_blank">Learn more</a>.</p></div>
    /// <div class="note"><h4>Script tag deprecation</h4>
    ///   <p>Script tags will be sunset for the <b>Order status</b> page on August 28, 2025. <a href="https://www.shopify.com/plus/upgrading-to-checkout-extensibility">Upgrade
    /// to Checkout Extensibility</a> before this date. <a 
    ///href="/docs/api/liquid/objects#script">Shopify Scripts</a> will continue to
    /// work alongside Checkout Extensibility until August 28, 2025.</p></div>
    /// Returns a `ScriptTag` resource by ID.
    /// </summary>
    [JsonPropertyName("scriptTag")]
    public ScriptTag? scriptTag { get; set; } = null;

    /// <summary>
    /// <div class="note"><h4>Theme app extensions</h4>
    ///   <p>If your app integrates with a Shopify theme and you plan to submit it to
    /// the Shopify App Store, you must use theme app extensions instead of Script
    /// tags. Script tags can only be used with vintage themes. <a 
    ///href="/apps/online-store#what-integration-method-should-i-use" 
    ///target="_blank">Learn more</a>.</p></div>
    /// <div class="note"><h4>Script tag deprecation</h4>
    ///   <p>Script tags will be sunset for the <b>Order status</b> page on August 28, 2025. <a href="https://www.shopify.com/plus/upgrading-to-checkout-extensibility">Upgrade
    /// to Checkout Extensibility</a> before this date. <a 
    ///href="/docs/api/liquid/objects#script">Shopify Scripts</a> will continue to
    /// work alongside Checkout Extensibility until August 28, 2025.</p></div>
    /// A list of script tags.
    /// </summary>
    [JsonPropertyName("scriptTags")]
    public ScriptTagConnection? scriptTags { get; set; } = null;

    /// <summary>
    /// The Customer Segment.
    /// </summary>
    [JsonPropertyName("segment")]
    public Segment? segment { get; set; } = null;

    /// <summary>
    /// A list of filters.
    /// </summary>
    [JsonPropertyName("segmentFilters")]
    public SegmentFilterConnection? segmentFilters { get; set; } = null;

    /// <summary>
    /// A list of filter suggestions associated with a segment. A segment is a group
    /// of members (commonly customers) that meet specific criteria.
    /// </summary>
    [JsonPropertyName("segmentFilterSuggestions")]
    public SegmentFilterConnection? segmentFilterSuggestions { get; set; } = null;

    /// <summary>
    /// A list of a shop's segment migrations.
    /// </summary>
    [JsonPropertyName("segmentMigrations")]
    public SegmentMigrationConnection? segmentMigrations { get; set; } = null;

    /// <summary>
    /// A list of a shop's segments.
    /// </summary>
    [JsonPropertyName("segments")]
    public SegmentConnection? segments { get; set; } = null;

    /// <summary>
    /// The number of segments for a shop. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("segmentsCount")]
    public Count? segmentsCount { get; set; } = null;

    /// <summary>
    /// The list of suggested values corresponding to a particular filter for a
    /// segment. A segment is a group of members, such as customers, that meet
    /// specific criteria.
    /// </summary>
    [JsonPropertyName("segmentValueSuggestions")]
    public SegmentValueConnection? segmentValueSuggestions { get; set; } = null;

    /// <summary>
    /// Returns a Selling Plan Group resource by ID.
    /// </summary>
    [JsonPropertyName("sellingPlanGroup")]
    public SellingPlanGroup? sellingPlanGroup { get; set; } = null;

    /// <summary>
    /// List Selling Plan Groups.
    /// </summary>
    [JsonPropertyName("sellingPlanGroups")]
    public SellingPlanGroupConnection? sellingPlanGroups { get; set; } = null;

    /// <summary>
    /// The server pixel configured by the app.
    /// </summary>
    [JsonPropertyName("serverPixel")]
    public ServerPixel? serverPixel { get; set; } = null;

    /// <summary>
    /// Returns the Shop resource corresponding to the access token used in the request. The Shop resource contains
    /// business and store management settings for the shop.
    /// </summary>
    [JsonPropertyName("shop")]
    public Shop? shop { get; set; } = null;

    /// <summary>
    /// The shop's billing preferences.
    /// </summary>
    [JsonPropertyName("shopBillingPreferences")]
    public ShopBillingPreferences? shopBillingPreferences { get; set; } = null;

    /// <summary>
    /// Returns a Shopify Function by its ID.
    /// [Functions](https://shopify.dev/apps/build/functions)
    /// enable you to customize Shopify's backend logic at defined parts of the commerce loop.
    /// </summary>
    [JsonPropertyName("shopifyFunction")]
    public ShopifyFunction? shopifyFunction { get; set; } = null;

    /// <summary>
    /// Returns the Shopify Functions owned by the querying API client installed on the shop.
    /// </summary>
    [JsonPropertyName("shopifyFunctions")]
    public ShopifyFunctionConnection? shopifyFunctions { get; set; } = null;

    /// <summary>
    /// Shopify Payments account information, including balances and payouts.
    /// </summary>
    [JsonPropertyName("shopifyPaymentsAccount")]
    public ShopifyPaymentsAccount? shopifyPaymentsAccount { get; set; } = null;

    /// <summary>
    /// A list of locales available on a shop.
    /// </summary>
    [JsonPropertyName("shopLocales")]
    public ICollection<ShopLocale>? shopLocales { get; set; } = null;

    /// <summary>
    /// Returns a Shop Pay payment request receipt.
    /// </summary>
    [JsonPropertyName("shopPayPaymentRequestReceipt")]
    public ShopPayPaymentRequestReceipt? shopPayPaymentRequestReceipt { get; set; } = null;

    /// <summary>
    /// Returns a list of Shop Pay payment request receipts.
    /// </summary>
    [JsonPropertyName("shopPayPaymentRequestReceipts")]
    public ShopPayPaymentRequestReceiptConnection? shopPayPaymentRequestReceipts { get; set; } = null;

    /// <summary>
    /// The StaffMember resource, by ID.
    /// </summary>
    [JsonPropertyName("staffMember")]
    public StaffMember? staffMember { get; set; } = null;

    /// <summary>
    /// The shop staff members.
    /// </summary>
    [JsonPropertyName("staffMembers")]
    public StaffMemberConnection? staffMembers { get; set; } = null;

    /// <summary>
    /// Standard metafield definitions are intended for specific, common use cases.
    /// Their namespace and keys reflect these use cases and are reserved.
    /// Refer to all available [`Standard Metafield Definition Templates`](https://shopify.dev/api/admin-graphql/latest/objects/StandardMetafieldDefinitionTemplate).
    /// </summary>
    [JsonPropertyName("standardMetafieldDefinitionTemplates")]
    public StandardMetafieldDefinitionTemplateConnection? standardMetafieldDefinitionTemplates { get; set; } = null;

    /// <summary>
    /// Returns a store credit account resource by ID.
    /// </summary>
    [JsonPropertyName("storeCreditAccount")]
    public StoreCreditAccount? storeCreditAccount { get; set; } = null;

    /// <summary>
    /// Returns a SubscriptionBillingAttempt by ID.
    /// </summary>
    [JsonPropertyName("subscriptionBillingAttempt")]
    public SubscriptionBillingAttempt? subscriptionBillingAttempt { get; set; } = null;

    /// <summary>
    /// Returns subscription billing attempts on a store.
    /// </summary>
    [JsonPropertyName("subscriptionBillingAttempts")]
    public SubscriptionBillingAttemptConnection? subscriptionBillingAttempts { get; set; } = null;

    /// <summary>
    /// Returns a subscription billing cycle found either by cycle index or date.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycle")]
    public SubscriptionBillingCycle? subscriptionBillingCycle { get; set; } = null;

    /// <summary>
    /// Retrieves the results of the asynchronous job for the subscription billing
    /// cycle bulk action based on the specified job ID.
    /// This query can be used to obtain the billing cycles that match the criteria
    /// defined in the subscriptionBillingCycleBulkSearch and
    /// subscriptionBillingCycleBulkCharge mutations.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycleBulkResults")]
    public SubscriptionBillingCycleConnection? subscriptionBillingCycleBulkResults { get; set; } = null;

    /// <summary>
    /// Returns subscription billing cycles for a contract ID.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycles")]
    public SubscriptionBillingCycleConnection? subscriptionBillingCycles { get; set; } = null;

    /// <summary>
    /// Returns a Subscription Contract resource by ID.
    /// </summary>
    [JsonPropertyName("subscriptionContract")]
    public SubscriptionContract? subscriptionContract { get; set; } = null;

    /// <summary>
    /// List Subscription Contracts.
    /// </summary>
    [JsonPropertyName("subscriptionContracts")]
    public SubscriptionContractConnection? subscriptionContracts { get; set; } = null;

    /// <summary>
    /// Returns a Subscription Draft resource by ID.
    /// </summary>
    [JsonPropertyName("subscriptionDraft")]
    public SubscriptionDraft? subscriptionDraft { get; set; } = null;

    /// <summary>
    /// The Taxonomy resource lets you access the categories, attributes and values of the loaded taxonomy tree.
    /// </summary>
    [JsonPropertyName("taxonomy")]
    public Taxonomy? taxonomy { get; set; } = null;

    /// <summary>
    /// Returns a list of TenderTransactions associated with the shop.
    /// </summary>
    [JsonPropertyName("tenderTransactions")]
    public TenderTransactionConnection? tenderTransactions { get; set; } = null;

    /// <summary>
    /// Returns a particular theme for the shop.
    /// </summary>
    [JsonPropertyName("theme")]
    public OnlineStoreTheme? theme { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of themes for the shop.
    /// </summary>
    [JsonPropertyName("themes")]
    public OnlineStoreThemeConnection? themes { get; set; } = null;

    /// <summary>
    /// A resource that can have localized values for different languages.
    /// </summary>
    [JsonPropertyName("translatableResource")]
    public TranslatableResource? translatableResource { get; set; } = null;

    /// <summary>
    /// Resources that can have localized values for different languages.
    /// </summary>
    [JsonPropertyName("translatableResources")]
    public TranslatableResourceConnection? translatableResources { get; set; } = null;

    /// <summary>
    /// Resources that can have localized values for different languages.
    /// </summary>
    [JsonPropertyName("translatableResourcesByIds")]
    public TranslatableResourceConnection? translatableResourcesByIds { get; set; } = null;

    /// <summary>
    /// Returns a redirect resource by ID.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public UrlRedirect? urlRedirect { get; set; } = null;

    /// <summary>
    /// Returns a redirect import resource by ID.
    /// </summary>
    [JsonPropertyName("urlRedirectImport")]
    public UrlRedirectImport? urlRedirectImport { get; set; } = null;

    /// <summary>
    /// A list of redirects for a shop.
    /// </summary>
    [JsonPropertyName("urlRedirects")]
    public UrlRedirectConnection? urlRedirects { get; set; } = null;

    /// <summary>
    /// A list of the shop's URL redirect saved searches.
    /// </summary>
    [JsonPropertyName("urlRedirectSavedSearches")]
    public SavedSearchConnection? urlRedirectSavedSearches { get; set; } = null;

    /// <summary>
    /// Count of redirects. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("urlRedirectsCount")]
    public Count? urlRedirectsCount { get; set; } = null;

    /// <summary>
    /// Validation available on the shop.
    /// </summary>
    [JsonPropertyName("validation")]
    public Validation? validation { get; set; } = null;

    /// <summary>
    /// Validations available on the shop.
    /// </summary>
    [JsonPropertyName("validations")]
    public ValidationConnection? validations { get; set; } = null;

    /// <summary>
    /// Returns a webhook subscription by ID.
    /// Building an app? If you only use app-specific webhooks, you won't need this.
    /// App-specific webhook subscriptions specified in your `shopify.app.toml` may be
    /// easier. They are automatically kept up to date by Shopify & require less
    /// maintenance. Please read [About managing webhook
    /// subscriptions](https://shopify.dev/docs/apps/build/webhooks/subscribe).
    /// </summary>
    [JsonPropertyName("webhookSubscription")]
    public WebhookSubscription? webhookSubscription { get; set; } = null;

    /// <summary>
    /// Returns a list of webhook subscriptions.
    /// Building an app? If you only use app-specific webhooks, you won't need this.
    /// App-specific webhook subscriptions specified in your `shopify.app.toml` may be
    /// easier. They are automatically kept up to date by Shopify & require less
    /// maintenance. Please read [About managing webhook
    /// subscriptions](https://shopify.dev/docs/apps/build/webhooks/subscribe).
    /// </summary>
    [JsonPropertyName("webhookSubscriptions")]
    public WebhookSubscriptionConnection? webhookSubscriptions { get; set; } = null;

    /// <summary>
    /// The count of webhook subscriptions.
    /// Building an app? If you only use app-specific webhooks, you won't need this.
    /// App-specific webhook subscriptions specified in your `shopify.app.toml` may be
    /// easier. They are automatically kept up to date by Shopify & require less
    /// maintenance. Please read [About managing webhook
    /// subscriptions](https://shopify.dev/docs/apps/build/webhooks/subscribe).
    /// Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("webhookSubscriptionsCount")]
    public Count? webhookSubscriptionsCount { get; set; } = null;

    /// <summary>
    /// Returns a
    /// [web pixel](https://shopify.dev/docs/apps/build/marketing-analytics/build-web-pixels)
    /// by ID.
    /// </summary>
    [JsonPropertyName("webPixel")]
    public WebPixel? webPixel { get; set; } = null;

    /// <summary>
    /// The web presences for the shop.
    /// </summary>
    [JsonPropertyName("webPresences")]
    public MarketWebPresenceConnection? webPresences { get; set; } = null;
}