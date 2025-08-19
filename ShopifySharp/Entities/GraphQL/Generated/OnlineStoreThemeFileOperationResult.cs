#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the result of a copy, delete, or write operation performed on a theme file.
/// </summary>
public record OnlineStoreThemeFileOperationResult : IGraphQLObject
{
    /// <summary>
    /// The md5 digest of the theme file for data integrity.
    /// </summary>
    [JsonPropertyName("checksumMd5")]
    public string? checksumMd5 { get; set; } = null;

    /// <summary>
    /// The date and time when the theme file was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// Unique identifier of the theme file.
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
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;
}