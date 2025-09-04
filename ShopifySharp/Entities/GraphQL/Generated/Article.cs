#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An article in the blogging system.
/// </summary>
public record Article : IGraphQLUnionCase, IGraphQLObject, IHasEvents, IHasMetafieldDefinitions, IHasMetafields, IHasPublishedTranslations, INavigable, INode
{
    /// <summary>
    /// The name of the author of the article.
    /// </summary>
    [JsonPropertyName("author")]
    public ArticleAuthor? author { get; set; } = null;

    /// <summary>
    /// The blog containing the article.
    /// </summary>
    [JsonPropertyName("blog")]
    public Blog? blog { get; set; } = null;

    /// <summary>
    /// The text of the article's body, complete with HTML markup.
    /// </summary>
    [JsonPropertyName("body")]
    public string? body { get; set; } = null;

    /// <summary>
    /// List of the article's comments.
    /// </summary>
    [JsonPropertyName("comments")]
    public CommentConnection? comments { get; set; } = null;

    /// <summary>
    /// Count of comments. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("commentsCount")]
    public Count? commentsCount { get; set; } = null;

    /// <summary>
    /// The date and time (ISO 8601 format) when the article was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// A default [cursor](https://shopify.dev/api/usage/pagination-graphql) that
    /// returns the single next record, sorted ascending by ID.
    /// </summary>
    [JsonPropertyName("defaultCursor")]
    public string? defaultCursor { get; set; } = null;

    /// <summary>
    /// The paginated list of events associated with the host subject.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// A unique, human-friendly string for the article that's automatically generated from the article's title.
    /// The handle is used in the article's URL.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The image associated with the article.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// Whether or not the article is visible.
    /// </summary>
    [JsonPropertyName("isPublished")]
    public bool? isPublished { get; set; } = null;

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
    /// The date and time (ISO 8601 format) when the article became or will become visible.
    /// Returns null when the article isn't visible.
    /// </summary>
    [JsonPropertyName("publishedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? publishedAt { get; set; } = null;

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
    /// The name of the template an article is using if it's using an alternate template.
    /// If an article is using the default `article.liquid` template, then the value returned is `null`.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;

    /// <summary>
    /// The title of the article.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The date and time (ISO 8601 format) when the article was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;
}