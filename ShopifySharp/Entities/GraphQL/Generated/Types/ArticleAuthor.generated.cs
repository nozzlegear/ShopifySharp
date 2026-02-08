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
/// Represents the author of an article. This object provides the author's full name for attribution purposes.
/// The `ArticleAuthor` is a simple object that contains only the author's name
/// field. When articles are created or updated, the author information is stored
/// and can be displayed alongside the article content.
/// Use the `ArticleAuthor` object to:
/// - Retrieve the author's name for display in article bylines
/// - Show author attribution in article listings
/// - Display who wrote specific content
/// Note: This object only contains the author's full name. It does not include
/// additional author details like bio, email, or social media links.
/// </summary>
public record ArticleAuthor : IGraphQLObject
{
    /// <summary>
    /// The author's full name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}