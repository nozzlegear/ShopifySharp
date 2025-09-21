#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The `MediaImage` object represents an image hosted on Shopify's
/// [content delivery network (CDN)](https://shopify.dev/docs/storefronts/themes/best-practices/performance/platform#shopify-cdn).
/// Shopify CDN is a content system that serves as the primary way to store,
/// manage, and deliver visual content for products, variants, and other resources across the Shopify platform.
/// The `MediaImage` object provides information to:
/// - Store and display product and variant images across online stores, admin interfaces, and mobile apps.
/// - Retrieve visual branding elements, including logos, banners, favicons, and background images in checkout flows.
/// - Retrieve signed URLs for secure, time-limited access to original image files.
/// Each `MediaImage` object provides both the processed image data (with automatic optimization and CDN delivery)
/// and access to the original source file. The image processing is handled asynchronously, so images
/// might not be immediately available after upload. The
/// [`status`](https://shopify.dev/docs/api/admin-graphql/latest/objects/mediaimage#field-MediaImage.fields.status)
/// field indicates when processing is complete and the image is ready for use.
/// The `MediaImage` object implements the [`Media`](https://shopify.dev/docs/api/admin-graphql/latest/interfaces/Media)
/// interface alongside other media types, like videos and 3D models.
/// Learn about
/// managing media for [products](https://shopify.dev/docs/apps/build/online-store/product-media),
/// [product variants](https://shopify.dev/docs/apps/build/online-store/product-variant-media), and
/// [asynchronous media management](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/product-model-components#asynchronous-media-management).
/// </summary>
public record MediaImage : IGraphQLUnionCase, IGraphQLObject, IFile, IHasMetafields, IMedia, INode
{
    /// <summary>
    /// A word or phrase to share the nature or contents of a media.
    /// </summary>
    [JsonPropertyName("alt")]
    public string? alt { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the file was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// Any errors that have occurred on the file.
    /// </summary>
    [JsonPropertyName("fileErrors")]
    public ICollection<FileError>? fileErrors { get; set; } = null;

    /// <summary>
    /// The status of the file.
    /// </summary>
    [JsonPropertyName("fileStatus")]
    public FileStatus? fileStatus { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The image for the media. Returns `null` until `status` is `READY`.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// The media content type.
    /// </summary>
    [JsonPropertyName("mediaContentType")]
    public MediaContentType? mediaContentType { get; set; } = null;

    /// <summary>
    /// Any errors which have occurred on the media.
    /// </summary>
    [JsonPropertyName("mediaErrors")]
    public ICollection<MediaError>? mediaErrors { get; set; } = null;

    /// <summary>
    /// The warnings attached to the media.
    /// </summary>
    [JsonPropertyName("mediaWarnings")]
    public ICollection<MediaWarning>? mediaWarnings { get; set; } = null;

    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    [Obsolete("No longer supported. Use metaobjects instead.")]
    public Metafield? metafield { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    [Obsolete("No longer supported. Use metaobjects instead.")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// The MIME type of the image.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string? mimeType { get; set; } = null;

    /// <summary>
    /// The original source of the image.
    /// </summary>
    [JsonPropertyName("originalSource")]
    public MediaImageOriginalSource? originalSource { get; set; } = null;

    /// <summary>
    /// The preview image for the media.
    /// </summary>
    [JsonPropertyName("preview")]
    public MediaPreviewImage? preview { get; set; } = null;

    /// <summary>
    /// Current status of the media.
    /// </summary>
    [JsonPropertyName("status")]
    public MediaStatus? status { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the file was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; } = null;
}