#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `productCreate` mutation.
/// </summary>
public record ProductCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The product object.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The shop associated with the product.
    /// </summary>
    [JsonPropertyName("shop")]
    public Shop? shop { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}