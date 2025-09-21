#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A theme for display on the storefront.
/// </summary>
public record OnlineStoreTheme : IGraphQLObject, IHasPublishedTranslations, INode
{
    /// <summary>
    /// The date and time when the theme was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

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
    public DateTime? updatedAt { get; set; } = null;
}