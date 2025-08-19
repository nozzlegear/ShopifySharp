#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Provides the capabilities of a metaobject definition.
/// </summary>
public record MetaobjectCapabilities : IGraphQLObject
{
    /// <summary>
    /// Indicates whether a metaobject definition can be displayed as a page on the Online Store.
    /// </summary>
    [JsonPropertyName("onlineStore")]
    public MetaobjectCapabilitiesOnlineStore? onlineStore { get; set; } = null;

    /// <summary>
    /// Indicate whether a metaobject definition is publishable.
    /// </summary>
    [JsonPropertyName("publishable")]
    public MetaobjectCapabilitiesPublishable? publishable { get; set; } = null;

    /// <summary>
    /// Indicate whether a metaobject definition is renderable and exposes SEO data.
    /// </summary>
    [JsonPropertyName("renderable")]
    public MetaobjectCapabilitiesRenderable? renderable { get; set; } = null;

    /// <summary>
    /// Indicate whether a metaobject definition is translatable.
    /// </summary>
    [JsonPropertyName("translatable")]
    public MetaobjectCapabilitiesTranslatable? translatable { get; set; } = null;
}