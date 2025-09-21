#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `metafieldDefinitionUnpin` mutation.
/// </summary>
public record MetafieldDefinitionUnpinPayload : IGraphQLObject
{
    /// <summary>
    /// The metafield definition that was unpinned.
    /// </summary>
    [JsonPropertyName("unpinnedDefinition")]
    public MetafieldDefinition? unpinnedDefinition { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MetafieldDefinitionUnpinUserError>? userErrors { get; set; } = null;
}