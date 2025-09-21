#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `productVariantsBulkReorder` mutation.
/// </summary>
public record ProductVariantsBulkReorderPayload : IGraphQLObject
{
    /// <summary>
    /// The updated product.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ProductVariantsBulkReorderUserError>? userErrors { get; set; } = null;
}