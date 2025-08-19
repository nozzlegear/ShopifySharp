#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for deleting a metaobject field definition.
/// </summary>
public record MetaobjectFieldDefinitionDeleteInput : GraphQLInputObject<MetaobjectFieldDefinitionDeleteInput>
{
    /// <summary>
    /// The key of the field definition to delete.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;
}