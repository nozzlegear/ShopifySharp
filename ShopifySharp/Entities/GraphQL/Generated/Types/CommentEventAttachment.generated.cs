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
/// A file attachment associated to a comment event.
/// </summary>
public record CommentEventAttachment : IGraphQLObject
{
    /// <summary>
    /// The file extension of the comment event attachment, indicating the file format.
    /// </summary>
    [JsonPropertyName("fileExtension")]
    public string? fileExtension { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The image attached to the comment event.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// The filename of the comment event attachment.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The size of the attachment.
    /// </summary>
    [JsonPropertyName("size")]
    public int? size { get; set; } = null;

    /// <summary>
    /// The URL of the attachment.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}