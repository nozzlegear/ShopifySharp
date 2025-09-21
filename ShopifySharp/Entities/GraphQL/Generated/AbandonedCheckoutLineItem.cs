#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A single line item in an abandoned checkout.
/// </summary>
public record AbandonedCheckoutLineItem : IGraphQLObject, INode
{
    /// <summary>
    /// A list of line item components for this line item.
    /// </summary>
    [JsonPropertyName("components")]
    public ICollection<AbandonedCheckoutLineItemComponent>? components { get; set; } = null;

    /// <summary>
    /// A list of extra information that has been added to the line item.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; } = null;

    /// <summary>
    /// Discount allocations that have been applied on the line item.
    /// </summary>
    [JsonPropertyName("discountAllocations")]
    public DiscountAllocationConnection? discountAllocations { get; set; } = null;

    /// <summary>
    /// Final total price for the entire quantity of this line item, including discounts.
    /// </summary>
    [JsonPropertyName("discountedTotalPriceSet")]
    public MoneyBag? discountedTotalPriceSet { get; set; } = null;

    /// <summary>
    /// The total price for the entire quantity of this line item, after all discounts
    /// are applied, at both the line item and code-based line item level.
    /// </summary>
    [JsonPropertyName("discountedTotalPriceWithCodeDiscount")]
    public MoneyBag? discountedTotalPriceWithCodeDiscount { get; set; } = null;

    /// <summary>
    /// The price of a single variant unit after discounts are applied at the line item level, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("discountedUnitPriceSet")]
    public MoneyBag? discountedUnitPriceSet { get; set; } = null;

    /// <summary>
    /// The price of a single variant unit after all discounts are applied, at both the line item and code-based line item level.
    /// </summary>
    [JsonPropertyName("discountedUnitPriceWithCodeDiscount")]
    public MoneyBag? discountedUnitPriceWithCodeDiscount { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The image associated with the line item's variant or product.
    /// NULL if the line item has no product, or if neither the variant nor the product have an image.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// Original total price for the entire quantity of this line item, before discounts.
    /// </summary>
    [JsonPropertyName("originalTotalPriceSet")]
    public MoneyBag? originalTotalPriceSet { get; set; } = null;

    /// <summary>
    /// Original price for a single unit of this line item, before discounts.
    /// </summary>
    [JsonPropertyName("originalUnitPriceSet")]
    public MoneyBag? originalUnitPriceSet { get; set; } = null;

    /// <summary>
    /// Product for this line item.
    /// NULL for custom line items and products that were deleted after checkout began.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The quantity of the line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// SKU for the inventory item associated with the variant, if any.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

    /// <summary>
    /// Title of the line item. Defaults to the product's title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// Product variant for this line item.
    /// NULL for custom line items and variants that were deleted after checkout began.
    /// </summary>
    [JsonPropertyName("variant")]
    public ProductVariant? variant { get; set; } = null;

    /// <summary>
    /// Title of the variant for this line item.
    /// NULL for custom line items and products that don't have distinct variants.
    /// </summary>
    [JsonPropertyName("variantTitle")]
    public string? variantTitle { get; set; } = null;
}