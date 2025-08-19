#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for updating a metaobject capability.
/// </summary>
public record MetaobjectCapabilityUpdateInput : GraphQLInputObject<MetaobjectCapabilityUpdateInput>
{
    /// <summary>
    /// The input for enabling the Online Store capability.
    /// </summary>
    [JsonPropertyName("onlineStore")]
    public MetaobjectCapabilityOnlineStoreInput? onlineStore { get; set; } = null;

    /// <summary>
    /// The input for updating the publishable capability.
    /// </summary>
    [JsonPropertyName("publishable")]
    public MetaobjectCapabilityPublishableInput? publishable { get; set; } = null;

    /// <summary>
    /// The input for enabling the renderable capability.
    /// </summary>
    [JsonPropertyName("renderable")]
    public MetaobjectCapabilityRenderableInput? renderable { get; set; } = null;

    /// <summary>
    /// The input for updating the translatable capability.
    /// </summary>
    [JsonPropertyName("translatable")]
    public MetaobjectCapabilityTranslatableInput? translatable { get; set; } = null;
}