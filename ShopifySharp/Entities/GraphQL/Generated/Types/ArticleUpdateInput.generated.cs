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
/// The input fields to update an article.
/// </summary>
public record ArticleUpdateInput : GraphQLInputObject<ArticleUpdateInput>
{
    /// <summary>
    /// The name of the author of the article.
    /// </summary>
    [JsonPropertyName("author")]
    public AuthorInput? author { get; set; } = null;

    /// <summary>
    /// The ID of the blog containing the article.
    /// </summary>
    [JsonPropertyName("blogId")]
    public string? blogId { get; set; } = null;

    /// <summary>
    /// The text of the article's body, complete with HTML markup.
    /// </summary>
    [JsonPropertyName("body")]
    public string? body { get; set; } = null;

    /// <summary>
    /// A unique, human-friendly string for the article that's automatically generated from the article's title.
    /// The handle is used in the article's URL.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The image associated with the article.
    /// </summary>
    [JsonPropertyName("image")]
    public ArticleImageInput? image { get; set; } = null;

    /// <summary>
    /// Whether or not the article should be visible.
    /// </summary>
    [JsonPropertyName("isPublished")]
    public bool? isPublished { get; set; } = null;

    /// <summary>
    /// The input fields to create or update a metafield.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The date and time (ISO 8601 format) when the article should become visible.
    /// </summary>
    [JsonPropertyName("publishDate")]
    public DateTimeOffset? publishDate { get; set; } = null;

    /// <summary>
    /// Whether a redirect is required after a new handle has been provided.
    /// If `true`, then the old handle is redirected to the new one automatically.
    /// </summary>
    [JsonPropertyName("redirectNewHandle")]
    public bool? redirectNewHandle { get; set; } = null;

    /// <summary>
    /// A summary of the article, which can include HTML markup.
    /// The summary is used by the online store theme to display the article on other
    /// pages, such as the home page or the main blog page.
    /// </summary>
    [JsonPropertyName("summary")]
    public string? summary { get; set; } = null;

    /// <summary>
    /// A comma-separated list of tags.
    /// Tags are additional short descriptors formatted as a string of comma-separated values.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

    /// <summary>
    /// The suffix of the template that's used to render the page.
    /// If the value is an empty string or `null`, then the default article template is used.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;

    /// <summary>
    /// The title of the article.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}