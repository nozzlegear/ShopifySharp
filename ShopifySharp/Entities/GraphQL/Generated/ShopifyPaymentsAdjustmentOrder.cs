#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The adjustment order object.
/// </summary>
public record ShopifyPaymentsAdjustmentOrder : IGraphQLObject
{
    /// <summary>
    /// The amount of the adjustment order.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// The fee of the adjustment order.
    /// </summary>
    [JsonPropertyName("fees")]
    public MoneyV2? fees { get; set; } = null;

    /// <summary>
    /// The link to the adjustment order.
    /// </summary>
    [JsonPropertyName("link")]
    public string? link { get; set; } = null;

    /// <summary>
    /// The name of the adjustment order.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The net of the adjustment order.
    /// </summary>
    [JsonPropertyName("net")]
    public MoneyV2? net { get; set; } = null;

    /// <summary>
    /// The ID of the order transaction.
    /// </summary>
    [JsonPropertyName("orderTransactionId")]
    public long? orderTransactionId { get; set; } = null;
}