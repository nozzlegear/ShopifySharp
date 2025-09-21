#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for an image associated with an article.
/// </summary>
public record ArticleImageInput : GraphQLInputObject<ArticleImageInput>
{
    /// <summary>
    /// A word or phrase to share the nature or contents of an image.
    /// </summary>
    [JsonPropertyName("altText")]
    public string? altText { get; set; } = null;

    /// <summary>
    /// The URL of the image.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}