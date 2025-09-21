#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `productOptionsDelete` mutation.
/// </summary>
public record ProductOptionsDeletePayload : IGraphQLObject
{
    /// <summary>
    /// IDs of the options deleted.
    /// </summary>
    [JsonPropertyName("deletedOptionsIds")]
    public ICollection<string>? deletedOptionsIds { get; set; } = null;

    /// <summary>
    /// The updated product object.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ProductOptionsDeleteUserError>? userErrors { get; set; } = null;
}