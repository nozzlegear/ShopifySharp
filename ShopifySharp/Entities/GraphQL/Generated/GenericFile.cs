#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents any file other than HTML.
/// </summary>
public record GenericFile : MetafieldReference, IGraphQLUnionCase, IGraphQLObject, IFile, INode
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
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

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
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The generic file's MIME type.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string? mimeType { get; set; } = null;

    /// <summary>
    /// The generic file's size in bytes.
    /// </summary>
    [JsonPropertyName("originalFileSize")]
    public int? originalFileSize { get; set; } = null;

    /// <summary>
    /// The preview image for the media.
    /// </summary>
    [JsonPropertyName("preview")]
    public MediaPreviewImage? preview { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the file was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;

    /// <summary>
    /// The generic file's URL.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}