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
/// Individual navigation links that make up store menus, giving customers clickable
/// paths to explore the store. Menu items are the building blocks that connect
/// shoppers to products, collections, pages, or external resources.
/// For example, within a "Products" menu, individual menu items might link to
/// specific collections like "Summer Collection" or "Best Sellers," each with its
/// own title, URL, and resource connection.
/// Use the `MenuItem` object to:
/// - Define individual navigation links and their destinations
/// - Create nested menu hierarchies through item relationships
/// - Use tags for collection filtering
/// - Connect menu links to specific store resources
/// Menu items support various link types, enabling connections to internal store
/// content or external websites. The nested items capability allows for dropdown or
/// multi-level navigation structures that help organize complex store catalogs.
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