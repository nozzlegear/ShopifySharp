#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a currency exchange adjustment applied to an order transaction.
/// </summary>
public record CurrencyExchangeAdjustment : IGraphQLObject, INode
{
    /// <summary>
    /// The adjustment amount in both shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("adjustment")]
    public MoneyV2? adjustment { get; set; } = null;

    /// <summary>
    /// The final amount in both shop and presentment currencies after the adjustment.
    /// </summary>
    [JsonPropertyName("finalAmountSet")]
    public MoneyV2? finalAmountSet { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The original amount in both shop and presentment currencies before the adjustment.
    /// </summary>
    [JsonPropertyName("originalAmountSet")]
    public MoneyV2? originalAmountSet { get; set; } = null;
}