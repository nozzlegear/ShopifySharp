#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The `Product` object lets you manage products in a merchant’s store.
/// Products are the goods and services that merchants offer to customers. They can
/// include various details such as title, description, price, images, and options
/// such as size or color.
/// You can use [product variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/productvariant)
/// to create or update different versions of the same product.
/// You can also add or update product [media](https://shopify.dev/docs/api/admin-graphql/latest/interfaces/media).
/// Products can be organized by grouping them into a [collection](https://shopify.dev/docs/api/admin-graphql/latest/objects/collection).
/// Learn more about working with [Shopify's product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/product-model-components),
/// including limitations and considerations.
/// </summary>
public record Product : CommentEventEmbed, IGraphQLUnionCase, IGraphQLObject, IHasEvents, IHasMetafieldDefinitions, IHasMetafields, IHasPublishedTranslations, ILegacyInteroperability, INavigable, INode, IOnlineStorePreviewable, IPublishable
{
    /// <summary>
    /// The number of
    /// [publications](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
    /// that a resource is published to, without
    /// [feedback errors](https://shopify.dev/docs/api/admin-graphql/latest/objects/ResourceFeedback).
    /// </summary>
    [JsonPropertyName("availablePublicationsCount")]
    public Count? availablePublicationsCount { get; set; } = null;

    /// <summary>
    /// The description of the product, with
    /// HTML tags. For example, the description might include
    /// bold `<strong></strong>` and italic `<i></i>` text.
    /// </summary>
    [JsonPropertyName("bodyHtml")]
    [Obsolete("Use `descriptionHtml` instead.")]
    public string? bodyHtml { get; set; } = null;

    /// <summary>
    /// A list of [components](https://shopify.dev/docs/apps/build/product-merchandising/bundles/add-product-fixed-bundle)
    /// that are associated with a product in a bundle.
    /// </summary>
    [JsonPropertyName("bundleComponents")]
    public ProductBundleComponentConnection? bundleComponents { get; set; } = null;

    /// <summary>
    /// The category of a product
    /// from [Shopify's Standard Product Taxonomy](https://shopify.github.io/product-taxonomy/releases/unstable/?categoryId=sg-4-17-2-17).
    /// </summary>
    [JsonPropertyName("category")]
    public TaxonomyCategory? category { get; set; } = null;

    /// <summary>
    /// A list of [collections](https://shopify.dev/docs/api/admin-graphql/latest/objects/Collection)
    /// that include the product.
    /// </summary>
    [JsonPropertyName("collections")]
    public CollectionConnection? collections { get; set; } = null;

    /// <summary>
    /// A special product type that combines separate products from a store into a single product listing.
    /// [Combined listings](https://shopify.dev/apps/build/product-merchandising/combined-listings) are connected
    /// by a shared option, such as color, model, or dimension.
    /// </summary>
    [JsonPropertyName("combinedListing")]
    public CombinedListing? combinedListing { get; set; } = null;

    /// <summary>
    /// The [role of the product](https://shopify.dev/docs/apps/build/product-merchandising/combined-listings/build-for-combined-listings)
    /// in a combined listing.
    /// If `null`, then the product isn't part of any combined listing.
    /// </summary>
    [JsonPropertyName("combinedListingRole")]
    public CombinedListingsRole? combinedListingRole { get; set; } = null;

    /// <summary>
    /// The [compare-at price range](https://help.shopify.com/manual/products/details/product-pricing/sale-pricing)
    /// of the product in the shop's default currency.
    /// </summary>
    [JsonPropertyName("compareAtPriceRange")]
    public ProductCompareAtPriceRange? compareAtPriceRange { get; set; } = null;

    /// <summary>
    /// The pricing that applies to a customer in a specific context. For example, a
    /// price might vary depending on the customer's location. Only active markets are
    /// considered in the price resolution.
    /// </summary>
    [JsonPropertyName("contextualPricing")]
    public ProductContextualPricing? contextualPricing { get; set; } = null;

    /// <summary>
    /// The date and time when the product was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The custom product type specified by the merchant.
    /// </summary>
    [JsonPropertyName("customProductType")]
    [Obsolete("Use `productType` instead.")]
    public string? customProductType { get; set; } = null;

