#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `metaobjectDefinitionCreate` mutation.
/// </summary>
public record MetaobjectDefinitionCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created metaobject definition.
    /// </summary>
    [JsonPropertyName("metaobjectDefinition")]
    public MetaobjectDefinition? metaobjectDefinition { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MetaobjectUserError>? userErrors { get; set; } = null;
}