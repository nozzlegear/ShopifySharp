#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields that identify metafield definitions.
/// </summary>
public record HasMetafieldsMetafieldIdentifierInput : GraphQLInputObject<HasMetafieldsMetafieldIdentifierInput>
{
    /// <summary>
    /// The unique identifier for the metafield definition within its namespace.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The container for a group of metafields that the metafield definition will be associated with. If omitted, the
    /// app-reserved namespace will be used.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;
}