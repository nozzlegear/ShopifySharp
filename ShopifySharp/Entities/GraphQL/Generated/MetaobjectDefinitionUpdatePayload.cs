#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `metaobjectDefinitionUpdate` mutation.
/// </summary>
public record MetaobjectDefinitionUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated metaobject definition.
    /// </summary>
    [JsonPropertyName("metaobjectDefinition")]
    public MetaobjectDefinition? metaobjectDefinition { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MetaobjectUserError>? userErrors { get; set; } = null;
}