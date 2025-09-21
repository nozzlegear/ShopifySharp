#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A comment on an article.
/// </summary>
public record Comment : IGraphQLObject, IHasEvents, INode
{
    /// <summary>
    /// The article associated with the comment.
    /// </summary>
    [JsonPropertyName("article")]
    public Article? article { get; set; } = null;

    /// <summary>
    /// The comment’s author.
    /// </summary>
    [JsonPropertyName("author")]
    public CommentAuthor? author { get; set; } = null;

    /// <summary>
    /// The content of the comment.
    /// </summary>
    [JsonPropertyName("body")]
    public string? body { get; set; } = null;

    /// <summary>
    /// The content of the comment, complete with HTML formatting.
    /// </summary>
    [JsonPropertyName("bodyHtml")]
    public string? bodyHtml { get; set; } = null;

    /// <summary>
    /// The date and time when the comment was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The paginated list of events associated with the host subject.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The IP address of the commenter.
    /// </summary>
    [JsonPropertyName("ip")]
    public string? ip { get; set; } = null;

    /// <summary>
    /// Whether or not the comment is published.
    /// </summary>
    [JsonPropertyName("isPublished")]
    public bool? isPublished { get; set; } = null;

    /// <summary>
    /// The date and time when the comment was published.
    /// </summary>
    [JsonPropertyName("publishedAt")]
    public DateTime? publishedAt { get; set; } = null;

    /// <summary>
    /// The status of the comment.
    /// </summary>
    [JsonPropertyName("status")]
    public CommentStatus? status { get; set; } = null;

    /// <summary>
    /// The date and time when the comment was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; } = null;

    /// <summary>
    /// The user agent of the commenter.
    /// </summary>
    [JsonPropertyName("userAgent")]
    public string? userAgent { get; set; } = null;
}