    /// <summary>
    /// A default [cursor](https://shopify.dev/api/usage/pagination-graphql) that
    /// returns the single next record, sorted ascending by ID.
    /// </summary>
    [JsonPropertyName("defaultCursor")]
    public string? defaultCursor { get; set; } = null;

    /// <summary>
    /// A single-line description of the product,
    /// with [HTML tags](https://developer.mozilla.org/en-US/docs/Web/HTML) removed.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The description of the product, with
    /// HTML tags. For example, the description might include
    /// bold `<strong></strong>` and italic `<i></i>` text.
    /// </summary>
    [JsonPropertyName("descriptionHtml")]
    public string? descriptionHtml { get; set; } = null;

    /// <summary>
    /// Stripped description of the product, single line with HTML tags removed.
    /// Truncated to 60 characters.
    /// </summary>
    [JsonPropertyName("descriptionPlainSummary")]
    [Obsolete("Use `description` instead.")]
    public string? descriptionPlainSummary { get; set; } = null;

    /// <summary>
    /// The paginated list of events associated with the host subject.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// The featured image for the product.
    /// </summary>
    [JsonPropertyName("featuredImage")]
    [Obsolete("Use `featuredMedia` instead.")]
    public Image? featuredImage { get; set; } = null;

    /// <summary>
    /// The featured [media](https://shopify.dev/docs/apps/build/online-store/product-media)
    /// associated with the product.
    /// </summary>
    [JsonPropertyName("featuredMedia")]
    public IMedia? featuredMedia { get; set; } = null;

    /// <summary>
    /// The information that lets merchants know what steps they need to take
    /// to make sure that the app is set up correctly.
    /// For example, if a merchant hasn't set up a product correctly in the app,
    /// then the feedback might include a message that says "You need to add a price
    /// to this product".
    /// </summary>
    [JsonPropertyName("feedback")]
    public ResourceFeedback? feedback { get; set; } = null;

    /// <summary>
    /// The [theme template](https://shopify.dev/docs/storefronts/themes/architecture/templates)
    /// that's used when customers view the gift card in a store.
    /// </summary>
    [JsonPropertyName("giftCardTemplateSuffix")]
    public string? giftCardTemplateSuffix { get; set; } = null;

    /// <summary>
    /// A unique, human-readable string of the product's title. A handle can contain
    /// letters, hyphens (`-`), and numbers, but no spaces.
    /// The handle is used in the online store URL for the product.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Whether the product has only a single variant with the default option and value.
    /// </summary>
    [JsonPropertyName("hasOnlyDefaultVariant")]
    public bool? hasOnlyDefaultVariant { get; set; } = null;

    /// <summary>
    /// Whether the product has variants that are out of stock.
    /// </summary>
    [JsonPropertyName("hasOutOfStockVariants")]
    public bool? hasOutOfStockVariants { get; set; } = null;

