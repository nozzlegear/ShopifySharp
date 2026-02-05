#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The schema's entry-point for queries. This acts as the public, top-level API from which all queries must start.
/// </summary>
public record QueryRoot : IGraphQLObject
{
    /// <summary>
    /// Returns a list of abandoned checkouts. A checkout is considered abandoned when
    /// a customer adds contact information but doesn't complete their purchase.
    /// Includes both abandoned and recovered checkouts.
    /// Each checkout provides [`Customer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer) details, [`AbandonedCheckoutLineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AbandonedCheckoutLineItem)
    /// objects, pricing information, and a recovery URL for re-engaging customers who
    /// didn't complete their purchase.
    /// </summary>
    [JsonPropertyName("abandonedCheckouts")]
    public AbandonedCheckoutConnection? abandonedCheckouts { get; set; } = null;

    /// <summary>
    /// Returns the count of abandoned checkouts for the given shop. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("abandonedCheckoutsCount")]
    public Count? abandonedCheckoutsCount { get; set; } = null;

    /// <summary>
    /// Returns a `Abandonment` resource by ID.
    /// </summary>
    [JsonPropertyName("abandonment")]
    public Abandonment? abandonment { get; set; } = null;

    /// <summary>
    /// Returns an Abandonment by the Abandoned Checkout ID.
    /// </summary>
    [JsonPropertyName("abandonmentByAbandonedCheckoutId")]
    public Abandonment? abandonmentByAbandonedCheckoutId { get; set; } = null;

    /// <summary>
    /// Retrieves an [`App`](https://shopify.dev/docs/api/admin-graphql/latest/objects/App) by
    /// its ID. If no ID is provided, returns details about the currently
    /// authenticated app. The query provides access to app details including title,
    /// icon, and pricing information.
    /// If the app isn't installed on the current shop, then the [`installation`](https://shopify.dev/docs/api/admin-graphql/latest/queries/app#returns-App.fields.installation)
    /// field will be `null`.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// Retrieves an app by its unique handle. The handle is a URL-friendly identifier for the app.
    /// Returns the [`App`](https://shopify.dev/docs/api/admin-graphql/latest/objects/App) if
    /// found, or `null` if no app exists with the specified handle.
    /// </summary>
    [JsonPropertyName("appByHandle")]
    public App? appByHandle { get; set; } = null;

    /// <summary>
    /// Retrieves an [`App`](https://shopify.dev/docs/api/admin-graphql/latest/objects/App) by
    /// its client ID (API key). Returns the app's configuration, installation status, [`AccessScope`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AccessScope)
    /// objects, and developer information.
    /// Returns `null` if no app exists with the specified client ID.
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
    /// Retrieves an [`AppInstallation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AppInstallation) by ID. If no ID is provided, returns the installation for the currently authenticated
    /// [`App`](https://shopify.dev/docs/api/admin-graphql/latest/objects/App). The
    /// query provides essential data for validating installation state and managing
    /// app functionality within a store.
    /// Use this query to access installation details including granted [`AccessScope`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AccessScope)
    /// objects, active [`AppSubscription`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AppSubscription) objects, [`AppCredit`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AppCredit) objects, [`AppPurchaseOneTime`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AppPurchaseOneTime)
    /// objects, and app-specific metadata.
    /// Learn more about [app installation](https://shopify.dev/docs/apps/build/authentication-authorization/app-installation).
    /// </summary>
    [JsonPropertyName("appInstallation")]
    public AppInstallation? appInstallation { get; set; } = null;

    /// <summary>
    /// A paginated list of [`AppInstallation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AppInstallation)
    /// objects across multiple stores where your app is installed. Use this query to
    /// monitor installation status, track billing and subscriptions through [`AppSubscription`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AppSubscription)
    /// objects, and review granted [`AccessScope`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AccessScope) objects.
    /// Filter by [`AppInstallationCategory`](https://shopify.dev/docs/api/admin-graphql/latest/enums/AppInstallationCategory) to find specific types of installations (such as POS or channel apps) and by [`AppInstallationPrivacy`](https://shopify.dev/docs/api/admin-graphql/latest/enums/AppInstallationPrivacy)
    /// to scope to public or private installations.
    /// </summary>
    [JsonPropertyName("appInstallations")]
    public AppInstallationConnection? appInstallations { get; set; } = null;

    /// <summary>
    /// Returns a `Article` resource by ID.
    /// </summary>
    [JsonPropertyName("article")]
    public Article? article { get; set; } = null;

