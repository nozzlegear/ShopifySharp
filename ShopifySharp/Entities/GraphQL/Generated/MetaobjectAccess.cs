#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Access permissions for the definition's metaobjects.
/// </summary>
public record MetaobjectAccess : IGraphQLObject
{
    /// <summary>
    /// The access permitted on the Admin API.
    /// </summary>
    [JsonPropertyName("admin")]
    public MetaobjectAdminAccess? admin { get; set; } = null;

    /// <summary>
    /// The access permitted on the Storefront API.
    /// </summary>
    [JsonPropertyName("storefront")]
    public MetaobjectStorefrontAccess? storefront { get; set; } = null;
}