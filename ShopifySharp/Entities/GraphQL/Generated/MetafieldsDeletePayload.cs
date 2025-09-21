#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `metafieldsDelete` mutation.
/// </summary>
public record MetafieldsDeletePayload : IGraphQLObject
{
    /// <summary>
    /// List of metafield identifiers that were deleted, null if the corresponding metafield isn't found.
    /// </summary>
    [JsonPropertyName("deletedMetafields")]
    public ICollection<MetafieldIdentifier>? deletedMetafields { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}