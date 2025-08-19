#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a media interface.
/// </summary>
public interface IMedia : IGraphQLObject
{
    /// <summary>
    /// A word or phrase to share the nature or contents of a media.
    /// </summary>
    [JsonPropertyName("alt")]
    public string? alt { get; set; }

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// The media content type.
    /// </summary>
    [JsonPropertyName("mediaContentType")]
    public MediaContentType? mediaContentType { get; set; }

    /// <summary>
    /// Any errors which have occurred on the media.
    /// </summary>
    [JsonPropertyName("mediaErrors")]
    public ICollection<MediaError>? mediaErrors { get; set; }

    /// <summary>
    /// The warnings attached to the media.
    /// </summary>
    [JsonPropertyName("mediaWarnings")]
    public ICollection<MediaWarning>? mediaWarnings { get; set; }

    /// <summary>
    /// The preview image for the media.
    /// </summary>
    [JsonPropertyName("preview")]
    public MediaPreviewImage? preview { get; set; }

    /// <summary>
    /// Current status of the media.
    /// </summary>
    [JsonPropertyName("status")]
    public MediaStatus? status { get; set; }
}