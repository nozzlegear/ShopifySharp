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
/// The input fields for creating capabilities on a metaobject field definition.
/// </summary>
public record MetaobjectFieldDefinitionCapabilityCreateInput : GraphQLInputObject<MetaobjectFieldDefinitionCapabilityCreateInput>
{
    /// <summary>
    /// The input for configuring the admin filterable capability.
    /// </summary>
    [JsonPropertyName("adminFilterable")]
    public MetaobjectFieldCapabilityAdminFilterableInput? adminFilterable { get; set; } = null;
}