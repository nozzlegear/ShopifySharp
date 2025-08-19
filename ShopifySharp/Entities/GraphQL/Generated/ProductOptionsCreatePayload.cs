#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `productOptionsCreate` mutation.
/// </summary>
public record ProductOptionsCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated product object.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ProductOptionsCreateUserError>? userErrors { get; set; } = null;
}