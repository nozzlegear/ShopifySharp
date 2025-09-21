#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to create a blog.
/// </summary>
public record BlogCreateInput : GraphQLInputObject<BlogCreateInput>
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