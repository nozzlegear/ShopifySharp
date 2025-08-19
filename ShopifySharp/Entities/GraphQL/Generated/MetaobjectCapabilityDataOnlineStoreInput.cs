#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the Online Store capability to control renderability on the Online Store.
/// </summary>
public record MetaobjectCapabilityDataOnlineStoreInput : GraphQLInputObject<MetaobjectCapabilityDataOnlineStoreInput>
{
    /// <summary>
    /// The theme template used when viewing the metaobject in a store.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;
}