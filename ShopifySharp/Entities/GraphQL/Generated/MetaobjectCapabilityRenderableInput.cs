#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for enabling and disabling the renderable capability.
/// </summary>
public record MetaobjectCapabilityRenderableInput : GraphQLInputObject<MetaobjectCapabilityRenderableInput>
{
    /// <summary>
    /// The data associated with the renderable capability.
    /// </summary>
    [JsonPropertyName("data")]
    public MetaobjectCapabilityDefinitionDataRenderableInput? data { get; set; } = null;

    /// <summary>
    /// Indicates whether the capability should be enabled or disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}