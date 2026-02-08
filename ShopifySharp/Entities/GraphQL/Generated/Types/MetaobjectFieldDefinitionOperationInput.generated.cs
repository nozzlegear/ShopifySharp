#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for possible operations for modifying field definitions. Exactly one option is required.
/// </summary>
public record MetaobjectFieldDefinitionOperationInput : GraphQLInputObject<MetaobjectFieldDefinitionOperationInput>
{
    /// <summary>
    /// The input fields for creating a metaobject field definition.
    /// </summary>
    [JsonPropertyName("create")]
    public MetaobjectFieldDefinitionCreateInput? create { get; set; } = null;

    /// <summary>
    /// The input fields for deleting a metaobject field definition.
    /// </summary>
    [JsonPropertyName("delete")]
    public MetaobjectFieldDefinitionDeleteInput? delete { get; set; } = null;

    /// <summary>
    /// The input fields for updating a metaobject field definition.
    /// </summary>
    [JsonPropertyName("update")]
    public MetaobjectFieldDefinitionUpdateInput? update { get; set; } = null;
}