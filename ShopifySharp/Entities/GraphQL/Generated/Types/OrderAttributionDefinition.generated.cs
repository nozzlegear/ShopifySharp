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
/// An attribution definition that an app can use to label orders it routes to a shop.
/// Definitions can be supplied declaratively via the `order_attribution_config` extension or created
/// dynamically per-shop via the Admin API.
/// Learn more in the [order attribution guide](https://shopify.dev/docs/apps/build/sales-channels/order-attribution).
/// </summary>
public record OrderAttributionDefinition : IGraphQLObject, INode
{
    /// <summary>
    /// A human-readable name for the definition, displayed in Shopify Admin and on order details.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// A unique identifier for the definition, scoped to the calling app on a single
    /// shop. Used as the `attribution_handle` value when an app attributes an order
    /// to this definition.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Sanitized SVG content used as the icon for orders attributed to this definition. May be null when no icon is provided.
    /// </summary>
    [JsonPropertyName("icon")]
    public string? icon { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}