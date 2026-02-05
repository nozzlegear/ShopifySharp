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
/// Represents a Shopify hosted 3D model.
/// </summary>
public record Model3d : IGraphQLUnionCase, IGraphQLObject, IFile, IMedia, INode
{
    /// <summary>
    /// A word or phrase to describe the contents or the function of a file.
    /// </summary>
    [JsonPropertyName("alt")]
    public string? alt { get; set; } = null;

    /// <summary>
    /// The 3d model's bounding box information.
    /// </summary>
    [JsonPropertyName("boundingBox")]
    public Model3dBoundingBox? boundingBox { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the file was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// Any errors that have occurred on the file.
    /// </summary>
    [JsonPropertyName("fileErrors")]
    public ICollection<FileError>? fileErrors { get; set; } = null;

    /// <summary>
    /// The 3d model's filename.
    /// </summary>
    [JsonPropertyName("filename")]
    public string? filename { get; set; } = null;

    /// <summary>
    /// The status of the file.
    /// </summary>
    [JsonPropertyName("fileStatus")]
    public FileStatus? fileStatus { get; set; } = null;

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
    /// The 3d model's original source.
    /// </summary>
    [JsonPropertyName("originalSource")]
    public Model3dSource? originalSource { get; set; } = null;

    /// <summary>
    /// The preview image for the media.
    /// </summary>
    [JsonPropertyName("preview")]
    public MediaPreviewImage? preview { get; set; } = null;

    /// <summary>
    /// The 3d model's sources.
    /// </summary>
    [JsonPropertyName("sources")]
    public ICollection<Model3dSource>? sources { get; set; } = null;

    /// <summary>
    /// Current status of the media.
    /// </summary>
    [JsonPropertyName("status")]
    public MediaStatus? status { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the file was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}