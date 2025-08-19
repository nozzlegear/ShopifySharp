#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The Online Store capability data for the metaobject definition.
/// </summary>
public record MetaobjectCapabilityDefinitionDataOnlineStore : IGraphQLObject
{
    /// <summary>
    /// Flag indicating if a sufficient number of redirects are available to redirect all published entries.
    /// </summary>
    [JsonPropertyName("canCreateRedirects")]
    public bool? canCreateRedirects { get; set; } = null;

    /// <summary>
    /// The URL handle for accessing pages of this metaobject type in the Online Store.
    /// </summary>
    [JsonPropertyName("urlHandle")]
    public string? urlHandle { get; set; } = null;
}