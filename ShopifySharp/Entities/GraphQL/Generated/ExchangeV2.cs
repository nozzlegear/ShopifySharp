#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An exchange where existing items on an order are returned and new items are added to the order.
/// </summary>
public record ExchangeV2 : IGraphQLObject, INode
{
    /// <summary>
    /// The details of the new items in the exchange.
    /// </summary>
    [JsonPropertyName("additions")]
    public ExchangeV2Additions? additions { get; set; } = null;

    /// <summary>
    /// The date and time when the exchange was completed.
    /// </summary>
    [JsonPropertyName("completedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? completedAt { get; set; } = null;

    /// <summary>
    /// The date and time when the exchange was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The location where the exchange happened.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// Mirrored from Admin Exchanges.
    /// </summary>
    [JsonPropertyName("mirrored")]
    public bool? mirrored { get; set; } = null;

    /// <summary>
    /// The text of an optional note that a shop owner can attach to the exchange.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The refunds processed during the exchange.
    /// </summary>
    [JsonPropertyName("refunds")]
    public ICollection<Refund>? refunds { get; set; } = null;

    /// <summary>
    /// The details of the returned items in the exchange.
    /// </summary>
    [JsonPropertyName("returns")]
    public ExchangeV2Returns? returns { get; set; } = null;

    /// <summary>
    /// The staff member associated with the exchange.
    /// </summary>
    [JsonPropertyName("staffMember")]
    public StaffMember? staffMember { get; set; } = null;

    /// <summary>
    /// The amount of money that was paid or refunded as part of the exchange.
    /// </summary>
    [JsonPropertyName("totalAmountProcessedSet")]
    public MoneyBag? totalAmountProcessedSet { get; set; } = null;

    /// <summary>
    /// The difference in values of the items that were exchanged.
    /// </summary>
    [JsonPropertyName("totalPriceSet")]
    public MoneyBag? totalPriceSet { get; set; } = null;

    /// <summary>
    /// The order transactions related to the exchange.
    /// </summary>
    [JsonPropertyName("transactions")]
    public ICollection<OrderTransaction>? transactions { get; set; } = null;
}