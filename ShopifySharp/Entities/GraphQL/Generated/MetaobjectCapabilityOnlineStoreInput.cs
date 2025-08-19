#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for enabling and disabling the Online Store capability.
/// </summary>
public record MetaobjectCapabilityOnlineStoreInput : GraphQLInputObject<MetaobjectCapabilityOnlineStoreInput>
{
    /// <summary>
    /// The data associated with the Online Store capability.
    /// </summary>
    [JsonPropertyName("data")]
    public MetaobjectCapabilityDefinitionDataOnlineStoreInput? data { get; set; } = null;

    /// <summary>
    /// Indicates whether the capability should be enabled or disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}