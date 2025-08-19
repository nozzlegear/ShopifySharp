#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Translatable content of a resource's field.
/// </summary>
public record TranslatableContent : IGraphQLObject
{
    /// <summary>
    /// Hash digest representation of the content value.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? digest { get; set; } = null;

    /// <summary>
    /// The resource field that's being translated.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// Locale of the content.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// Type of the translatable content.
    /// </summary>
    [JsonPropertyName("type")]
    public LocalizableContentType? type { get; set; } = null;

    /// <summary>
    /// Content value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}