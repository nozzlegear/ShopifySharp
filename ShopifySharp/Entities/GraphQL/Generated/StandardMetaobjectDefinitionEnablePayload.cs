#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `standardMetaobjectDefinitionEnable` mutation.
/// </summary>
public record StandardMetaobjectDefinitionEnablePayload : IGraphQLObject
{
    /// <summary>
    /// The metaobject definition that was enabled using the standard template.
    /// </summary>
    [JsonPropertyName("metaobjectDefinition")]
    public MetaobjectDefinition? metaobjectDefinition { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MetaobjectUserError>? userErrors { get; set; } = null;
}