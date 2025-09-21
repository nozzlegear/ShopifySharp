#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents app revenue that was captured externally by the partner.
/// </summary>
public record AppRevenueAttributionRecord : IGraphQLObject, INode
{
    /// <summary>
    /// The financial amount captured in this attribution.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// The timestamp when the financial amount was captured.
    /// </summary>
    [JsonPropertyName("capturedAt")]
    public DateTime? capturedAt { get; set; } = null;

    /// <summary>
    /// The timestamp at which this revenue attribution was issued.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The unique value submitted during the creation of the app revenue attribution record.
    /// For more information, refer to
    /// [Idempotent requests](https://shopify.dev/api/usage/idempotent-requests).
    /// </summary>
    [JsonPropertyName("idempotencyKey")]
    public string? idempotencyKey { get; set; } = null;

    /// <summary>
    /// Indicates whether this is a test submission.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; } = null;

    /// <summary>
    /// The type of revenue attribution.
    /// </summary>
    [JsonPropertyName("type")]
    public AppRevenueAttributionType? type { get; set; } = null;
}