    /// <summary>
    /// List of article authors for the shop.
    /// </summary>
    [JsonPropertyName("articleAuthors")]
    public ArticleAuthorConnection? articleAuthors { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of articles from the shop's blogs.
    /// [`Article`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Article)
    /// objects are blog posts that contain content like text, images, and tags.
    /// Supports [cursor-based
    /// pagination](https://shopify.dev/docs/api/usage/pagination-graphql) to control
    /// the number of articles returned and their order. Use the [`query`](https://shopify.dev/docs/api/admin-graphql/latest/queries/articles#arguments-query)
    /// argument to filter results by specific criteria.
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
    /// Returns a `DiscountAutomatic` resource by ID.
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
    [Obsolete("Use `discountNodes` instead.")]
    public DiscountAutomaticNodeConnection? automaticDiscountNodes { get; set; } = null;

    /// <summary>
    /// Returns a list of automatic discounts that are applied in the cart and at checkout without requiring a discount code.
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
    /// The geographic regions that you can set as the
    /// [`Shop`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Shop)'s
    /// backup region. The backup region serves as a fallback when the system can't
    /// determine a buyer's actual location.
    /// </summary>
    [JsonPropertyName("availableBackupRegions")]
    public ICollection<IMarketRegion>? availableBackupRegions { get; set; } = null;

    /// <summary>
    /// Returns a list of activated carrier services and associated shop locations that support them.
    /// </summary>
    [JsonPropertyName("availableCarrierServices")]
    public ICollection<DeliveryCarrierServiceAndLocations>? availableCarrierServices { get; set; } = null;

    /// <summary>
    /// Returns all locales that Shopify supports. Each
    /// [`Locale`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Locale)
    /// includes an ISO code and human-readable name. Use this query to discover which
    /// locales you can enable on a shop with the [`shopLocaleEnable`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/shopLocaleEnable) mutation.
    /// </summary>
    [JsonPropertyName("availableLocales")]
    public ICollection<Locale>? availableLocales { get; set; } = null;

    /// <summary>
    /// The backup region of the shop.
    /// </summary>
    [JsonPropertyName("backupRegion")]
    public IMarketRegion? backupRegion { get; set; } = null;

    /// <summary>
    /// Returns a `Blog` resource by ID.
    /// </summary>
    [JsonPropertyName("blog")]
    public Blog? blog { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of the shop's
    /// [`Blog`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Blog)
    /// objects. Blogs serve as containers for
    /// [`Article`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Article)
    /// objects and provide content management capabilities for the store's editorial content.
    /// Supports [cursor-based
    /// pagination](https://shopify.dev/docs/api/usage/pagination-graphql) to control
    /// the number of blogs returned and their order. Use the [`query`](https://shopify.dev/docs/api/admin-graphql/latest/queries/blogs#arguments-query)
    /// argument to filter results by specific criteria.
    /// </summary>
    [JsonPropertyName("blogs")]
    public BlogConnection? blogs { get; set; } = null;

    /// <summary>
    /// Count of blogs. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("blogsCount")]
    public Count? blogsCount { get; set; } = null;

    /// <summary>
    /// Returns a `BulkOperation` resource by ID.
    /// </summary>
    [JsonPropertyName("bulkOperation")]
    public BulkOperation? bulkOperation { get; set; } = null;

    /// <summary>
    /// Returns the app's bulk operations meeting the specified filters. Defaults to
    /// sorting by created_at, with newest operations first.
    /// </summary>
    [JsonPropertyName("bulkOperations")]
    public BulkOperationConnection? bulkOperations { get; set; } = null;

    /// <summary>
    /// Returns the list of [business entities](https://shopify.dev/docs/api/admin-graphql/latest/objects/BusinessEntity)
    /// associated with the shop. Use this query to retrieve business entities for
    /// assigning to markets, managing payment providers per entity, or viewing entity
    /// attribution on orders.
    /// Each shop can have multiple business entities with one designated as primary.
    /// To identify the primary entity in the query results, set the [`primary`](https://shopify.dev/docs/api/admin-graphql/latest/queries/businessEntities#returns-BusinessEntity.fields.primary)
    /// field to `true`.
    /// Learn more about [managing multiple legal entities](https://shopify.dev/docs/apps/build/markets/multiple-entities).
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
    /// A paginated list of carrier services configured for the shop. Carrier services
    /// provide real-time shipping rates from external providers like FedEx, UPS, or
    /// custom shipping solutions. Use the `query` parameter to filter results by
    /// attributes such as active status.
    /// </summary>
    [JsonPropertyName("carrierServices")]
    public DeliveryCarrierServiceConnection? carrierServices { get; set; } = null;

    /// <summary>
    /// Retrieves all cart transform functions currently deployed by your app within
    /// the merchant's store. This query provides comprehensive access to your active
    /// cart modification logic, enabling management and monitoring of bundling and
    /// merchandising features.
    /// The query returns paginated results with full cart transform details,
    /// including function IDs, configuration settings, and operational status.
    /// Cart Transform ownership is scoped to your API client, ensuring you only see
    /// and manage functions deployed by your specific app. This isolation prevents
    /// conflicts between different apps while maintaining security boundaries for
    /// sensitive merchandising logic.
    /// Learn more about [managing cart transforms](https://shopify.dev/docs/api/functions/latest/cart-transform).
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
    /// Returns a paginated list of catalogs for the shop. Catalogs control which
    /// products are published and how they're priced in different contexts, such as
    /// international markets (Canada vs. United States), B2B company locations
    /// (different branches of the same business), or specific sales channels (such as
    /// online store vs. POS).
    /// Filter catalogs by [`type`](https://shopify.dev/docs/api/admin-graphql/latest/queries/catalogs#arguments-type) and use the [`query`](https://shopify.dev/docs/api/admin-graphql/latest/queries/catalogs#arguments-query)
    /// argument to search and filter by additional criteria.
    /// Learn more about [Shopify Catalogs](https://shopify.dev/docs/apps/build/markets/catalogs-different-markets).
    /// </summary>
    [JsonPropertyName("catalogs")]
    public CatalogConnection? catalogs { get; set; } = null;

    /// <summary>
    /// The count of catalogs belonging to the shop. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("catalogsCount")]
    public Count? catalogsCount { get; set; } = null;

    /// <summary>
    /// Returns a `Channel` resource by ID.
    /// </summary>
    [JsonPropertyName("channel")]
    public Channel? channel { get; set; } = null;

    /// <summary>
    /// Returns active [channels](https://shopify.dev/docs/api/admin-graphql/latest/objects/Channel)
    /// where merchants sell products and collections. Each channel is an
    /// authenticated link to an external platform such as marketplaces, social media
    /// platforms, online stores, or point-of-sale systems.
    /// </summary>
    [JsonPropertyName("channels")]
    public ChannelConnection? channels { get; set; } = null;

    /// <summary>
    /// Returns the visual customizations for checkout for a given [checkout profile](https://shopify.dev/docs/api/admin-graphql/latest/objects/CheckoutProfile).
    /// To update checkout branding settings, use the [`checkoutBrandingUpsert`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/checkoutBrandingUpsert)
    /// mutation. Learn more about [customizing checkout's
    /// appearance](https://shopify.dev/docs/apps/build/checkout/styling).
    /// </summary>
    [JsonPropertyName("checkoutBranding")]
    public CheckoutBranding? checkoutBranding { get; set; } = null;

    /// <summary>
    /// Returns a [`CheckoutProfile`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CheckoutProfile). Checkout profiles define the branding settings and UI extensions for a store's
    /// checkout experience. Stores can have one published profile that renders on
    /// their live checkout and multiple draft profiles for testing customizations in
    /// the checkout editor.
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
    /// Retrieves a [code discount](https://help.shopify.com/manual/discounts/discount-types#discount-codes)
    /// by its discount code. The search is case-insensitive, enabling you to find
    /// discounts regardless of how customers enter the code.
    /// Returns a [`DiscountCodeNode`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountCodeNode) that contains the underlying discount details, which could be a basic [amount off discount](https://help.shopify.com/manual/discounts/discount-types/percentage-fixed-amount),
    /// a ["Buy X Get Y" (BXGY) discount](https://help.shopify.com/manual/discounts/discount-types/buy-x-get-y),
    /// a [free shipping discount](https://help.shopify.com/manual/discounts/discount-types/free-shipping),
    /// or an [app-provided discount](https://help.shopify.com/manual/discounts/discount-types/discounts-with-apps).
    /// Learn more about working with [Shopify's discount model](https://shopify.dev/docs/apps/build/discounts).
    /// </summary>
    [JsonPropertyName("codeDiscountNodeByCode")]
    public DiscountCodeNode? codeDiscountNodeByCode { get; set; } = null;

    /// <summary>
    /// Returns a list of [code-based discounts](https://help.shopify.com/manual/discounts/discount-types#discount-codes).
    /// </summary>
    [JsonPropertyName("codeDiscountNodes")]
    [Obsolete("Use `discountNodes` instead.")]
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
    /// Retrieves a collection by its unique handle identifier. Handles provide a
    /// URL-friendly way to reference collections and are commonly used in storefront
    /// URLs and navigation.
    /// For example, a collection with the title "Summer Sale" might have the handle
    /// `summer-sale`, allowing you to fetch it directly without knowing the internal ID.
    /// Use `CollectionByHandle` to:
    /// - Fetch collections for storefront display and navigation
    /// - Build collection-based URLs and routing systems
    /// - Validate collection existence before displaying content
    /// Handles are automatically generated from collection titles but can be
    /// customized by merchants for SEO and branding purposes.
    /// Learn more about [collections](https://shopify.dev/docs/api/admin-graphql/latest/objects/Collection).
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
    /// Returns a `Comment` resource by ID.
    /// </summary>
    [JsonPropertyName("comment")]
    public Comment? comment { get; set; } = null;

    /// <summary>
    /// List of the shop's comments.
    /// </summary>
    [JsonPropertyName("comments")]
    public CommentConnection? comments { get; set; } = null;

    /// <summary>
    /// A paginated list of companies in the shop.
    /// [`Company`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Company)
    /// objects are business entities that purchase from the merchant.
    /// Use the [`query`](https://shopify.dev/docs/api/admin-graphql/latest/queries/companies#arguments-query) argument to filter companies by attributes like name or externalId. Sort and
    /// paginate results to handle large datasets efficiently. Learn more about
    /// [Shopify API search syntax](https://shopify.dev/docs/api/usage/search-syntax).
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
    /// A paginated list of [`CompanyLocation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CompanyLocation)
    /// objects for B2B customers. Company locations represent individual branches or offices of a
    /// [`Company`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Company)
    /// where B2B orders can be placed.
    /// Each location can have its own billing and shipping addresses, tax settings, [`PaymentTerms`](https://shopify.dev/docs/api/admin-graphql/latest/objects/PaymentTerms), and [`Catalog`](https://shopify.dev/docs/api/admin-graphql/latest/interfaces/Catalog)
    /// assignments with custom pricing. Use the query parameter to search locations
    /// by name or other attributes.
    /// Learn more about [managing company locations](https://shopify.dev/docs/apps/build/b2b/manage-client-company-locations).
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
    /// Returns the [`AppInstallation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AppInstallation) for the currently authenticated app. Provides access to granted access scopes, active [`AppSubscription`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AppSubscription)
    /// objects, and billing information for your app.
    /// Use this query to check which permissions your app has, monitor subscription
    /// status, or retrieve [`AppCredit`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AppCredit)
    /// objects. Learn more about [managing access scopes](https://shopify.dev/docs/api/usage/access-scopes#checking-granted-access-scopes), [subscription
    /// billing](https://shopify.dev/docs/apps/launch/billing/subscription-billing), and
    /// [app credits](https://shopify.dev/docs/apps/launch/billing/award-app-credits).
    /// </summary>
    [JsonPropertyName("currentAppInstallation")]
    public AppInstallation? currentAppInstallation { get; set; } = null;

    /// <summary>
    /// Returns the current app's most recent [`BulkOperation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/BulkOperation).
    /// Apps can run one bulk query and one bulk mutation operation at a time per shop.
    /// The operation type parameter determines whether to retrieve the most recent
    /// query or mutation bulk operation. Use this query to check the operation's
    /// status, track its progress, and retrieve the result URL when it completes.
    /// </summary>
    [JsonPropertyName("currentBulkOperation")]
    [Obsolete("Use `bulkOperations` with status filter instead.")]
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
    /// Returns a `CustomerAccountPage` resource by ID.
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
    /// A paginated list of customers that belong to an individual [`Segment`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Segment).
    /// Segments group customers based on criteria defined through [ShopifyQL queries](https://shopify.dev/docs/api/shopifyql/segment-query-language-reference).
    /// Access segment members with their profile information and purchase summary
    /// data. The connection includes statistics for analyzing segment attributes
    /// (such as average and sum calculations) and a total count of all members.
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
    /// Returns a `CustomerSegmentMembersQuery` resource by ID.
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
    /// Retrieves a [`DeliveryProfile`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DeliveryProfile) by ID. Delivery profiles group shipping settings for specific
    /// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
    /// objects that ship from selected [`Location`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location)
    /// objects to [delivery
    /// zones](https://shopify.dev/docs/api/admin-graphql/latest/objects/DeliveryZone
    /// with defined rates.
    /// Learn more about [delivery profiles](https://shopify.dev/docs/apps/build/purchase-options/deferred/delivery-and-deferment#whats-a-delivery-profile).
    /// </summary>
    [JsonPropertyName("deliveryProfile")]
    public DeliveryProfile? deliveryProfile { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of [`DeliveryProfile`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DeliveryProfile)
    /// objects for the shop. Delivery profiles group
    /// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) and [`ProductVariant`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant)
    /// objects that share shipping rates and zones.
    /// Each profile contains [`DeliveryLocationGroup`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DeliveryLocationGroup)
    /// objects that organize fulfillment [`Location`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location)
    /// objects and their associated delivery zones. [`DeliveryZone`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DeliveryZone)
    /// objects define geographic regions with specific shipping methods and rates. Use the [`merchantOwnedOnly`](https://shopify.dev/docs/api/admin-graphql/latest/queries/deliveryProfiles#arguments-merchantOwnedOnly)
    /// filter to exclude profiles that third-party apps manage.
    /// Learn more about [delivery profiles](https://shopify.dev/docs/apps/build/purchase-options/deferred/delivery-and-deferment#whats-a-delivery-profile).
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
    /// Returns a `DiscountNode` resource by ID.
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
    /// Returns a `Domain` resource by ID.
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
    /// Available delivery options for a [`DraftOrder`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DraftOrder)
    /// based on the provided input. The query returns shipping rates, local delivery
    /// rates, and pickup locations that merchants can choose from when creating draft orders.
    /// Accepts draft order details including [`LineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/LineItem) objects, [`MailingAddress`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MailingAddress)
    /// for shipping, and discounts to determine which delivery methods are available.
    /// Pagination parameters control the number of local pickup options returned.
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
    /// Retrieves a single event by ID. Events chronicle activities in your store such
    /// as resource creation, updates, or staff comments. The query returns an
    /// [`Event`](https://shopify.dev/docs/api/admin-graphql/latest/interfaces/Event)
    /// interface of type [`BasicEvent`](https://shopify.dev/docs/api/admin-graphql/latest/objects/BasicEvent) or [`CommentEvent`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CommentEvent).
    /// </summary>
    [JsonPropertyName("event")]
    public IEvent? @event { get; set; } = null;

    /// <summary>
    /// A paginated list of events that chronicle activities in the store.
    /// [`Event`](https://shopify.dev/docs/api/admin-graphql/latest/interfaces/Event)
    /// is an interface implemented by types such as [`BasicEvent`](https://shopify.dev/docs/api/admin-graphql/latest/objects/BasicEvent) and [`CommentEvent`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CommentEvent)
    /// that track actions such as creating
    /// [`Article`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Article)
    /// objects, fulfilling
    /// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order)
    /// objects, adding
    /// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
    /// objects, or staff comments on timelines.
    /// The query supports filtering and sorting to help you find specific events or audit store activity over time.
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
    /// Retrieves a [`Fulfillment`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Fulfillment) by its ID. A fulfillment is a record that the merchant has completed their
    /// work required for one or more line items in an
    /// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order). It
    /// includes tracking information, [`LineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/LineItem)
    /// objects, and the status of the fulfillment.
    /// Use this query to track the progress of shipped items, view tracking details,
    /// or check [fulfillment events](https://shopify.dev/docs/api/admin-graphql/latest/objects/FulfillmentEvent)
    /// for example when a package is out for delivery or delivered.
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
    /// Returns a [`FulfillmentService`](https://shopify.dev/docs/api/admin-graphql/latest/objects/FulfillmentService) by its ID. The service can manage inventory, process fulfillment requests, and
    /// provide tracking details through callback endpoints or directly calling
    /// Shopify's APIs.
    /// When you register a fulfillment service, Shopify automatically creates an associated [`Location`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location)
    /// where fulfillment order's can be assigned to be processed.
    /// Learn more about [building fulfillment service apps](https://shopify.dev/docs/apps/build/orders-fulfillment/fulfillment-service-apps/build-for-fulfillment-services).
    /// </summary>
    [JsonPropertyName("fulfillmentService")]
    public FulfillmentService? fulfillmentService { get; set; } = null;

    /// <summary>
    /// Retrieves a [`GiftCard`](https://shopify.dev/docs/api/admin-graphql/latest/objects/GiftCard) by its ID. Returns the gift card's balance, transaction history, [`Customer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)
    /// information, and whether it's enabled.
    /// Additional fields include the initial value, expiration date, deactivation
    /// timestamp (if applicable), and the associated
    /// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order) if
    /// the gift card was purchased by a customer through checkout. Gift cards that
    /// merchants create manually won't have an associated order.
    /// </summary>
    [JsonPropertyName("giftCard")]
    public GiftCard? giftCard { get; set; } = null;

    /// <summary>
    /// The configuration for the shop's gift cards.
    /// </summary>
    [JsonPropertyName("giftCardConfiguration")]
    public GiftCardConfiguration? giftCardConfiguration { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of [`GiftCard`](https://shopify.dev/docs/api/admin-graphql/latest/objects/GiftCard)
    /// objects issued for the shop.
    /// You can filter gift cards by attributes such as status, last characters of the
    /// code, balance status, and other values using the [`query`](https://shopify.dev/docs/api/admin-graphql/latest/queries/giftCards#arguments-query)
    /// parameter. You can also apply [`SavedSearch`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SavedSearch)
    /// objects to filter results.
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
    /// Returns the shop's inventory configuration, including all inventory quantity
    /// names. Quantity names represent different [inventory states](https://shopify.dev/docs/apps/build/orders-fulfillment/inventory-management-apps#inventory-states)
    /// that merchants use to track inventory.
    /// </summary>
    [JsonPropertyName("inventoryProperties")]
    public InventoryProperties? inventoryProperties { get; set; } = null;

    /// <summary>
    /// Retrieves an [`InventoryShipment`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryShipment) by ID. Returns tracking details, [`InventoryShipmentLineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryShipmentLineItem)
    /// objects with quantities, and the shipment's current [`InventoryShipmentStatus`](https://shopify.dev/docs/api/admin-graphql/latest/enums/InventoryShipmentStatus).
    /// </summary>
    [JsonPropertyName("inventoryShipment")]
    public InventoryShipment? inventoryShipment { get; set; } = null;

    /// <summary>
    /// Returns an [`InventoryTransfer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryTransfer) by ID. Inventory transfers track the movement of inventory between locations,
    /// including origin and destination details, [`InventoryTransferLineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryTransferLineItem)
    /// objects, quantities, and [`InventoryTransferStatus`](https://shopify.dev/docs/api/admin-graphql/latest/enums/InventoryTransferStatus) values.
    /// </summary>
    [JsonPropertyName("inventoryTransfer")]
    public InventoryTransfer? inventoryTransfer { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of [`InventoryTransfer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryTransfer)
    /// objects between locations. Transfers track the movement of [`InventoryItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryItem)
    /// objects between [`Location`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location) objects.
    /// Supports filtering transfers using query parameters and sorting by various
    /// criteria. Use the connection's edges to access transfer details including [`InventoryTransferLineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryTransferLineItem)
    /// objects, quantities, and shipment status.
    /// </summary>
    [JsonPropertyName("inventoryTransfers")]
    public InventoryTransferConnection? inventoryTransfers { get; set; } = null;

    /// <summary>
    /// Returns a Job resource by ID. Used to check the status of internal jobs and any applicable changes.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// Retrieves a [`Location`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location) by its ID. Locations are physical places where merchants store inventory, such
    /// as warehouses, retail stores, or fulfillment centers.
    /// Each location tracks inventory levels, fulfillment capabilities, and address
    /// information. Active locations can stock products and fulfill orders based on
    /// their configuration settings.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// Return a location by an identifier.
    /// </summary>
    [JsonPropertyName("locationByIdentifier")]
    public Location? locationByIdentifier { get; set; } = null;

    /// <summary>
    /// A paginated list of inventory locations where merchants can stock
    /// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
    /// items and fulfill
    /// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order) items.
    /// Returns only active locations by default. Use the [`includeInactive`](https://shopify.dev/docs/api/admin-graphql/latest/queries/locations#arguments-includeInactive)
    /// argument to retrieve deactivated locations that can no longer stock inventory
    /// or fulfill orders. Use the [`includeLegacy`](https://shopify.dev/docs/api/admin-graphql/latest/queries/locations#arguments-includeLegacy)
    /// argument to include locations that [`FulfillmentService`](https://shopify.dev/docs/api/admin-graphql/latest/objects/FulfillmentService)
    /// apps manage. Use the [`query`](https://shopify.dev/docs/api/admin-graphql/latest/queries/locations#arguments-query)
    /// argument to filter by location attributes like name, address, and whether
    /// local pickup is enabled.
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
    /// Returns a `Market` resource by ID.
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
    /// Returns a paginated list of
    /// [`Market`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Market)
    /// objects configured for the shop. Markets match buyers based on defined
    /// conditions to deliver customized shopping experiences.
    /// Filter markets by [`MarketType`](https://shopify.dev/docs/api/admin-graphql/latest/enums/MarketType) and [`MarketStatus`](https://shopify.dev/docs/api/admin-graphql/latest/enums/MarketStatus),
    /// search by name, and control sort order. Retrieve market configurations including [`MarketCurrencySettings`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MarketCurrencySettings), [`MarketWebPresence`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MarketWebPresence) objects, and [`MarketConditions`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MarketConditions).
    /// Learn more about [Shopify Markets](https://shopify.dev/docs/apps/build/markets).
    /// </summary>
    [JsonPropertyName("markets")]
    public MarketConnection? markets { get; set; } = null;

    /// <summary>
    /// The resolved values for a buyer signal.
    /// </summary>
    [JsonPropertyName("marketsResolvedValues")]
    public MarketsResolvedValues? marketsResolvedValues { get; set; } = null;

    /// <summary>
    /// Returns a `Menu` resource by ID.
    /// </summary>
    [JsonPropertyName("menu")]
    public Menu? menu { get; set; } = null;

    /// <summary>
    /// Retrieves navigation menus. Menus organize content into hierarchical
    /// navigation structures that merchants can display in the online store (for
    /// example, in headers, footers, and sidebars) and customer accounts.
    /// Each [`Menu`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Menu)
    /// contains a handle for identification, a title for display, and a collection of [`MenuItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MenuItem)
    /// objects that can be nested up to 3 levels deep. Default menus have protected
    /// handles that can't be modified.
    /// </summary>
    [JsonPropertyName("menus")]
    public MenuConnection? menus { get; set; } = null;

    /// <summary>
    /// Retrieves a [`MetafieldDefinition`](https://shopify.dev/docs/api/admin-graphql/current/objects/MetafieldDefinition) by its identifier. You can identify a definition using either its owner type,
    /// namespace, and key, or its global ID.
    /// Use this query to inspect a definition's configuration, including its data
    /// type, validations, access settings, and the count of [metafields](https://shopify.dev/docs/api/admin-graphql/current/objects/Metafield) using it.
    /// </summary>
    [JsonPropertyName("metafieldDefinition")]
    public MetafieldDefinition? metafieldDefinition { get; set; } = null;

    /// <summary>
    /// Returns a list of metafield definitions.
    /// </summary>
    [JsonPropertyName("metafieldDefinitions")]
    public MetafieldDefinitionConnection? metafieldDefinitions { get; set; } = null;

    /// <summary>
    /// The available metafield types that you can use when creating [`MetafieldDefinition`](https://shopify.dev/docs/api/admin-graphql/current/objects/MetafieldDefinition)
    /// objects. Each type specifies what kind of data it stores (such as boolean,
    /// color, date, or references), its category, and which validations it supports.
    /// For a list of supported types and their capabilities, refer to the [metafield
    /// types documentation](https://shopify.dev/docs/apps/metafields/types).
    /// </summary>
    [JsonPropertyName("metafieldDefinitionTypes")]
    public ICollection<MetafieldDefinitionType>? metafieldDefinitionTypes { get; set; } = null;

    /// <summary>
    /// Retrieves a single [`Metaobject`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Metaobject)
    /// by its global ID. [Metaobjects](https://shopify.dev/docs/apps/build/custom-data#what-are-metaobjects)
    /// store custom structured data based on defined schemas. The returned metaobject
    /// includes its fields with values, display name, handle, and associated metadata
    /// like update timestamps and capabilities.
    /// </summary>
    [JsonPropertyName("metaobject")]
    public Metaobject? metaobject { get; set; } = null;

    /// <summary>
    /// Retrieves a [`Metaobject`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Metaobject) by its handle and type. Handles are unique identifiers within a metaobject type.
    /// </summary>
    [JsonPropertyName("metaobjectByHandle")]
    public Metaobject? metaobjectByHandle { get; set; } = null;

    /// <summary>
    /// Retrieves a [`MetaobjectDefinition`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MetaobjectDefinition) by its global ID. Metaobject definitions provide the structure and fields for metaobjects.
    /// The definition includes field configurations, access settings, display
    /// preferences, and capabilities that determine how [metaobjects](https://shopify.dev/docs/api/admin-graphql/latest/objects/Metaobject)
    /// of this type behave across the Shopify platform.
    /// </summary>
    [JsonPropertyName("metaobjectDefinition")]
    public MetaobjectDefinition? metaobjectDefinition { get; set; } = null;

    /// <summary>
    /// Retrieves a [`MetaobjectDefinition`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MetaobjectDefinition) by its type. The type serves as a unique identifier that distinguishes one
    /// metaobject definition from another.
    /// </summary>
    [JsonPropertyName("metaobjectDefinitionByType")]
    public MetaobjectDefinition? metaobjectDefinitionByType { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of all [`MetaobjectDefinition`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MetaobjectDefinition)
    /// objects configured for the store. Metaobject definitions provide the schema
    /// for creating custom data structures composed of individual fields. Each
    /// definition specifies the field types, access permissions, and capabilities for [`Metaobject`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Metaobject)
    /// entries of that type. Use this query to discover available metaobject types
    /// before creating or querying metaobject entries.
    /// Learn more about [managing metaobjects](https://shopify.dev/docs/apps/build/custom-data/metaobjects/manage-metaobjects).
    /// </summary>
    [JsonPropertyName("metaobjectDefinitions")]
    public MetaobjectDefinitionConnection? metaobjectDefinitions { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of [`Metaobject`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Metaobject)
    /// entries for a specific type. Metaobjects are custom data structures that
    /// extend Shopify's data model with merchant or app-specific data types.
    /// Filter results using the query parameter with a search syntax for metaobject
    /// fields. Use `fields.{key}:{value}` to filter by field values, supporting any
    /// field previously marked as filterable. The `sortKey` parameter accepts `id`,
    /// `type`, `updated_at`, or `display_name` to control result ordering.
    /// Learn more about [querying metaobjects by field value](https://shopify.dev/docs/apps/build/custom-data/metafields/query-by-metafield-value).
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
    /// Returns a `OrderEditSession` resource by ID.
    /// </summary>
    [JsonPropertyName("orderEditSession")]
    public OrderEditSession? orderEditSession { get; set; } = null;

    /// <summary>
    /// Retrieves the status of a deferred payment by its payment reference ID. Use
    /// this query to monitor the processing status of payments that are initiated
    /// through payment mutations. Deferred payments are called [payment
    /// terms](https://shopify.dev/docs/apps/build/checkout/payments/payment-terms) in the API.
    /// The query returns an [`OrderPaymentStatus`](https://shopify.dev/docs/api/admin-graphql/latest/objects/OrderPaymentStatus)
    /// object that includes the current payment status, any error messages, and
    /// associated transactions. Poll this query to track [asynchronous payment
    /// processing](https://shopify.dev/docs/apps/build/payments/processing) after
    /// initiating a deferred payment.
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
    /// [sorting](https://shopify.dev/docs/api/admin-graphql/latest/queries/orders#arguments-sortKey), and [filtering](https://shopify.dev/docs/api/admin-graphql/latest/queries/orders#arguments-query).
    /// </summary>
    [JsonPropertyName("orders")]
    public OrderConnection? orders { get; set; } = null;

    /// <summary>
    /// Returns [saved searches](https://shopify.dev/docs/api/admin-graphql/latest/objects/SavedSearch) for orders in the shop. Saved searches store search queries with their filters
    /// and search terms.
    /// </summary>
    [JsonPropertyName("orderSavedSearches")]
    public SavedSearchConnection? orderSavedSearches { get; set; } = null;

    /// <summary>
    /// Returns the number of
    /// [orders](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order) in
    /// the shop. You can filter orders using [search
    /// syntax](https://shopify.dev/docs/api/usage/search-syntax) or a [`SavedSearch`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SavedSearch),
    /// and set a maximum count limit to control query performance.
    /// Use the [`query`](https://shopify.dev/docs/api/admin-graphql/latest/queries/ordersCount#arguments-query) argument to filter the count by criteria like order status, financial state,
    /// or fulfillment status. The response includes both the count value and its
    /// precision, indicating whether the count is exact or an estimate.
    /// > Note:
    /// > The count is limited to 10,000 orders by default. Use the [`limit`](https://shopify.dev/docs/api/admin-graphql/latest/queries/ordersCount#arguments-limit)
    /// argument to adjust this value, or pass `null` for no limit. Limited to a
    /// maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("ordersCount")]
    public Count? ordersCount { get; set; } = null;

    /// <summary>
    /// Returns a `Page` resource by ID.
    /// </summary>
    [JsonPropertyName("page")]
    public Page? page { get; set; } = null;

    /// <summary>
    /// A paginated list of pages from the online store.
    /// [`Page`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Page)
    /// objects are content pages that merchants create to provide information to
    /// customers, such as "About Us", "Contact", or policy pages.
    /// The query supports filtering with a [search
    /// query](https://shopify.dev/docs/api/usage/search-syntax) and sorting by
    /// various criteria. Advanced filtering is available through saved searches using the [`savedSearchId`](https://shopify.dev/docs/api/admin-graphql/latest/queries/pages#arguments-savedSearchId) argument.
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
    /// Returns a [`PriceList`](https://shopify.dev/docs/api/admin-graphql/latest/objects/PriceList) by ID. You can use price lists to specify either fixed prices or adjusted
    /// relative prices that override initial
    /// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) prices.
    /// Price lists enable contextual pricing for the [`Catalog`](https://shopify.dev/docs/api/admin-graphql/latest/interfaces/Catalog)
    /// they are associated to. Each price list can define fixed prices for specific [`ProductVariant`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant)
    /// objects or percentage-based adjustments relative to other prices.
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
    /// Retrieves a [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
    /// using its handle. A handle is a unique, URL-friendly string that Shopify
    /// automatically generates from the product's title.
    /// Returns `null` if no product exists with the specified handle.
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
    /// Retrieves product resource feedback for the currently authenticated app,
    /// providing insights into product data quality, completeness, and optimization
    /// opportunities. This feedback helps apps guide merchants toward better product
    /// listings and improved store performance.
    /// For example, an SEO app might receive feedback indicating that certain
    /// products lack meta descriptions or have suboptimal titles, enabling the app to
    /// provide specific recommendations for improving search visibility and
    /// conversion rates.
    /// Use `ProductResourceFeedback` to:
    /// - Display product optimization recommendations to merchants
    /// - Identify data quality issues across product catalogs
    /// - Build product improvement workflows and guided experiences
    /// - Track progress on product listing completeness and quality
    /// - Implement automated product auditing and scoring systems
    /// - Generate reports on catalog health and optimization opportunities
    /// - Provide contextual suggestions within product editing interfaces
    /// The feedback system evaluates products against various criteria including SEO
    /// best practices, required fields, media quality, and sales channel
    /// requirements. Each feedback item includes specific details about the issue,
    /// suggested improvements, and priority levels.
    /// Feedback is app-specific and reflects the particular focus of your application
    /// - marketing apps receive different insights than inventory management apps.
    /// The system continuously updates as merchants make changes, providing real-time
    /// guidance for product optimization.
    /// This resource is particularly valuable for apps that help merchants improve
    /// their product listings, optimize for search engines, or enhance their overall
    /// catalog quality. The feedback enables proactive suggestions rather than
    /// reactive problem-solving.
    /// Learn more about [product optimization](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product).
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
    /// Returns tags added to
    /// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
    /// objects in the shop. Provides a paginated list of tag strings.
    /// The maximum page size is 5000 tags per request. Tags are returned as simple
    /// strings through a [`StringConnection`](https://shopify.dev/docs/api/admin-graphql/latest/objects/StringConnection).
    /// The maximum page size is 5000.
    /// </summary>
    [JsonPropertyName("productTags")]
    public StringConnection? productTags { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of product types assigned to
    /// [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
    /// in the store. The maximum page size is 1000.
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
    /// Retrieves a [`Publication`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication) by [`ID`](https://shopify.dev/docs/api/usage/gids).
    /// Returns `null` if the publication doesn't exist.
    /// </summary>
    [JsonPropertyName("publication")]
    public Publication? publication { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of [`Publication`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// Filter publications by [`CatalogType`](https://shopify.dev/docs/api/admin-graphql/latest/enums/CatalogType).
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
    /// Returns a `ReturnableFulfillment` resource by ID.
    /// </summary>
    [JsonPropertyName("returnableFulfillment")]
    public ReturnableFulfillment? returnableFulfillment { get; set; } = null;

    /// <summary>
    /// List of returnable fulfillments.
    /// </summary>
    [JsonPropertyName("returnableFulfillments")]
    public ReturnableFulfillmentConnection? returnableFulfillments { get; set; } = null;

    /// <summary>
    /// Calculates the financial outcome of a
    /// [`Return`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Return)
    /// without creating it. Use this query to preview return costs before initiating
    /// the actual return process.
    /// The calculation provides detailed breakdowns of refund amounts, taxes, [`RestockingFee`](https://shopify.dev/docs/api/admin-graphql/latest/objects/RestockingFee)
    /// charges, return shipping fees, and order-level discount adjustments based on the [`FulfillmentLineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/FulfillmentLineItem)
    /// objects that customers select for return.
    /// Learn more about building for [return management](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/build-return-management).
    /// </summary>
    [JsonPropertyName("returnCalculate")]
    public CalculatedReturn? returnCalculate { get; set; } = null;

    /// <summary>
    /// Returns the full library of available return reason definitions.
    /// Use this query to retrieve the standardized return reasons available for creating returns.
    /// Filter by IDs or handles to get specific definitions.
    /// Only non-deleted reasons should be shown to customers when creating new returns.
    /// Deleted reasons have been replaced with better alternatives and are no longer recommended.
    /// However, they remain valid options and may still appear on existing returns.
    /// </summary>
    [JsonPropertyName("returnReasonDefinitions")]
    public ReturnReasonDefinitionConnection? returnReasonDefinitions { get; set; } = null;

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
    /// Retrieves a customer
    /// [`Segment`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Segment)
    /// by ID. Segments are dynamic groups of customers that meet specific criteria
    /// defined through [ShopifyQL queries](https://shopify.dev/docs/api/shopifyql/segment-query-language-reference).
    /// Use segments for targeted marketing campaigns, analyzing customer behavior, or
    /// creating personalized experiences. Each segment includes its name, creation
    /// date, and the query that defines which [`Customer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)
    /// objects belong to it.
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
    /// Returns a paginated list of
    /// [`Segment`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Segment)
    /// objects for the shop. Segments are dynamic groups of customers that meet
    /// specific criteria defined through [ShopifyQL queries](https://shopify.dev/docs/api/shopifyql/segment-query-language-reference).
    /// You can filter segments by search query and sort them by creation date or
    /// other criteria.
    /// The query supports standard
    /// [pagination](https://shopify.dev/docs/api/usage/pagination-graphql) arguments and returns a [`SegmentConnection`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SegmentConnection)
    /// containing segment details including names, creation dates, and the query
    /// definitions that determine segment membership.
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
    /// Returns a `SellingPlanGroup` resource by ID.
    /// </summary>
    [JsonPropertyName("sellingPlanGroup")]
    public SellingPlanGroup? sellingPlanGroup { get; set; } = null;

    /// <summary>
    /// Retrieves a paginated list of [`SellingPlanGroup`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SellingPlanGroup)
    /// objects that belong to the app making the API call. Selling plan groups are
    /// selling methods like subscriptions, preorders, or other purchase options that
    /// merchants offer to customers.
    /// Each group has one or more [`SellingPlan`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SellingPlan)
    /// objects that define specific billing and delivery schedules, pricing
    /// adjustments, and policies. Use the [`query`](https://shopify.dev/docs/api/admin-graphql/latest/queries/sellingPlanGroups#arguments-query)
    /// argument to search by name or filter results by other criteria.
    /// Learn more about [building selling plans](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/selling-plans).
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
    /// The shop's billing preferences, including the currency for paying for apps and
    /// services. Use this to create [app charges in the merchant's local billing
    /// currency](https://shopify.dev/docs/apps/launch/billing#supported-currencies),
    /// helping them budget their app spend without exposure to exchange rate fluctuations.
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
    /// Returns Shopify Functions owned by the querying API client installed on the
    /// shop. [Functions](https://shopify.dev/docs/apps/build/functions) enable you to customize
    /// Shopify's backend logic at specific points in the commerce loop, such as discounts,
    /// checkout validation, and fulfillment.
    /// You can filter the results by API type to find specific function implementations,
    /// or by whether they provide a merchant configuration interface in the Shopify Admin.
    /// The response includes details about each function's configuration, including its
    /// title, description, API version, and the input query used to provide data to the function logic.
    /// Learn more about [building functions](https://shopify.dev/docs/api/functions).
    /// </summary>
    [JsonPropertyName("shopifyFunctions")]
    public ShopifyFunctionConnection? shopifyFunctions { get; set; } = null;

    /// <summary>
    /// Returns the Shopify Payments account information for the shop. Includes
    /// current balances across all currencies, payout schedules, and bank account
    /// configurations.
    /// The account includes [`ShopifyPaymentsBalanceTransaction`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsBalanceTransaction)
    /// records showing charges, refunds, and adjustments that affect your balance. Also includes [`ShopifyPaymentsDispute`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsDispute) records and [`ShopifyPaymentsPayout`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsPayout)
    /// history between the account and connected [`ShopifyPaymentsBankAccount`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsBankAccount)
    /// configurations.
    /// </summary>
    [JsonPropertyName("shopifyPaymentsAccount")]
    public ShopifyPaymentsAccount? shopifyPaymentsAccount { get; set; } = null;

    /// <summary>
    /// Executes a [ShopifyQL query](https://shopify.dev/docs/apps/build/shopifyql) to
    /// analyze store data and returns results in a tabular format.
    /// The response includes column metadata with names, data types, and display
    /// names, along with the actual data rows. If the query contains syntax errors,
    /// then the response provides parse error messages instead of table data.
    /// Read the [ShopifyQL reference
    /// documentation](https://shopify.dev/docs/api/shopifyql) for more information on
    /// how to write ShopifyQL queries.
    /// </summary>
    [JsonPropertyName("shopifyqlQuery")]
    public ShopifyqlQueryResponse? shopifyqlQuery { get; set; } = null;

    /// <summary>
    /// Returns the locales enabled on a shop. Each locale represents a language for
    /// translations and determines how content displays to customers in different markets.
    /// Use the optional `published` argument to filter for only the locales that are
    /// visible to customers. The response includes the ISO locale code, whether it's
    /// the shop's primary locale, and which [`MarketWebPresence`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MarketWebPresence)
    /// objects use each locale.
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
    /// Retrieves a [staff
    /// member](https://shopify.dev/docs/api/admin-graphql/latest/objects/StaffMember)
    /// by ID. If no ID is provided, the query returns the staff member that's making
    /// the request. A staff member is a user who can access the Shopify admin to
    /// manage store operations.
    /// Provides staff member details such as email, name, and shop owner status. When
    /// querying the current user (with or without an ID), additional [private data](https://shopify.dev/docs/api/admin-graphql/latest/queries/staffMember#returns-StaffMember.fields.privateData)
    /// becomes available.
    /// </summary>
    [JsonPropertyName("staffMember")]
    public StaffMember? staffMember { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of [`StaffMember`](https://shopify.dev/docs/api/admin-graphql/latest/objects/StaffMember)
    /// objects for the shop. Staff members are users who can access the Shopify admin
    /// to manage store operations.
    /// Supports filtering by account type, email, and name, with an option to sort
    /// results. The query returns a [`StaffMemberConnection`](https://shopify.dev/docs/api/admin-graphql/latest/connections/StaffMemberConnection)
    /// for [cursor-based
    /// pagination](https://shopify.dev/docs/api/usage/pagination-graphql).
    /// </summary>
    [JsonPropertyName("staffMembers")]
    public StaffMemberConnection? staffMembers { get; set; } = null;

    /// <summary>
    /// Retrieves preset metafield definition templates for common use cases. Each
    /// template provides a reserved namespace and key combination for specific
    /// purposes like product subtitles, care guides, or ISBN numbers. Use these
    /// templates to create standardized metafields across your store. Filter
    /// templates by constraint status or exclude those you've already activated.
    /// See the [list of standard metafield definitions](https://shopify.dev/docs/apps/build/custom-data/metafields/list-of-standard-definitions)
    /// for available templates.
    /// </summary>
    [JsonPropertyName("standardMetafieldDefinitionTemplates")]
    public StandardMetafieldDefinitionTemplateConnection? standardMetafieldDefinitionTemplates { get; set; } = null;

    /// <summary>
    /// Retrieves a [`StoreCreditAccount`](https://shopify.dev/docs/api/admin-graphql/latest/objects/StoreCreditAccount) by ID. Store credit accounts hold monetary balances that account owners can
    /// use at checkout. The owner is either a [`Customer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer) or a [`CompanyLocation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CompanyLocation).
    /// </summary>
    [JsonPropertyName("storeCreditAccount")]
    public StoreCreditAccount? storeCreditAccount { get; set; } = null;

    /// <summary>
    /// Returns a `SubscriptionBillingAttempt` resource by ID.
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
    /// Retrieves a [`SubscriptionContract`](https://shopify.dev/docs/api/customer/latest/objects/SubscriptionContract) by ID.
    /// The contract tracks the subscription's lifecycle through various [statuses](https://shopify.dev/docs/api/admin-graphql/latest/queries/subscriptionContract#returns-SubscriptionContract.fields.status),
    /// and links to related billing attempts, generated
    /// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order)
    /// objects, and the customer's [`CustomerPaymentMethod`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CustomerPaymentMethod).
    /// </summary>
    [JsonPropertyName("subscriptionContract")]
    public SubscriptionContract? subscriptionContract { get; set; } = null;

    /// <summary>
    /// Returns a [`SubscriptionContractConnection`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SubscriptionContractConnection) containing [subscription contracts](https://shopify.dev/docs/api/customer/latest/objects/SubscriptionContract).
    /// Subscription contracts are agreements between [customers](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)
    /// and merchants for recurring purchases with defined billing and delivery schedules.
    /// Filter results with the [`query`](https://shopify.dev/docs/api/admin-graphql/latest/queries/subscriptionContracts#arguments-query)
    /// argument. You can paginate results using standard [cursor-based
    /// pagination](https://shopify.dev/docs/api/usage/pagination-graphql).
    /// </summary>
    [JsonPropertyName("subscriptionContracts")]
    public SubscriptionContractConnection? subscriptionContracts { get; set; } = null;

    /// <summary>
    /// Returns a Subscription Draft resource by ID.
    /// </summary>
    [JsonPropertyName("subscriptionDraft")]
    public SubscriptionDraft? subscriptionDraft { get; set; } = null;

    /// <summary>
    /// Access to Shopify's [standardized product taxonomy](https://shopify.github.io/product-taxonomy/releases/unstable/?categoryId=sg-4-17-2-17)
    /// for categorizing products. The [`Taxonomy`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Taxonomy)
    /// organizes products into a hierarchical tree structure with categories,
    /// attributes, and values.
    /// Query categories using search terms, or navigate the hierarchy by requesting
    /// children, siblings, or descendants of specific categories. Each [`TaxonomyCategory`](https://shopify.dev/docs/api/admin-graphql/latest/objects/TaxonomyCategory)
    /// includes its position in the tree, parent-child relationships, and associated
    /// attributes for that product category.
    /// </summary>
    [JsonPropertyName("taxonomy")]
    public Taxonomy? taxonomy { get; set; } = null;

    /// <summary>
    /// Transactions representing a movement of money between customers and the shop.
    /// Each transaction records the amount, payment method, processing details, and the associated
    /// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order).
    /// Positive amounts indicate customer payments to the merchant. Negative amounts
    /// represent refunds from the merchant to the customer. Use the [`query`](https://shopify.dev/docs/api/admin-graphql/latest/queries/tenderTransactions#arguments-query)
    /// parameter to filter transactions by attributes such as transaction ID,
    /// processing date, and point-of-sale device ID.
    /// </summary>
    [JsonPropertyName("tenderTransactions")]
    public TenderTransactionConnection? tenderTransactions { get; set; } = null;

    /// <summary>
    /// Returns an [`OnlineStoreTheme`](https://shopify.dev/docs/api/admin-graphql/latest/objects/OnlineStoreTheme) by its ID. Use this query to retrieve theme metadata and access the theme's [`files`](https://shopify.dev/docs/api/admin-graphql/latest/queries/theme#returns-OnlineStoreTheme.fields.files),
    /// which include templates, assets, [translations](https://shopify.dev/docs/api/admin-graphql/latest/objects/OnlineStoreTheme#field-published_translations),
    /// and configuration files.
    /// </summary>
    [JsonPropertyName("theme")]
    public OnlineStoreTheme? theme { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of [`OnlineStoreTheme`](https://shopify.dev/docs/api/admin-graphql/latest/objects/OnlineStoreTheme)
    /// objects for the online store. Themes control the appearance and layout of the storefront.
    /// You can filter themes by [`role`](https://shopify.dev/docs/api/admin-graphql/latest/queries/themes#arguments-roles)
    /// to find specific theme types, such as `MAIN` for the published theme and
    /// `UNPUBLISHED` for draft themes.
    /// </summary>
    [JsonPropertyName("themes")]
    public OnlineStoreThemeConnection? themes { get; set; } = null;

    /// <summary>
    /// Retrieves a resource that has translatable fields. Returns the resource's [`Translation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Translation)
    /// objects for different locales and markets, along with the original [`TranslatableContent`](https://shopify.dev/docs/api/admin-graphql/latest/objects/TranslatableContent)
    /// and digest values needed to register new translations. Provides access to
    /// existing translations, translatable content with digest hashes for translation
    /// registration, and nested translatable resources like [`ProductVariant`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant) objects or [`Metafield`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Metafield) objects.
    /// Learn more about [managing translated content](https://shopify.dev/docs/apps/build/markets/manage-translated-content).
    /// </summary>
    [JsonPropertyName("translatableResource")]
    public TranslatableResource? translatableResource { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of [`TranslatableResource`](https://shopify.dev/docs/api/admin-graphql/latest/objects/TranslatableResource)
    /// objects for a specific resource type. Each resource provides translatable
    /// content and digest values needed for the [`translationsRegister`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/translationsRegister) mutation.
    /// Learn more about [managing translated content](https://shopify.dev/docs/apps/build/markets/manage-translated-content).
    ///         Learn more about [managing translated content](https://shopify.dev/docs/apps/build/markets/manage-translated-content).
    /// </summary>
    [JsonPropertyName("translatableResources")]
    public TranslatableResourceConnection? translatableResources { get; set; } = null;

    /// <summary>
    /// Returns a paginated list of [`TranslatableResource`](https://shopify.dev/docs/api/admin-graphql/latest/objects/TranslatableResource)
    /// objects for the specified resource IDs. Each resource provides translatable
    /// content and digest values needed for the [`translationsRegister`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/translationsRegister) mutation.
    /// Learn more about [managing translated content](https://shopify.dev/docs/apps/build/markets/manage-translated-content).
    /// </summary>
    [JsonPropertyName("translatableResourcesByIds")]
    public TranslatableResourceConnection? translatableResourcesByIds { get; set; } = null;

    /// <summary>
    /// Returns a `UrlRedirect` resource by ID.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public UrlRedirect? urlRedirect { get; set; } = null;

    /// <summary>
    /// Returns a `UrlRedirectImport` resource by ID.
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
    /// Retrieves a paginated list of webhook subscriptions created using the API for the current app and shop.
    /// > Note: Returns only shop-scoped subscriptions, not app-scoped subscriptions configured in TOML files.
    /// Subscription details include event topics, endpoint URIs, filtering rules,
    /// field inclusion settings, and metafield namespace permissions. Results support
    /// cursor-based pagination that you can filter by topic, format, or custom search criteria.
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