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
/// The input fields of the renderable capability for SEO aliases.
/// </summary>
public record MetaobjectCapabilityDefinitionDataRenderableInput : GraphQLInputObject<MetaobjectCapabilityDefinitionDataRenderableInput>
{
    /// <summary>
    /// The metaobject field used as an alias for the SEO page description.
    /// </summary>
    [JsonPropertyName("metaDescriptionKey")]
    public string? metaDescriptionKey { get; set; } = null;

    /// <summary>
    /// The metaobject field used as an alias for the SEO page title.
    /// </summary>
    [JsonPropertyName("metaTitleKey")]
    public string? metaTitleKey { get; set; } = null;
}