#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents an article author in an Article.
/// </summary>
public record ArticleAuthor : IGraphQLObject
{
    /// <summary>
    /// The author's full name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}