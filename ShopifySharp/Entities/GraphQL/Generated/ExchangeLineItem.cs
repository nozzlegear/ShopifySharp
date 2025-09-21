#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An item for exchange.
/// </summary>
public record ExchangeLineItem : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The order line item for the exchange. If the exchange line has been processed
    /// multiple times, this will be the first associated line item and won't reflect
    /// all processed values.
    /// </summary>
    [JsonPropertyName("lineItem")]
    [Obsolete("Use `lineItems` instead.")]
    public LineItem? lineItem { get; set; } = null;

    /// <summary>
    /// The order line items for the exchange.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<LineItem>? lineItems { get; set; } = null;

    /// <summary>
    /// The quantity of the exchange item that can be processed.
    /// </summary>
    [JsonPropertyName("processableQuantity")]
    public int? processableQuantity { get; set; } = null;

    /// <summary>
    /// The quantity of the exchange item that have been processed.
    /// </summary>
    [JsonPropertyName("processedQuantity")]
    public int? processedQuantity { get; set; } = null;

    /// <summary>
    /// The number of units ordered, including refunded and removed units.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The quantity of the exchange item that haven't been processed.
    /// </summary>
    [JsonPropertyName("unprocessedQuantity")]
    public int? unprocessedQuantity { get; set; } = null;

    /// <summary>
    /// The ID of the variant at time of return creation.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;
}