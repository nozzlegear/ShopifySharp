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
/// The calculated line item for a draft order.
/// </summary>
public record CalculatedDraftOrderLineItem : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The custom applied discount.
    /// </summary>
    [JsonPropertyName("appliedDiscount")]
    public DraftOrderAppliedDiscount? appliedDiscount { get; set; } = null;

    /// <summary>
    /// The `discountedTotal` divided by `quantity`,
    /// equal to the average value of the line item price per unit after discounts are applied.
    /// This value doesn't include discounts applied to the entire draft order.
    /// </summary>
    [JsonPropertyName("approximateDiscountedUnitPriceSet")]
    public MoneyBag? approximateDiscountedUnitPriceSet { get; set; } = null;

    /// <summary>
    /// The bundle components of the draft order line item.
    /// </summary>
    [JsonPropertyName("bundleComponents")]
    [Obsolete("Use `components` instead.")]
    public ICollection<CalculatedDraftOrderLineItem>? bundleComponents { get; set; } = null;

    /// <summary>
    /// The components of the draft order line item.
    /// </summary>
    [JsonPropertyName("components")]
    public ICollection<CalculatedDraftOrderLineItem>? components { get; set; } = null;

    /// <summary>
    /// Whether the line item is custom (`true`) or contains a product variant (`false`).
    /// </summary>
    [JsonPropertyName("custom")]
    public bool? custom { get; set; } = null;

    /// <summary>
    /// A list of attributes that represent custom features or special requests.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; } = null;

    /// <summary>
    /// The list of additional information (metafields) with the associated types.
    /// </summary>
    [JsonPropertyName("customAttributesV2")]
    public ICollection<TypedAttribute>? customAttributesV2 { get; set; } = null;

    /// <summary>
    /// The total price with discounts applied.
    /// </summary>
    [JsonPropertyName("discountedTotal")]
    public MoneyV2? discountedTotal { get; set; } = null;

    /// <summary>
    /// The total price with discounts applied.
    /// </summary>
    [JsonPropertyName("discountedTotalSet")]
    public MoneyBag? discountedTotalSet { get; set; } = null;

    /// <summary>
    /// The unit price with discounts applied.
    /// </summary>
    [JsonPropertyName("discountedUnitPrice")]
    [Obsolete("Use `approximateDiscountedUnitPriceSet` instead.")]
    public MoneyV2? discountedUnitPrice { get; set; } = null;

    /// <summary>
    /// The unit price with discounts applied.
    /// </summary>
    [JsonPropertyName("discountedUnitPriceSet")]
    [Obsolete("Use `approximateDiscountedUnitPriceSet` instead.")]
    public MoneyBag? discountedUnitPriceSet { get; set; } = null;

    /// <summary>
    /// Name of the service provider who fulfilled the order.
    /// Valid values are either **manual** or the name of the provider.
    /// For example, **amazon**, **shipwire**.
    /// Deleted fulfillment services will return null.
    /// </summary>
    [JsonPropertyName("fulfillmentService")]
    public FulfillmentService? fulfillmentService { get; set; } = null;

    /// <summary>
    /// The image associated with the draft order line item.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// Whether the line item represents the purchase of a gift card.
    /// </summary>
    [JsonPropertyName("isGiftCard")]
    public bool? isGiftCard { get; set; } = null;

    /// <summary>
    /// The name of the product.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The total price, excluding discounts, equal to the original unit price multiplied by quantity.
    /// </summary>
    [JsonPropertyName("originalTotal")]
    public MoneyV2? originalTotal { get; set; } = null;

    /// <summary>
    /// The total price excluding discounts, equal to the original unit price multiplied by quantity.
    /// </summary>
    [JsonPropertyName("originalTotalSet")]
    public MoneyBag? originalTotalSet { get; set; } = null;

    /// <summary>
    /// The line item price without any discounts applied.
    /// </summary>
    [JsonPropertyName("originalUnitPrice")]
    public MoneyV2? originalUnitPrice { get; set; } = null;

    /// <summary>
    /// The price without any discounts applied.
    /// </summary>
    [JsonPropertyName("originalUnitPriceSet")]
    public MoneyBag? originalUnitPriceSet { get; set; } = null;

    /// <summary>
    /// The original custom line item input price.
    /// </summary>
    [JsonPropertyName("originalUnitPriceWithCurrency")]
    public MoneyV2? originalUnitPriceWithCurrency { get; set; } = null;

    /// <summary>
    /// The price override for the line item.
    /// </summary>
    [JsonPropertyName("priceOverride")]
    public MoneyV2? priceOverride { get; set; } = null;

    /// <summary>
    /// The product for the line item.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The quantity of items. For a bundle item, this is the quantity of bundles,
    /// not the quantity of items contained in the bundles themselves.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Whether physical shipping is required for the variant.
    /// </summary>
    [JsonPropertyName("requiresShipping")]
    public bool? requiresShipping { get; set; } = null;

    /// <summary>
    /// The SKU number of the product variant.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

    /// <summary>
    /// Whether the variant is taxable.
    /// </summary>
    [JsonPropertyName("taxable")]
    public bool? taxable { get; set; } = null;

    /// <summary>
    /// The title of the product or variant. This field only applies to custom line items.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The total value of the discount.
    /// </summary>
    [JsonPropertyName("totalDiscount")]
    public MoneyV2? totalDiscount { get; set; } = null;

    /// <summary>
    /// The total discount amount.
    /// </summary>
    [JsonPropertyName("totalDiscountSet")]
    public MoneyBag? totalDiscountSet { get; set; } = null;

    /// <summary>
    /// The UUID of the draft order line item. Must be unique and consistent across requests.
    /// This field is mandatory in order to manipulate drafts with bundles.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? uuid { get; set; } = null;

    /// <summary>
    /// The product variant for the line item.
    /// </summary>
    [JsonPropertyName("variant")]
    public ProductVariant? variant { get; set; } = null;

    /// <summary>
    /// The name of the variant.
    /// </summary>
    [JsonPropertyName("variantTitle")]
    public string? variantTitle { get; set; } = null;

    /// <summary>
    /// The name of the vendor who created the product variant.
    /// </summary>
    [JsonPropertyName("vendor")]
    public string? vendor { get; set; } = null;

    /// <summary>
    /// The weight unit and value.
    /// </summary>
    [JsonPropertyName("weight")]
    public Weight? weight { get; set; } = null;
}