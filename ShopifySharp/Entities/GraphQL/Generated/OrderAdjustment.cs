#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An order adjustment accounts for the difference between a calculated and actual refund amount.
/// </summary>
public record OrderAdjustment : IGraphQLObject, INode
{
    /// <summary>
    /// The amount of the order adjustment in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBag? amountSet { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// An optional reason that explains a discrepancy between calculated and actual refund amounts.
    /// </summary>
    [JsonPropertyName("reason")]
    public OrderAdjustmentDiscrepancyReason? reason { get; set; } = null;

    /// <summary>
    /// The tax amount of the order adjustment in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("taxAmountSet")]
    public MoneyBag? taxAmountSet { get; set; } = null;
}