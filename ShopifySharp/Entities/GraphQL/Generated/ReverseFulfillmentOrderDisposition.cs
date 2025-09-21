#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The details of the arrangement of an item.
/// </summary>
public record ReverseFulfillmentOrderDisposition : IGraphQLObject, INode
{
    /// <summary>
    /// The date and time when the disposition was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The location where the disposition occurred.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The number of disposed units.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The final arrangement of an item.
    /// </summary>
    [JsonPropertyName("type")]
    public ReverseFulfillmentOrderDispositionType? type { get; set; } = null;
}