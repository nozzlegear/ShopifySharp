#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A filter with an integer that's been added to a segment query.
/// </summary>
public record SegmentIntegerFilter : IGraphQLObject, ISegmentFilter
{
    /// <summary>
    /// The localized name of the filter.
    /// </summary>
    [JsonPropertyName("localizedName")]
    public string? localizedName { get; set; } = null;

    /// <summary>
    /// The maximum range a filter can have.
    /// </summary>
    [JsonPropertyName("maxRange")]
    public decimal? maxRange { get; set; } = null;

    /// <summary>
    /// The minimum range a filter can have.
    /// </summary>
    [JsonPropertyName("minRange")]
    public decimal? minRange { get; set; } = null;

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