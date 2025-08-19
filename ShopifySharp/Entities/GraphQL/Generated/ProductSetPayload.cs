#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `productSet` mutation.
/// </summary>
public record ProductSetPayload : IGraphQLObject
{
    /// <summary>
    /// The product object.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The product set operation, returned when run in asynchronous mode.
    /// </summary>
    [JsonPropertyName("productSetOperation")]
    public ProductSetOperation? productSetOperation { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ProductSetUserError>? userErrors { get; set; } = null;
}