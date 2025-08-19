#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `productVariantRelationshipBulkUpdate` mutation.
/// </summary>
public record ProductVariantRelationshipBulkUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The product variants with successfully updated product variant relationships.
    /// </summary>
    [JsonPropertyName("parentProductVariants")]
    public ICollection<ProductVariant>? parentProductVariants { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ProductVariantRelationshipBulkUpdateUserError>? userErrors { get; set; } = null;
}