#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for metaobject capabilities.
/// </summary>
public record MetaobjectCapabilityDataInput : GraphQLInputObject<MetaobjectCapabilityDataInput>
{
    /// <summary>
    /// Online Store capability input.
    /// </summary>
    [JsonPropertyName("onlineStore")]
    public MetaobjectCapabilityDataOnlineStoreInput? onlineStore { get; set; } = null;

    /// <summary>
    /// Publishable capability input.
    /// </summary>
    [JsonPropertyName("publishable")]
    public MetaobjectCapabilityDataPublishableInput? publishable { get; set; } = null;
}