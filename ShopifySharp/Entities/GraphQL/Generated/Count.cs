#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Details for count of elements.
/// </summary>
public record Count : IGraphQLObject
{
    /// <summary>
    /// The count of elements.
    /// </summary>
    [JsonPropertyName("count")]
    public int? count_ { get; set; } = null;

    /// <summary>
    /// The count's precision, or the exactness of the value.
    /// </summary>
    [JsonPropertyName("precision")]
    public CountPrecision? precision { get; set; } = null;
}