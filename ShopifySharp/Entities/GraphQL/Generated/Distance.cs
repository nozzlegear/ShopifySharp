#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A distance, which includes a numeric value and a unit of measurement.
/// </summary>
public record Distance : IGraphQLObject
{
    /// <summary>
    /// The unit of measurement for `value`.
    /// </summary>
    [JsonPropertyName("unit")]
    public DistanceUnit? unit { get; set; } = null;

    /// <summary>
    /// The distance value using the unit system specified with `unit`.
    /// </summary>
    [JsonPropertyName("value")]
    public decimal? @value { get; set; } = null;
}