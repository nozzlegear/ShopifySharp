#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Shopify stores come with a built-in blogging engine, allowing a shop to have one or more blogs.  Blogs are meant
/// to be used as a type of magazine or newsletter for the shop, with content that changes over time.
/// </summary>
public record Blog : IGraphQLUnionCase, IGraphQLObject, IHasEvents, IHasMetafieldDefinitions, IHasMetafields, IHasPublishedTranslations, INode
{
    /// <summary>
    /// List of the blog's articles.
    /// </summary>
    [JsonPropertyName("articles")]
    public ArticleConnection? articles { get; set; } = null;

    /// <summary>
    /// Count of articles. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("articlesCount")]
    public Count? articlesCount { get; set; } = null;

    /// <summary>
    /// Indicates whether readers can post comments to the blog and if comments are moderated or not.
    /// </summary>
    [JsonPropertyName("commentPolicy")]
    public CommentPolicy? commentPolicy { get; set; } = null;

    /// <summary>
    /// The date and time when the blog was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The paginated list of events associated with the host subject.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// FeedBurner provider details. Any blogs that aren't already integrated with FeedBurner can't use the service.
    /// </summary>
    [JsonPropertyName("feed")]
    public BlogFeed? feed { get; set; } = null;

    /// <summary>
    /// A unique, human-friendly string for the blog. If no handle is specified, a
    /// handle will be generated automatically from the blog title.
    /// The handle is customizable and is used by the Liquid templating language to refer to the blog.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; } = null;

    /// <summary>
    /// List of metafield definitions.
    /// </summary>
    [JsonPropertyName("metafieldDefinitions")]
    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public MetafieldDefinitionConnection? metafieldDefinitions { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// A list of tags associated with the 200 most recent blog articles.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

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

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The date and time when the blog was update.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; } = null;
}