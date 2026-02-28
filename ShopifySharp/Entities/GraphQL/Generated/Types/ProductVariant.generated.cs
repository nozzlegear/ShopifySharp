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
/// The `ProductVariant` object represents a version of a
/// [product](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
/// that comes in more than one [option](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOption),
/// such as size or color. For example, if a merchant sells t-shirts with options for size and color, then a small,
/// blue t-shirt would be one product variant and a large, blue t-shirt would be another.
/// Use the `ProductVariant` object to manage the full lifecycle and configuration of a product's variants. Common
/// use cases for using the `ProductVariant` object include:
/// - Tracking inventory for each variant
/// - Setting unique prices for each variant
/// - Assigning barcodes and SKUs to connect variants to fulfillment services
/// - Attaching variant-specific images and media
/// - Setting delivery and tax requirements
/// - Supporting product bundles, subscriptions, and selling plans
/// A `ProductVariant` is associated with a parent
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) object.
/// `ProductVariant` serves as the central link between a product's merchandising configuration, inventory,
/// pricing, fulfillment, and sales channels within the GraphQL Admin API schema. Each variant
/// can reference other GraphQL types such as:
/// - [`InventoryItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryItem): Used for inventory tracking
/// - [`Image`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Image): Used for variant-specific images
/// - [`SellingPlanGroup`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SellingPlanGroup): Used for subscriptions and selling plans
/// Learn more about [Shopify's product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/product-model-components).
/// </summary>
public record ProductVariant : IGraphQLUnionCase, IGraphQLObject, IHasEvents, IHasMetafieldDefinitions, IHasMetafields, IHasPublishedTranslations, ILegacyInteroperability, INavigable, INode
{
    /// <summary>
    /// Whether the product variant is available for sale.
    /// </summary>
    [JsonPropertyName("availableForSale")]
    public bool? availableForSale { get; set; } = null;

    /// <summary>
    /// The value of the barcode associated with the product.
    /// </summary>
    [JsonPropertyName("barcode")]
    public string? barcode { get; set; } = null;

    /// <summary>
    /// The compare-at price of the variant in the default shop currency.
    /// </summary>
    [JsonPropertyName("compareAtPrice")]
    public decimal? compareAtPrice { get; set; } = null;

    /// <summary>
    /// The pricing that applies for a customer in a given context. As of API version
    /// 2025-04, only active markets are considered in the price resolution.
    /// </summary>
    [JsonPropertyName("contextualPricing")]
    public ProductVariantContextualPricing? contextualPricing { get; set; } = null;

    /// <summary>
    /// The date and time when the variant was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// A default [cursor](https://shopify.dev/api/usage/pagination-graphql) that
    /// returns the single next record, sorted ascending by ID.
    /// </summary>
    [JsonPropertyName("defaultCursor")]
    public string? defaultCursor { get; set; } = null;

    /// <summary>
    /// The [delivery profile](https://shopify.dev/api/admin-graphql/latest/objects/DeliveryProfile) for the variant.
    /// </summary>
    [JsonPropertyName("deliveryProfile")]
    public DeliveryProfile? deliveryProfile { get; set; } = null;

