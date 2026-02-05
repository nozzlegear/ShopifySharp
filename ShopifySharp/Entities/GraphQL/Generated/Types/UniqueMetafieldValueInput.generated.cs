#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields that identify a unique valued metafield.
/// </summary>
public record UniqueMetafieldValueInput : GraphQLInputObject<UniqueMetafieldValueInput>
{
    /// <summary>
    /// The key for the metafield.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The container the metafield belongs to. If omitted, the app-reserved namespace will be used.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// The value of the metafield.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}