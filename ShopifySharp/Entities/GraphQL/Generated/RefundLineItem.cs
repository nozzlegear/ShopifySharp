#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A line item that's included in a refund.
/// </summary>
public record RefundLineItem : IGraphQLObject
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The `LineItem` resource associated to the refunded line item.
    /// </summary>
    [JsonPropertyName("lineItem")]
    public LineItem? lineItem { get; set; } = null;

    /// <summary>
    /// The inventory restock location.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The price of a refunded line item.
    /// </summary>
    [JsonPropertyName("price")]
    [Obsolete("Use `priceSet` instead.")]
    public decimal? price { get; set; } = null;

    /// <summary>
    /// The price of a refunded line item in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("priceSet")]
    public MoneyBag? priceSet { get; set; } = null;

    /// <summary>
    /// The quantity of a refunded line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Whether the refunded line item was restocked. Not applicable in the context of a SuggestedRefund.
    /// </summary>
    [JsonPropertyName("restocked")]
    public bool? restocked { get; set; } = null;

    /// <summary>
    /// The type of restock for the refunded line item.
    /// </summary>
    [JsonPropertyName("restockType")]
    public RefundLineItemRestockType? restockType { get; set; } = null;

    /// <summary>
    /// The subtotal price of a refunded line item.
    /// </summary>
    [JsonPropertyName("subtotal")]
    [Obsolete("Use `subtotalSet` instead.")]
    public decimal? subtotal { get; set; } = null;

    /// <summary>
    /// The subtotal price of a refunded line item in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("subtotalSet")]
    public MoneyBag? subtotalSet { get; set; } = null;

    /// <summary>
    /// The total tax charged on a refunded line item.
    /// </summary>
    [JsonPropertyName("totalTax")]
    [Obsolete("Use `totalTaxSet` instead.")]
    public decimal? totalTax { get; set; } = null;

    /// <summary>
    /// The total tax charged on a refunded line item in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("totalTaxSet")]
    public MoneyBag? totalTaxSet { get; set; } = null;
}