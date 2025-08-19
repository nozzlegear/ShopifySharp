#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The details of the arrangement of an item.
/// </summary>
public record ReverseFulfillmentOrderDisposition : IGraphQLObject, INode
{
    /// <summary>
    /// The date and time when the disposition was created.
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