#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Associates an order line item with quantities requiring fulfillment from the respective fulfillment order.
/// </summary>
public record FulfillmentOrderLineItem : IGraphQLObject, INode
{
    /// <summary>
    /// The financial summary for the Fulfillment Order's Line Items.
    /// </summary>
    [JsonPropertyName("financialSummaries")]
    public ICollection<FulfillmentOrderLineItemFinancialSummary>? financialSummaries { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The image associated to the line item's variant.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// The ID of the inventory item.
    /// </summary>
    [JsonPropertyName("inventoryItemId")]
    public string? inventoryItemId { get; set; } = null;

    /// <summary>
    /// The associated order line item.
    /// </summary>
    [JsonPropertyName("lineItem")]
    public LineItem? lineItem { get; set; } = null;

    /// <summary>
    /// The variant unit price without discounts applied, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("originalUnitPriceSet")]
    [Obsolete("Use `financialSummaries` instead.")]
    public MoneyBag? originalUnitPriceSet { get; set; } = null;

    /// <summary>
    /// The title of the product.
    /// </summary>
    [JsonPropertyName("productTitle")]
    public string? productTitle { get; set; } = null;

    /// <summary>
    /// The number of units remaining to be fulfilled.
    /// </summary>
    [JsonPropertyName("remainingQuantity")]
    public int? remainingQuantity { get; set; } = null;

    /// <summary>
    /// Whether physical shipping is required for the variant.
    /// </summary>
    [JsonPropertyName("requiresShipping")]
    public bool? requiresShipping { get; set; } = null;

    /// <summary>
    /// The variant SKU number.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

    /// <summary>
    /// The total number of units to be fulfilled.
    /// </summary>
    [JsonPropertyName("totalQuantity")]
    public int? totalQuantity { get; set; } = null;

    /// <summary>
    /// The product variant associated to the fulfillment order line item.
    /// </summary>
    [JsonPropertyName("variant")]
    public ProductVariant? variant { get; set; } = null;

    /// <summary>
    /// The name of the variant.
    /// </summary>
    [JsonPropertyName("variantTitle")]
    public string? variantTitle { get; set; } = null;

    /// <summary>
    /// The name of the vendor who made the variant.
    /// </summary>
    [JsonPropertyName("vendor")]
    public string? vendor { get; set; } = null;

    /// <summary>
    /// Warning messages for a fulfillment order line item.
    /// </summary>
    [JsonPropertyName("warnings")]
    public ICollection<FulfillmentOrderLineItemWarning>? warnings { get; set; } = null;

    /// <summary>
    /// The weight of a line item unit.
    /// </summary>
    [JsonPropertyName("weight")]
    public Weight? weight { get; set; } = null;
}