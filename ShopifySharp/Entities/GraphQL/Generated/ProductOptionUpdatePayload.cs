#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `productOptionUpdate` mutation.
/// </summary>
public record ProductOptionUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The product with which the option being updated is associated.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ProductOptionUpdateUserError>? userErrors { get; set; } = null;
}