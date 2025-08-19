#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The filters used in segment queries associated with a shop.
/// </summary>
public interface ISegmentFilter : IGraphQLObject
{
    /// <summary>
    /// The localized name of the filter.
    /// </summary>
    [JsonPropertyName("localizedName")]
    public string? localizedName { get; set; }

    /// <summary>
    /// Whether a file can have multiple values for a single customer.
    /// </summary>
    [JsonPropertyName("multiValue")]
    public bool? multiValue { get; set; }

    /// <summary>
    /// The query name of the filter.
    /// </summary>
    [JsonPropertyName("queryName")]
    public string? queryName { get; set; }
}