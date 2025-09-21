#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The statistics of a given segment.
/// </summary>
public record SegmentStatistics : IGraphQLObject
{
    /// <summary>
    /// The statistics of a given attribute.
    /// </summary>
    [JsonPropertyName("attributeStatistics")]
    public SegmentAttributeStatistics? attributeStatistics { get; set; } = null;
}