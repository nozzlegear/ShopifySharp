#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A line item involved in order editing that may be newly added or have new changes applied.
/// </summary>
public record CalculatedLineItem : IGraphQLObject
{
    /// <summary>
    /// The discounts that have been allocated onto the line item by discount applications.
    /// </summary>
    [JsonPropertyName("calculatedDiscountAllocations")]
    public ICollection<CalculatedDiscountAllocation>? calculatedDiscountAllocations { get; set; } = null;

    /// <summary>
    /// A list of attributes that represent custom features or special requests.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; } = null;

    /// <summary>
    /// The discounts that have been allocated onto the line item by discount applications.
    /// </summary>
    [JsonPropertyName("discountAllocations")]
    [Obsolete("Use `calculatedDiscountAllocations` instead.")]
    public ICollection<DiscountAllocation>? discountAllocations { get; set; } = null;

    /// <summary>
    /// The price of a single quantity of the line item with line item discounts
    /// applied, in shop and presentment currencies. Discounts applied to the entire
    /// order aren't included in this price.
    /// </summary>
    [JsonPropertyName("discountedUnitPriceSet")]
    public MoneyBag? discountedUnitPriceSet { get; set; } = null;

    /// <summary>
    /// The total number of items that can be edited.
    /// </summary>
    [JsonPropertyName("editableQuantity")]
    public int? editableQuantity { get; set; } = null;

    /// <summary>
    /// The editable quantity prior to any changes made in the current edit.
    /// </summary>
    [JsonPropertyName("editableQuantityBeforeChanges")]
    public int? editableQuantityBeforeChanges { get; set; } = null;

    /// <summary>
    /// The total price of editable lines in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("editableSubtotalSet")]
    public MoneyBag? editableSubtotalSet { get; set; } = null;

    /// <summary>
    /// Whether the calculated line item has a staged discount.
    /// </summary>
    [JsonPropertyName("hasStagedLineItemDiscount")]
    public bool? hasStagedLineItemDiscount { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The image object associated to the line item's variant.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// The variant unit price in shop and presentment currencies, without any discounts applied.
    /// </summary>
    [JsonPropertyName("originalUnitPriceSet")]
    public MoneyBag? originalUnitPriceSet { get; set; } = null;

    /// <summary>
    /// The total number of items.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Whether the line item can be restocked or not.
    /// </summary>
    [JsonPropertyName("restockable")]
    public bool? restockable { get; set; } = null;

    /// <summary>
    /// Whether the changes on the line item will result in a restock.
    /// </summary>
    [JsonPropertyName("restocking")]
    public bool? restocking { get; set; } = null;

    /// <summary>
    /// The variant SKU number.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

    /// <summary>
    /// A list of changes that affect this line item.
    /// </summary>
    [JsonPropertyName("stagedChanges")]
    public ICollection<OrderStagedChange>? stagedChanges { get; set; } = null;

    /// <summary>
    /// The title of the product.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The total price of uneditable lines in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("uneditableSubtotalSet")]
    public MoneyBag? uneditableSubtotalSet { get; set; } = null;

    /// <summary>
    /// The product variant associated with this line item. The value is null for custom line items and items where
    /// the variant has been deleted.
    /// </summary>
    [JsonPropertyName("variant")]
    public ProductVariant? variant { get; set; } = null;

    /// <summary>
    /// The title of the variant.
    /// </summary>
    [JsonPropertyName("variantTitle")]
    public string? variantTitle { get; set; } = null;
}