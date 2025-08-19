#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to update a valid menu item.
/// </summary>
public record MenuItemUpdateInput : GraphQLInputObject<MenuItemUpdateInput>
{
    /// <summary>
    /// A globally-unique ID of the online store navigation menu item.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// List of the menu items nested under this item sorted by position.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<MenuItemUpdateInput>? items { get; set; } = null;

    /// <summary>
    /// The menu item's association with an existing resource.
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
    /// The menu item's url to be used when the item doesn't point to a resource.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}