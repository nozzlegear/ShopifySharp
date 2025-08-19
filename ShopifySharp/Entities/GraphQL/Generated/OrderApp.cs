#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The [application](https://shopify.dev/apps) that created the order.
/// </summary>
public record OrderApp : IGraphQLObject
{
    /// <summary>
    /// The application icon.
    /// </summary>
    [JsonPropertyName("icon")]
    public Image? icon { get; set; } = null;

    /// <summary>
    /// The application ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the application.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}