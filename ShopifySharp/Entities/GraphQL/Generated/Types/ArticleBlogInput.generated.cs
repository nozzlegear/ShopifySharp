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