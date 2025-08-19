#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Quantity price breaks lets you offer different rates that are based on the
/// amount of a specific variant being ordered.
/// </summary>
public record QuantityPriceBreak : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Minimum quantity required to reach new quantity break price.
    /// </summary>
    [JsonPropertyName("minimumQuantity")]
    public int? minimumQuantity { get; set; } = null;

    /// <summary>
    /// The price of variant after reaching the minimum quanity.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// The price list associated with this quantity break.
    /// </summary>
    [JsonPropertyName("priceList")]
    public PriceList? priceList { get; set; } = null;

    /// <summary>
    /// The product variant associated with this quantity break.
    /// </summary>
    [JsonPropertyName("variant")]
    public ProductVariant? variant { get; set; } = null;
}