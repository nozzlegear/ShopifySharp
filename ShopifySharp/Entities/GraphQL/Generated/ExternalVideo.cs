#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a video hosted outside of Shopify.
/// </summary>
public record ExternalVideo : IGraphQLObject, IFile, IMedia, INode
{
    /// <summary>
    /// A word or phrase to describe the contents or the function of a file.
    /// </summary>
    [JsonPropertyName("alt")]
    public string? alt { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the file was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The URL.
    /// </summary>
    [JsonPropertyName("embeddedUrl")]
    [Obsolete("Use `originUrl` instead.")]
    public string? embeddedUrl { get; set; } = null;

    /// <summary>
    /// The embed URL of the video for the respective host.
    /// </summary>
    [JsonPropertyName("embedUrl")]
    public string? embedUrl { get; set; } = null;

    /// <summary>
    /// Any errors that have occurred on the file.
    /// </summary>
    [JsonPropertyName("fileErrors")]
    public ICollection<FileError>? fileErrors { get; set; } = null;

    /// <summary>
    /// The status of the file.
    /// </summary>
    [JsonPropertyName("fileStatus")]
    public FileStatus? fileStatus { get; set; } = null;

    /// <summary>
    /// The host of the external video.
    /// </summary>
    [JsonPropertyName("host")]
    public MediaHost? host { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The media content type.
    /// </summary>
    [JsonPropertyName("mediaContentType")]
    public MediaContentType? mediaContentType { get; set; } = null;

    /// <summary>
    /// Any errors which have occurred on the media.
    /// </summary>
    [JsonPropertyName("mediaErrors")]
    public ICollection<MediaError>? mediaErrors { get; set; } = null;

    /// <summary>
    /// The warnings attached to the media.
    /// </summary>
    [JsonPropertyName("mediaWarnings")]
    public ICollection<MediaWarning>? mediaWarnings { get; set; } = null;

    /// <summary>
    /// The origin URL of the video on the respective host.
    /// </summary>
    [JsonPropertyName("originUrl")]
    public string? originUrl { get; set; } = null;

    /// <summary>
    /// The preview image for the media.
    /// </summary>
    [JsonPropertyName("preview")]
    public MediaPreviewImage? preview { get; set; } = null;

    /// <summary>
    /// Current status of the media.
    /// </summary>
    [JsonPropertyName("status")]
    public MediaStatus? status { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the file was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; } = null;
}