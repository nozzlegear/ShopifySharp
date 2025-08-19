#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields that identify metafields.
/// </summary>
public record MetafieldIdentifierInput : GraphQLInputObject<MetafieldIdentifierInput>
{
    /// <summary>
    /// The key of the metafield.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The namespace of the metafield.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// The unique ID of the resource that the metafield is attached to.
    /// </summary>
    [JsonPropertyName("ownerId")]
    public string? ownerId { get; set; } = null;
}