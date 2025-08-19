#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The parameters for an event segment filter.
/// </summary>
public record SegmentEventFilterParameter : IGraphQLObject
{
    /// <summary>
    /// Whether the parameter accepts a list of values.
    /// </summary>
    [JsonPropertyName("acceptsMultipleValues")]
    public bool? acceptsMultipleValues { get; set; } = null;

    /// <summary>
    /// The localized description of the parameter.
    /// </summary>
    [JsonPropertyName("localizedDescription")]
    public string? localizedDescription { get; set; } = null;

    /// <summary>
    /// The localized name of the parameter.
    /// </summary>
    [JsonPropertyName("localizedName")]
    public string? localizedName { get; set; } = null;

    /// <summary>
    /// The parameter maximum value range.
    /// </summary>
    [JsonPropertyName("maxRange")]
    public decimal? maxRange { get; set; } = null;

    /// <summary>
    /// The parameter minimum value range.
    /// </summary>
    [JsonPropertyName("minRange")]
    public decimal? minRange { get; set; } = null;

    /// <summary>
    /// Whether the parameter is optional.
    /// </summary>
    [JsonPropertyName("optional")]
    public bool? optional { get; set; } = null;

    /// <summary>
    /// The type of the parameter.
    /// </summary>
    [JsonPropertyName("parameterType")]
    public string? parameterType { get; set; } = null;

    /// <summary>
    /// The query name of the parameter.
    /// </summary>
    [JsonPropertyName("queryName")]
    public string? queryName { get; set; } = null;
}