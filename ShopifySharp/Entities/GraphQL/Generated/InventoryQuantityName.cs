#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Details about an individual quantity name.
/// </summary>
public record InventoryQuantityName : IGraphQLObject
{
    /// <summary>
    /// List of quantity names that this quantity name belongs to.
    /// </summary>
    [JsonPropertyName("belongsTo")]
    public ICollection<string>? belongsTo { get; set; } = null;

    /// <summary>
    /// List of quantity names that comprise this quantity name.
    /// </summary>
    [JsonPropertyName("comprises")]
    public ICollection<string>? comprises { get; set; } = null;

    /// <summary>
    /// The display name for quantity names translated into applicable language.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// Whether the quantity name has been used by the merchant.
    /// </summary>
    [JsonPropertyName("isInUse")]
    public bool? isInUse { get; set; } = null;

    /// <summary>
    /// The [name](https://shopify.dev/docs/apps/fulfillment/inventory-management-apps#inventory-states) of
    /// the inventory quantity. Used by
    /// [inventory queries and mutations](https://shopify.dev/docs/apps/fulfillment/inventory-management-apps#graphql-queries-and-mutations).
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}