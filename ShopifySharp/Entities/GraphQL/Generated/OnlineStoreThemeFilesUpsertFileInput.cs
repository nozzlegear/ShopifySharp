#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the file to create or update.
/// </summary>
public record OnlineStoreThemeFilesUpsertFileInput : GraphQLInputObject<OnlineStoreThemeFilesUpsertFileInput>
{
    /// <summary>
    /// The body of the theme file.
    /// </summary>
    [JsonPropertyName("body")]
    public OnlineStoreThemeFileBodyInput? body { get; set; } = null;

    /// <summary>
    /// The filename of the theme file.
    /// </summary>
    [JsonPropertyName("filename")]
    public string? filename { get; set; } = null;
}