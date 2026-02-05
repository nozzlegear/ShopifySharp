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