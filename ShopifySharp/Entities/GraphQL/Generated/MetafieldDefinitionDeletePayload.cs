#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `metafieldDefinitionDelete` mutation.
/// </summary>
public record MetafieldDefinitionDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The metafield definition that was deleted.
    /// </summary>
    [JsonPropertyName("deletedDefinition")]
    public MetafieldDefinitionIdentifier? deletedDefinition { get; set; } = null;

    /// <summary>
    /// The ID of the deleted metafield definition.
    /// </summary>
    [JsonPropertyName("deletedDefinitionId")]
    public string? deletedDefinitionId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MetafieldDefinitionDeleteUserError>? userErrors { get; set; } = null;
}