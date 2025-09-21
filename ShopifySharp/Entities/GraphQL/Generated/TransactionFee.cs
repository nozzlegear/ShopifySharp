#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Transaction fee related to an order transaction.
/// </summary>
public record TransactionFee : IGraphQLObject, INode
{
    /// <summary>
    /// Amount of the fee.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// Flat rate charge for a transaction.
    /// </summary>
    [JsonPropertyName("flatFee")]
    public MoneyV2? flatFee { get; set; } = null;

    /// <summary>
    /// Name of the credit card flat fee.
    /// </summary>
    [JsonPropertyName("flatFeeName")]
    public string? flatFeeName { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Percentage charge.
    /// </summary>
    [JsonPropertyName("rate")]
    public decimal? rate { get; set; } = null;

    /// <summary>
    /// Name of the credit card rate.
    /// </summary>
    [JsonPropertyName("rateName")]
    public string? rateName { get; set; } = null;

    /// <summary>
    /// Tax amount charged on the fee.
    /// </summary>
    [JsonPropertyName("taxAmount")]
    public MoneyV2? taxAmount { get; set; } = null;

    /// <summary>
    /// Name of the type of fee.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;
}