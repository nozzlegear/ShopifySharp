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
/// Represents a theme file.
/// </summary>
public record OnlineStoreThemeFile : IGraphQLObject
{
    /// <summary>
    /// The body of the theme file.
    /// </summary>
    [JsonPropertyName("body")]
    public OnlineStoreThemeFileBody? body { get; set; } = null;

    /// <summary>
    /// The md5 digest of the theme file for data integrity.
    /// </summary>
    [JsonPropertyName("checksumMd5")]
    public string? checksumMd5 { get; set; } = null;

    /// <summary>
    /// The content type of the theme file.
    /// </summary>
    [JsonPropertyName("contentType")]
    public string? contentType { get; set; } = null;

    /// <summary>
    /// The date and time when the theme file was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The unique identifier of the theme file.
    /// </summary>
    [JsonPropertyName("filename")]
    public string? filename { get; set; } = null;

    /// <summary>
    /// The size of the theme file in bytes.
    /// </summary>
    [JsonPropertyName("size")]
    public ulong? size { get; set; } = null;

    /// <summary>
    /// The date and time when the theme file was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}