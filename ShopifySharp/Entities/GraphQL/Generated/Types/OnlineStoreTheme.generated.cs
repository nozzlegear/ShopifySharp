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
/// A theme for display on the storefront. Themes control the visual appearance and
/// functionality of the online store through templates, stylesheets, and assets
/// that determine how
/// [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product), [collections](https://shopify.dev/docs/api/admin-graphql/latest/objects/Collection),
/// and other content display to customers.
/// Each theme has a [role](https://shopify.dev/docs/api/admin-graphql/latest/objects/OnlineStoreTheme#field-OnlineStoreTheme.fields.role)
/// that indicates its status. Main themes are live on the storefront, unpublished
/// themes are inactive, demo themes require purchase before publishing, and
/// development themes are temporary for previewing during development. The theme includes [translations](https://shopify.dev/docs/api/admin-graphql/latest/objects/OnlineStoreTheme#field-OnlineStoreTheme.fields.translations)
/// for multi-language support.
/// </summary>
public record OnlineStoreTheme : IGraphQLObject, IHasPublishedTranslations, INode
{
    /// <summary>
    /// The date and time when the theme was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The files in the theme.
    /// </summary>
    [JsonPropertyName("files")]
    public OnlineStoreThemeFileConnection? files { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the theme, set by the merchant.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The prefix of the theme.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? prefix { get; set; } = null;

    /// <summary>
    /// Whether the theme is processing.
    /// </summary>
    [JsonPropertyName("processing")]
    public bool? processing { get; set; } = null;

    /// <summary>
    /// Whether the theme processing failed.
    /// </summary>
    [JsonPropertyName("processingFailed")]
    public bool? processingFailed { get; set; } = null;

    /// <summary>
    /// The role of the theme.
    /// </summary>
    [JsonPropertyName("role")]
    public ThemeRole? role { get; set; } = null;

    /// <summary>
    /// The theme store ID.
    /// </summary>
    [JsonPropertyName("themeStoreId")]
    public int? themeStoreId { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The date and time when the theme was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}