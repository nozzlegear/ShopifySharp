#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to update a blog.
/// </summary>
public record BlogUpdateInput : GraphQLInputObject<BlogUpdateInput>
{
    /// <summary>
    /// Indicates whether readers can post comments to the blog and whether comments are moderated.
    /// </summary>
    [JsonPropertyName("commentPolicy")]
    public CommentPolicy? commentPolicy { get; set; } = null;

    /// <summary>
    /// A unique, human-friendly string for the blog. If no handle is specified, a
    /// handle will be generated automatically from the blog title.
    /// The handle is customizable and is used by the Liquid templating language to refer to the blog.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Attaches additional metadata to a store's resources.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// Whether to redirect blog posts automatically.
    /// </summary>
    [JsonPropertyName("redirectArticles")]
    public bool? redirectArticles { get; set; } = null;

    /// <summary>
    /// Whether a redirect is required after a new handle has been provided.
    /// If `true`, then the old handle is redirected to the new one automatically.
    /// </summary>
    [JsonPropertyName("redirectNewHandle")]
    public bool? redirectNewHandle { get; set; } = null;

    /// <summary>
    /// The name of the template a blog is using if it's using an alternate template.
    /// Returns `null` if a blog is using the default blog.liquid template.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;

    /// <summary>
    /// The title of the blog.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}