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
/// Navigation menus that organize links into logical structures to guide customers
/// through a store. Menus serve as the backbone of store navigation, making it easy
/// for customers to find products, pages, and other content through organized
/// hierarchical links.
/// For example, a merchant might create a main navigation menu with top-level
/// categories like "Products," "About Us," and "Contact," where each category can
/// contain nested menu items linking to specific collections, pages, or external resources.
/// Use the `Menu` object to:
/// - Build and customize store navigation structures
/// - Organize hierarchical menu systems with nested items
/// - Work with default menus that can't be deleted
/// - Access menu items for building navigation
/// Menus can be designated as default navigation elements (like main menu or
/// footer), which can't be deleted and have restricted handle updates. The handle
/// provides a unique identifier that themes can reference, while the items
/// collection enables nested navigation structures.
/// Each menu contains menu items that can link to various resource types. This
/// flexibility lets merchants create navigation experiences that guide customers
/// through their store.
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