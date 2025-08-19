#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields of the Online Store capability.
/// </summary>
public record MetaobjectCapabilityDefinitionDataOnlineStoreInput : GraphQLInputObject<MetaobjectCapabilityDefinitionDataOnlineStoreInput>
{
    /// <summary>
    /// Whether to redirect published metaobjects automatically when the URL handle changes.
    /// </summary>
    [JsonPropertyName("createRedirects")]
    public bool? createRedirects { get; set; } = null;

    /// <summary>
    /// The URL handle for accessing pages of this metaobject type in the Online Store.
    /// </summary>
    [JsonPropertyName("urlHandle")]
    public string? urlHandle { get; set; } = null;
}