#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `metafieldDefinitionCreate` mutation.
/// </summary>
public record MetafieldDefinitionCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The metafield definition that was created.
    /// </summary>
    [JsonPropertyName("createdDefinition")]
    public MetafieldDefinition? createdDefinition { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MetafieldDefinitionCreateUserError>? userErrors { get; set; } = null;
}