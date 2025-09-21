#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for Theme attributes to update.
/// </summary>
public record OnlineStoreThemeInput : GraphQLInputObject<OnlineStoreThemeInput>
{
    /// <summary>
    /// The new name of the theme.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}