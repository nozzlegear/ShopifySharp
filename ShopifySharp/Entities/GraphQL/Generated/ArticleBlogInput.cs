#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields of a blog when an article is created or updated.
/// </summary>
public record ArticleBlogInput : GraphQLInputObject<ArticleBlogInput>
{
    /// <summary>
    /// The title of the blog.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}