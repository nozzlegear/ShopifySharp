#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents an image resource.
/// </summary>
public record Image : IGraphQLObject, IHasMetafields
{
    /// <summary>
    /// A word or phrase to share the nature or contents of an image.
    /// </summary>
    [JsonPropertyName("altText")]
    public string? altText { get; set; } = null;

    /// <summary>
    /// The original height of the image in pixels. Returns `null` if the image isn't hosted by Shopify.
    /// </summary>
    [JsonPropertyName("height")]
    public int? height { get; set; } = null;

    /// <summary>
    /// A unique ID for the image.
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
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// The location of the original image as a URL.
    /// If there are any existing transformations in the original source URL, they will remain and not be stripped.
    /// </summary>
    [JsonPropertyName("originalSrc")]
    [Obsolete("Use `url` instead.")]
    public string? originalSrc { get; set; } = null;

    /// <summary>
    /// The location of the image as a URL.
    /// </summary>
    [JsonPropertyName("src")]
    [Obsolete("Use `url` instead.")]
    public string? src { get; set; } = null;

    /// <summary>
    /// The ThumbHash of the image.
    /// Useful to display placeholder images while the original image is loading.
    /// </summary>
    [JsonPropertyName("thumbhash")]
    public string? thumbhash { get; set; } = null;

    /// <summary>
    /// The location of the transformed image as a URL.
    /// All transformation arguments are considered "best-effort". If they can be applied to an image, they will be.
    /// Otherwise any transformations which an image type doesn't support will be ignored.
    /// </summary>
    [JsonPropertyName("transformedSrc")]
    [Obsolete("Use `url(transform:)` instead")]
    public string? transformedSrc { get; set; } = null;

    /// <summary>
    /// The location of the image as a URL.
    /// If no transform options are specified, then the original image will be preserved including any pre-applied transforms.
    /// All transformation options are considered "best-effort". Any transformation
    /// that the original image type doesn't support will be ignored.
    /// If you need multiple variations of the same image, then you can use [GraphQL
    /// aliases](https://graphql.org/learn/queries/#aliases).
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;

    /// <summary>
    /// The original width of the image in pixels. Returns `null` if the image isn't hosted by Shopify.
    /// </summary>
    [JsonPropertyName("width")]
    public int? width { get; set; } = null;
}