#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for retrieving a metaobject by handle.
/// </summary>
public record MetaobjectHandleInput : GraphQLInputObject<MetaobjectHandleInput>
{
    /// <summary>
    /// The handle of the metaobject to create or update.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The type of the metaobject. Must match an existing metaobject definition type.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;
}