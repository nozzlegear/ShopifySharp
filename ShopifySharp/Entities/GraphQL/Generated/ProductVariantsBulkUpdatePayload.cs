#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `productVariantsBulkUpdate` mutation.
/// </summary>
public record ProductVariantsBulkUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated product object.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The updated variants.
    /// </summary>
    [JsonPropertyName("productVariants")]
    public ICollection<ProductVariant>? productVariants { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ProductVariantsBulkUpdateUserError>? userErrors { get; set; } = null;
}