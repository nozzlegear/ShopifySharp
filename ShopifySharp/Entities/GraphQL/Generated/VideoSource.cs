#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a source for a Shopify hosted video.
/// Types of sources include the original video, lower resolution versions of the original video,
/// and an m3u8 playlist file.
/// Only [videos](https://shopify.dev/api/admin-graphql/latest/objects/video) with a status field
/// of [READY](https://shopify.dev/api/admin-graphql/latest/enums/MediaStatus#value-ready) have sources.
/// </summary>
public record VideoSource : IGraphQLObject
{
    /// <summary>
    /// The video source's file size in bytes.
    /// </summary>
    [JsonPropertyName("fileSize")]
    public int? fileSize { get; set; } = null;

    /// <summary>
    /// The video source's file format extension.
    /// </summary>
    [JsonPropertyName("format")]
    public string? format { get; set; } = null;

    /// <summary>
    /// The video source's height.
    /// </summary>
    [JsonPropertyName("height")]
    public int? height { get; set; } = null;

    /// <summary>
    /// The video source's MIME type.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string? mimeType { get; set; } = null;

    /// <summary>
    /// The video source's URL.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;

    /// <summary>
    /// The video source's width.
    /// </summary>
    [JsonPropertyName("width")]
    public int? width { get; set; } = null;
}