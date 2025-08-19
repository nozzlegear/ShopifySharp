#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A restocking fee is a fee captured as part of a return to cover the costs of handling a return line item.
/// Typically, this would cover the costs of inspecting, repackaging, and restocking the item.
/// </summary>
public record RestockingFee : IGraphQLObject, IFee
{
    /// <summary>
    /// The amount of the restocking fee, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBag? amountSet { get; set; } = null;

    /// <summary>
    /// The unique ID for the Fee.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The value of the fee as a percentage.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}