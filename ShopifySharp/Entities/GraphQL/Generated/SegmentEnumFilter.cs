#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A filter with a set of possible values that's been added to a segment query.
/// </summary>
public record SegmentEnumFilter : IGraphQLObject, ISegmentFilter
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
    /// The query name of the filter.
    /// </summary>
    [JsonPropertyName("queryName")]
    public string? queryName { get; set; } = null;
}