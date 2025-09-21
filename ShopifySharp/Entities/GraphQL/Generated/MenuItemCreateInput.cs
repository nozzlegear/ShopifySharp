#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create a valid menu item.
/// </summary>
public record MenuItemCreateInput : GraphQLInputObject<MenuItemCreateInput>
{
    /// <summary>
    /// List of the menu items nested under this item sorted by position.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<MenuItemCreateInput>? items { get; set; } = null;

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