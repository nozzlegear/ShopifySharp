#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The author of a comment.
/// </summary>
public record CommentAuthor : IGraphQLObject
{
    /// <summary>
    /// The author's email.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// The author’s name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}