#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `standardMetafieldDefinitionEnable` mutation.
/// </summary>
public record StandardMetafieldDefinitionEnablePayload : IGraphQLObject
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
    public ICollection<StandardMetafieldDefinitionEnableUserError>? userErrors { get; set; } = null;
}