#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// App credits can be applied by the merchant towards future app purchases, subscriptions, or usage records in Shopify.
/// </summary>
public record AppCredit : IGraphQLObject, INode
{
    /// <summary>
    /// The amount that can be used towards future app purchases in Shopify.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// The date and time when the app credit was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The description of the app credit.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the app credit is a test transaction.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; } = null;
}