    /// <summary>
    /// Display name of the variant, based on product's title + variant's title.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// The paginated list of events associated with the host subject.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The featured image for the variant.
    /// </summary>
    [JsonPropertyName("image")]
    [Obsolete("Use `media` instead.")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// The inventory item, which is used to query for inventory information.
    /// </summary>
    [JsonPropertyName("inventoryItem")]
    public InventoryItem? inventoryItem { get; set; } = null;

    /// <summary>
    /// Whether customers are allowed to place an order for the product variant when it's out of stock.
    /// </summary>
    [JsonPropertyName("inventoryPolicy")]
    public ProductVariantInventoryPolicy? inventoryPolicy { get; set; } = null;

    /// <summary>
    /// The total sellable quantity of the variant.
    /// </summary>
    [JsonPropertyName("inventoryQuantity")]
    public int? inventoryQuantity { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The media associated with the product variant.
    /// </summary>
    [JsonPropertyName("media")]
    public MediaConnection? media { get; set; } = null;

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
    /// The order of the product variant in the list of product variants. The first position in the list is 1.
    /// </summary>
    [JsonPropertyName("position")]
    public int? position { get; set; } = null;

    /// <summary>
    /// List of prices and compare-at prices in the presentment currencies for this shop.
    /// </summary>
    [JsonPropertyName("presentmentPrices")]
    [Obsolete("Use `contextualPricing` instead.")]
    public ProductVariantPricePairConnection? presentmentPrices { get; set; } = null;

    /// <summary>
    /// The price of the product variant in the default shop currency.
    /// </summary>
    [JsonPropertyName("price")]
    public decimal? price { get; set; } = null;

    /// <summary>
    /// The product that this variant belongs to.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// A list of products that have product variants that contain this variant as a product component.
    /// </summary>
    [JsonPropertyName("productParents")]
    public ProductConnection? productParents { get; set; } = null;

    /// <summary>
    /// A list of the product variant components.
    /// </summary>
    [JsonPropertyName("productVariantComponents")]
    public ProductVariantComponentConnection? productVariantComponents { get; set; } = null;

    /// <summary>
    /// Whether a product variant requires components. The default value is `false`.
    /// If `true`, then the product variant can only be purchased as a parent bundle with components and it will be omitted
    /// from channels that don't support bundles.
    /// </summary>
    [JsonPropertyName("requiresComponents")]
    public bool? requiresComponents { get; set; } = null;

    /// <summary>
    /// List of product options applied to the variant.
    /// </summary>
    [JsonPropertyName("selectedOptions")]
    public ICollection<SelectedOption>? selectedOptions { get; set; } = null;

    /// <summary>
    /// The total sellable quantity of the variant for online channels.
    /// This doesn't represent the total available inventory or capture
    /// [limitations based on customer location](https://help.shopify.com/manual/markets/inventory_and_fulfillment).
    /// </summary>
    [JsonPropertyName("sellableOnlineQuantity")]
    public int? sellableOnlineQuantity { get; set; } = null;

    /// <summary>
    /// Count of selling plan groups associated with the product variant.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupCount")]
    [Obsolete("Use `sellingPlanGroupsCount` instead.")]
    public int? sellingPlanGroupCount { get; set; } = null;

    /// <summary>
    /// A list of all selling plan groups defined in the current shop associated with the product variant.
    /// </summary>
    [JsonPropertyName("sellingPlanGroups")]
    public SellingPlanGroupConnection? sellingPlanGroups { get; set; } = null;

    /// <summary>
    /// Count of selling plan groups associated with the product variant.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupsCount")]
    public Count? sellingPlanGroupsCount { get; set; } = null;

    /// <summary>
    /// Whether to show the unit price for this product variant.
    /// </summary>
    [JsonPropertyName("showUnitPrice")]
    public bool? showUnitPrice { get; set; } = null;

    /// <summary>
    /// A case-sensitive identifier for the product variant in the shop.
    /// Required in order to connect to a fulfillment service.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

    /// <summary>
    /// The Storefront GraphQL API ID of the `ProductVariant`.
    /// The Storefront GraphQL API will no longer return Base64 encoded IDs to match
    /// the behavior of the Admin GraphQL API. Therefore, you can safely use the `id`
    /// field's value instead.
    /// </summary>
    [JsonPropertyName("storefrontId")]
    [Obsolete("Use `id` instead.")]
    public string? storefrontId { get; set; } = null;

    /// <summary>
    /// Whether a tax is charged when the product variant is sold.
    /// </summary>
    [JsonPropertyName("taxable")]
    public bool? taxable { get; set; } = null;

    /// <summary>
    /// Avalara tax code for the product variant. Applies only to the stores that have the Avalara AvaTax app installed.
    /// </summary>
    [JsonPropertyName("taxCode")]
    [Obsolete("This field should no longer be used in new integrations. This field will not be available in future API versions.")]
    public string? taxCode { get; set; } = null;

    /// <summary>
    /// The title of the product variant.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The unit price value for the variant based on the variant measurement.
    /// </summary>
    [JsonPropertyName("unitPrice")]
    public MoneyV2? unitPrice { get; set; } = null;

    /// <summary>
    /// The unit price measurement for the variant.
    /// </summary>
    [JsonPropertyName("unitPriceMeasurement")]
    public UnitPriceMeasurement? unitPriceMeasurement { get; set; } = null;

    /// <summary>
    /// The date and time (ISO 8601 format) when the product variant was last modified.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}