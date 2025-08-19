#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The renderable capability data for the metaobject definition.
/// </summary>
public record MetaobjectCapabilityDefinitionDataRenderable : IGraphQLObject
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