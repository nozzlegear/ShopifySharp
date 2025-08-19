#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A calculated exchange line item.
/// </summary>
public record CalculatedExchangeLineItem : IGraphQLObject
{
    /// <summary>
    /// The discounts that have been allocated onto the line item by discount applications.
    /// </summary>
    [JsonPropertyName("calculatedDiscountAllocations")]
    public ICollection<CalculatedDiscountAllocation>? calculatedDiscountAllocations { get; set; } = null;

    /// <summary>
    /// The unit price of the exchange line item after discounts.
    /// </summary>
    [JsonPropertyName("discountedUnitPriceSet")]
    public MoneyBag? discountedUnitPriceSet { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The original unit price of the exchange line item before discounts.
    /// </summary>
    [JsonPropertyName("originalUnitPriceSet")]
    public MoneyBag? originalUnitPriceSet { get; set; } = null;

    /// <summary>
    /// The quantity being exchanged.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The calculated subtotal set of the exchange line item, including discounts.
    /// </summary>
    [JsonPropertyName("subtotalSet")]
    public MoneyBag? subtotalSet { get; set; } = null;

    /// <summary>
    /// The total tax of the exchange line item.
    /// </summary>
    [JsonPropertyName("totalTaxSet")]
    public MoneyBag? totalTaxSet { get; set; } = null;

    /// <summary>
    /// The variant being exchanged.
    /// </summary>
    [JsonPropertyName("variant")]
    public ProductVariant? variant { get; set; } = null;
}