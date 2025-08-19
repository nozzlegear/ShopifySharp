#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields that set access permissions for the definition's metaobjects.
/// </summary>
public record MetaobjectAccessInput : GraphQLInputObject<MetaobjectAccessInput>
{
    /// <summary>
    /// The access permitted on the Admin API.
    /// </summary>
    [JsonPropertyName("admin")]
    public MetaobjectAdminAccessInput? admin { get; set; } = null;

    /// <summary>
    /// The access permitted on the Storefront API.
    /// </summary>
    [JsonPropertyName("storefront")]
    public MetaobjectStorefrontAccess? storefront { get; set; } = null;
}