    /// <summary>
    /// Whether at least one of the product variants requires
    /// [bundle components](https://shopify.dev/docs/apps/build/product-merchandising/bundles/add-product-fixed-bundle).
    /// Learn more about
    /// [store eligibility for bundles](https://shopify.dev/docs/apps/build/product-merchandising/bundles#store-eligibility).
    /// </summary>
    [JsonPropertyName("hasVariantsThatRequiresComponents")]
    public bool? hasVariantsThatRequiresComponents { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The images associated with the product.
    /// </summary>
    [JsonPropertyName("images")]
    [Obsolete("Use `media` instead.")]
    public ImageConnection? images { get; set; } = null;

    /// <summary>
    /// Whether the product
    /// is in a specified
    /// [collection](https://shopify.dev/docs/api/admin-graphql/latest/objects/collection).
    /// </summary>
    [JsonPropertyName("inCollection")]
    public bool? inCollection { get; set; } = null;

    /// <summary>
    /// Whether the product is a gift card.
    /// </summary>
    [JsonPropertyName("isGiftCard")]
    public bool? isGiftCard { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The [media](https://shopify.dev/docs/apps/build/online-store/product-media)
    /// associated with the product. Valid media are images, 3D models, videos.
    /// </summary>
    [JsonPropertyName("media")]
    public MediaConnection? media { get; set; } = null;

    /// <summary>
    /// The total count of [media](https://shopify.dev/docs/apps/build/online-store/product-media)
    /// that's associated with a product.
    /// </summary>
    [JsonPropertyName("mediaCount")]
    public Count? mediaCount { get; set; } = null;

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
    /// The [preview URL](https://help.shopify.com/manual/online-store/setting-up#preview-your-store) for the online store.
    /// </summary>
    [JsonPropertyName("onlineStorePreviewUrl")]
    public string? onlineStorePreviewUrl { get; set; } = null;

    /// <summary>
    /// The product's URL on the online store.
    /// If `null`, then the product isn't published to the online store sales channel.
    /// </summary>
    [JsonPropertyName("onlineStoreUrl")]
    public string? onlineStoreUrl { get; set; } = null;

    /// <summary>
    /// A list of product options. The limit is defined by the
    /// [shop's resource limits for product options](https://shopify.dev/docs/api/admin-graphql/latest/objects/Shop#field-resourcelimits)
    /// (`Shop.resourceLimits.maxProductOptions`).
    /// </summary>
    [JsonPropertyName("options")]
    public ICollection<ProductOption>? options { get; set; } = null;

    /// <summary>
    /// The price range of the product.
    /// </summary>
    [JsonPropertyName("priceRange")]
    [Obsolete("Use `priceRangeV2` instead.")]
    public ProductPriceRange? priceRange { get; set; } = null;

    /// <summary>
    /// The minimum and maximum prices of a product, expressed in decimal numbers.
    /// For example, if the product is priced between $10.00 and $50.00,
    /// then the price range is $10.00 - $50.00.
    /// </summary>
    [JsonPropertyName("priceRangeV2")]
    public ProductPriceRangeV2? priceRangeV2 { get; set; } = null;

    /// <summary>
    /// The product category specified by the merchant.
    /// </summary>
    [JsonPropertyName("productCategory")]
    [Obsolete("Use `category` instead.")]
    public ProductCategory? productCategory { get; set; } = null;

    /// <summary>
    /// A list of products that contain at least one variant associated with
    /// at least one of the current products' variants via group relationship.
    /// </summary>
    [JsonPropertyName("productComponents")]
    public ProductComponentTypeConnection? productComponents { get; set; } = null;

    /// <summary>
    /// A count of unique products that contain at least one variant associated with
    /// at least one of the current products' variants via group relationship.
    /// </summary>
    [JsonPropertyName("productComponentsCount")]
    public Count? productComponentsCount { get; set; } = null;

    /// <summary>
    /// A list of products that has a variant that contains any of this product's variants as a component.
    /// </summary>
    [JsonPropertyName("productParents")]
    public ProductConnection? productParents { get; set; } = null;

    /// <summary>
    /// A list of the channels where the product is published.
    /// </summary>
    [JsonPropertyName("productPublications")]
    [Obsolete("Use `resourcePublications` instead.")]
    public ProductPublicationConnection? productPublications { get; set; } = null;

    /// <summary>
    /// The [product type](https://help.shopify.com/manual/products/details/product-type)
    /// that merchants define.
    /// </summary>
    [JsonPropertyName("productType")]
    public string? productType { get; set; } = null;

    /// <summary>
    /// The number of
    /// [publications](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
    /// that a resource is published to, without
    /// [feedback errors](https://shopify.dev/docs/api/admin-graphql/latest/objects/ResourceFeedback).
    /// </summary>
    [JsonPropertyName("publicationCount")]
    [Obsolete("Use `resourcePublicationsCount` instead.")]
    public int? publicationCount { get; set; } = null;

    /// <summary>
    /// A list of the channels where the product is published.
    /// </summary>
    [JsonPropertyName("publications")]
    [Obsolete("Use `resourcePublications` instead.")]
    public ProductPublicationConnection? publications { get; set; } = null;

    /// <summary>
    /// The date and time when the product was published to the online store.
    /// </summary>
    [JsonPropertyName("publishedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? publishedAt { get; set; } = null;

    /// <summary>
    /// Whether the product is published for a customer only in a specified context.
    /// For example, a product might be published for a customer only in a specific location.
    /// </summary>
    [JsonPropertyName("publishedInContext")]
    public bool? publishedInContext { get; set; } = null;

    /// <summary>
    /// Whether the resource is published to a specific channel.
    /// </summary>
    [JsonPropertyName("publishedOnChannel")]
    [Obsolete("Use `publishedOnPublication` instead.")]
    public bool? publishedOnChannel { get; set; } = null;

    /// <summary>
    /// Whether the resource is published to a
    /// [channel](https://shopify.dev/docs/api/admin-graphql/latest/objects/Channel).
    /// For example, the resource might be published to the online store channel.
    /// </summary>
    [JsonPropertyName("publishedOnCurrentChannel")]
    [Obsolete("Use `publishedOnCurrentPublication` instead.")]
    public bool? publishedOnCurrentChannel { get; set; } = null;

    /// <summary>
    /// Whether the resource is published to the app's
    /// [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// For example, the resource might be published to the app's online store channel.
    /// </summary>
    [JsonPropertyName("publishedOnCurrentPublication")]
    public bool? publishedOnCurrentPublication { get; set; } = null;

    /// <summary>
    /// Whether the resource is published to a specified
    /// [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// </summary>
    [JsonPropertyName("publishedOnPublication")]
    public bool? publishedOnPublication { get; set; } = null;

    /// <summary>
    /// Whether the product can only be purchased with
    /// a [selling plan](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/selling-plans).
    /// Products that are sold on subscription (`requiresSellingPlan: true`) can be updated only for online stores.
    /// If you update a product to be subscription-only (`requiresSellingPlan:false`),
    /// then the product is unpublished from all channels, except the online store.
    /// </summary>
    [JsonPropertyName("requiresSellingPlan")]
    public bool? requiresSellingPlan { get; set; } = null;

    /// <summary>
    /// The resource that's either published or staged to be published to
    /// the [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// </summary>
    [JsonPropertyName("resourcePublicationOnCurrentPublication")]
    public ResourcePublicationV2? resourcePublicationOnCurrentPublication { get; set; } = null;

    /// <summary>
    /// The list of resources that are published to a
    /// [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// </summary>
    [JsonPropertyName("resourcePublications")]
    public ResourcePublicationConnection? resourcePublications { get; set; } = null;

    /// <summary>
    /// The number of
    /// [publications](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
    /// that a resource is published to, without
    /// [feedback errors](https://shopify.dev/docs/api/admin-graphql/latest/objects/ResourceFeedback).
    /// </summary>
    [JsonPropertyName("resourcePublicationsCount")]
    public Count? resourcePublicationsCount { get; set; } = null;

    /// <summary>
    /// The list of resources that are either published or staged to be published to a
    /// [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// </summary>
    [JsonPropertyName("resourcePublicationsV2")]
    public ResourcePublicationV2Connection? resourcePublicationsV2 { get; set; } = null;

    /// <summary>
    /// Whether the merchant can make changes to the product when they
    /// [edit the order](https://shopify.dev/docs/apps/build/orders-fulfillment/order-management-apps/edit-orders)
    /// associated with the product. For example, a merchant might be restricted from changing product details when they
    /// edit an order.
    /// </summary>
    [JsonPropertyName("restrictedForResource")]
    public RestrictedForResource? restrictedForResource { get; set; } = null;

    /// <summary>
    /// A count of [selling plan groups](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/selling-plans/build-a-selling-plan)
    /// that are associated with the product.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupCount")]
    [Obsolete("Use `sellingPlanGroupsCount` instead.")]
    public int? sellingPlanGroupCount { get; set; } = null;

    /// <summary>
    /// A list of all [selling plan groups](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/selling-plans/build-a-selling-plan)
    /// that are associated with the product either directly, or through the product's variants.
    /// </summary>
    [JsonPropertyName("sellingPlanGroups")]
    public SellingPlanGroupConnection? sellingPlanGroups { get; set; } = null;

    /// <summary>
    /// A count of [selling plan groups](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/selling-plans/build-a-selling-plan)
    /// that are associated with the product.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupsCount")]
    public Count? sellingPlanGroupsCount { get; set; } = null;

    /// <summary>
    /// The [SEO title and description](https://help.shopify.com/manual/promoting-marketing/seo/adding-keywords)
    /// that are associated with a product.
    /// </summary>
    [JsonPropertyName("seo")]
    public SEO? seo { get; set; } = null;

    /// <summary>
    /// The standardized product type in the Shopify product taxonomy.
    /// </summary>
    [JsonPropertyName("standardizedProductType")]
    [Obsolete("Use `productCategory` instead.")]
    public StandardizedProductType? standardizedProductType { get; set; } = null;

    /// <summary>
    /// The [product status](https://help.shopify.com/manual/products/details/product-details-page#product-status),
    /// which controls visibility across all sales channels.
    /// </summary>
    [JsonPropertyName("status")]
    public ProductStatus? status { get; set; } = null;

    /// <summary>
    /// The Storefront GraphQL API ID of the `Product`.
    /// The Storefront GraphQL API will no longer return Base64 encoded IDs to match
    /// the behavior of the Admin GraphQL API. Therefore, you can safely use the `id`
    /// field's value instead.
    /// </summary>
    [JsonPropertyName("storefrontId")]
    [Obsolete("Use `id` instead.")]
    public string? storefrontId { get; set; } = null;

    /// <summary>
    /// A comma-separated list of searchable keywords that are
    /// associated with the product. For example, a merchant might apply the `sports`
    /// and `summer` tags to products that are associated with sportwear for summer.
    /// Updating `tags` overwrites
    /// any existing tags that were previously added to the product. To add new tags without overwriting
    /// existing tags, use the [`tagsAdd`](https://shopify.dev/api/admin-graphql/latest/mutations/tagsadd)
    /// mutation.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

    /// <summary>
    /// The [theme template](https://shopify.dev/docs/storefronts/themes/architecture/templates)
    /// that's used when customers view the product in a store.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;

    /// <summary>
    /// The name for the product that displays to customers. The title is used to construct the product's handle.
    /// For example, if a product is titled "Black Sunglasses", then the handle is `black-sunglasses`.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The quantity of inventory that's in stock.
    /// </summary>
    [JsonPropertyName("totalInventory")]
    public int? totalInventory { get; set; } = null;

    /// <summary>
    /// The number of [variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant)
    /// that are associated with the product.
    /// </summary>
    [JsonPropertyName("totalVariants")]
    [Obsolete("Use `variantsCount` instead.")]
    public int? totalVariants { get; set; } = null;

    /// <summary>
    /// Whether [inventory tracking](https://help.shopify.com/manual/products/inventory/getting-started-with-inventory/set-up-inventory-tracking)
    /// has been enabled for the product.
    /// </summary>
    [JsonPropertyName("tracksInventory")]
    public bool? tracksInventory { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The list of channels that the resource is not published to.
    /// </summary>
    [JsonPropertyName("unpublishedChannels")]
    [Obsolete("Use `unpublishedPublications` instead.")]
    public ChannelConnection? unpublishedChannels { get; set; } = null;

    /// <summary>
    /// The list of [publications](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
    /// that the resource isn't published to.
    /// </summary>
    [JsonPropertyName("unpublishedPublications")]
    public PublicationConnection? unpublishedPublications { get; set; } = null;

    /// <summary>
    /// The date and time when the product was last modified.
    /// A product's `updatedAt` value can change for different reasons. For example, if an order
    /// is placed for a product that has inventory tracking set up, then the inventory adjustment
    /// is counted as an update.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;

    /// <summary>
    /// A list of [variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant) associated with the product.
    /// If querying a single product at the root, you can fetch up to 2000 variants.
    /// </summary>
    [JsonPropertyName("variants")]
    public ProductVariantConnection? variants { get; set; } = null;

    /// <summary>
    /// The number of [variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant)
    /// that are associated with the product.
    /// </summary>
    [JsonPropertyName("variantsCount")]
    public Count? variantsCount { get; set; } = null;

    /// <summary>
    /// The name of the product's vendor.
    /// </summary>
    [JsonPropertyName("vendor")]
    public string? vendor { get; set; } = null;
}