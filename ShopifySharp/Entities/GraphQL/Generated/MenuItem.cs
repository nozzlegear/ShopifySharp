#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A menu item for display on the storefront.
/// </summary>
public record MenuItem : IGraphQLObject
{
    /// <summary>
    /// A globally-unique ID of the navigation menu item.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// List of the menu items nested under this item sorted by position.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<MenuItem>? items { get; set; } = null;

    /// <summary>
    /// The ID of the resource to link to.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? resourceId { get; set; } = null;

    /// <summary>
    /// The menu item's tags to filter a collection.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

    /// <summary>
    /// The menu item's title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The menu item's type.
    /// </summary>
    [JsonPropertyName("type")]
    public MenuItemType? type { get; set; } = null;

    /// <summary>
    /// The menu item's url.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}