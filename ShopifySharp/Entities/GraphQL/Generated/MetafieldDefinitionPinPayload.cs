#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `metafieldDefinitionPin` mutation.
/// </summary>
public record MetafieldDefinitionPinPayload : IGraphQLObject
{
    /// <summary>
    /// The metafield definition that was pinned.
    /// </summary>
    [JsonPropertyName("pinnedDefinition")]
    public MetafieldDefinition? pinnedDefinition { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MetafieldDefinitionPinUserError>? userErrors { get; set; } = null;
}