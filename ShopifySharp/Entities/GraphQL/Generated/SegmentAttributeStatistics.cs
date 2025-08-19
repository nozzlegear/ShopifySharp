#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The statistics of a given attribute.
/// </summary>
public record SegmentAttributeStatistics : IGraphQLObject
{
    /// <summary>
    /// The average of a given attribute.
    /// </summary>
    [JsonPropertyName("average")]
    public decimal? average { get; set; } = null;

    /// <summary>
    /// The sum of a given attribute.
    /// </summary>
    [JsonPropertyName("sum")]
    public decimal? sum { get; set; } = null;
}