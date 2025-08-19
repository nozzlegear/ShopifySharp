#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A menu for display on the storefront.
/// </summary>
public record Menu : IGraphQLObject, IHasPublishedTranslations, INode
{
    /// <summary>
    /// The menu's handle.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the menu is a default. The handle for default menus can't be updated and default menus can't be deleted.
    /// </summary>
    [JsonPropertyName("isDefault")]
    public bool? isDefault { get; set; } = null;

    /// <summary>
    /// A list of items on the menu sorted by position.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<MenuItem>? items { get; set; } = null;

    /// <summary>
    /// The menu's title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;
}