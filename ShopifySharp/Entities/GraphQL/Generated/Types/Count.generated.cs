#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A numeric count with precision information indicating whether the count is exact or an estimate.
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