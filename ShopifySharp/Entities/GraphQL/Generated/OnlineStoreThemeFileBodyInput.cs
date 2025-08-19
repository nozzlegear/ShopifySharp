#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the theme file body.
/// </summary>
public record OnlineStoreThemeFileBodyInput : GraphQLInputObject<OnlineStoreThemeFileBodyInput>
{
    /// <summary>
    /// The input type of the theme file body.
    /// </summary>
    [JsonPropertyName("type")]
    public OnlineStoreThemeFileBodyInputType? type { get; set; } = null;

    /// <summary>
    /// The body of the theme file.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}