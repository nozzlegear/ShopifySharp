#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A filter that's used to segment customers based on the date that an event
/// occured. For example, the `product_bought` event filter allows you to segment
/// customers based on what products they've bought.
/// </summary>
public record SegmentEventFilter : IGraphQLObject, ISegmentFilter
{
    /// <summary>
    /// The localized name of the filter.
    /// </summary>
    [JsonPropertyName("localizedName")]
    public string? localizedName { get; set; } = null;

    /// <summary>
    /// Whether a file can have multiple values for a single customer.
    /// </summary>
    [JsonPropertyName("multiValue")]
    public bool? multiValue { get; set; } = null;

    /// <summary>
    /// The parameters for an event segment filter.
    /// </summary>
    [JsonPropertyName("parameters")]
    public ICollection<SegmentEventFilterParameter>? parameters { get; set; } = null;

    /// <summary>
    /// The query name of the filter.
    /// </summary>
    [JsonPropertyName("queryName")]
    public string? queryName { get; set; } = null;

    /// <summary>
    /// The return value type for an event segment filter.
    /// </summary>
    [JsonPropertyName("returnValueType")]
    public string? returnValueType { get; set; } = null;
}