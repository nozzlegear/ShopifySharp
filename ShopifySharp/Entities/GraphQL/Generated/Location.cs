#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the location where the physical good resides. You can stock inventory at active locations. Active
/// locations that have `fulfills_online_orders: true` and are configured with a shipping rate, pickup enabled or
/// local delivery will be able to sell from their storefront.
/// </summary>
public record Location : IGraphQLUnionCase, IGraphQLObject, IHasMetafieldDefinitions, IHasMetafields, ILegacyInteroperability, INode
{
    /// <summary>
    /// Whether the location can be reactivated. If `false`, then trying to activate the location with the
    /// [`LocationActivate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/locationActivate)
    /// mutation will return an error that describes why the location can't be activated.
    /// </summary>
    [JsonPropertyName("activatable")]
    public bool? activatable { get; set; } = null;

    /// <summary>
    /// The address of this location.
    /// </summary>
    [JsonPropertyName("address")]
    public LocationAddress? address { get; set; } = null;

    /// <summary>
    /// Whether the location address has been verified.
    /// </summary>
    [JsonPropertyName("addressVerified")]
    public bool? addressVerified { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) that the location was added to a shop.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// Whether this location can be deactivated. If `true`, then the location can be deactivated by calling the
    /// [`LocationDeactivate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/locationDeactivate)
    /// mutation. If `false`, then calling the mutation to deactivate it will return an error that describes why the
    /// location can't be deactivated.
    /// </summary>
    [JsonPropertyName("deactivatable")]
    public bool? deactivatable { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601))
    /// that the location was deactivated at. For example, 3:30 pm on September 7,
    /// 2019 in the time zone of UTC (Universal Time Coordinated) is represented as
    /// `"2019-09-07T15:50:00Z`".
    /// </summary>
    [JsonPropertyName("deactivatedAt")]
    public string? deactivatedAt { get; set; } = null;

    /// <summary>
    /// Whether this location can be deleted.
    /// </summary>
    [JsonPropertyName("deletable")]
    public bool? deletable { get; set; } = null;

    /// <summary>
    /// Name of the service provider that fulfills from this location.
    /// </summary>
    [JsonPropertyName("fulfillmentService")]
    public FulfillmentService? fulfillmentService { get; set; } = null;

    /// <summary>
    /// Whether this location can fulfill online orders.
    /// </summary>
    [JsonPropertyName("fulfillsOnlineOrders")]
    public bool? fulfillsOnlineOrders { get; set; } = null;

    /// <summary>
    /// Whether this location has active inventory.
    /// </summary>
    [JsonPropertyName("hasActiveInventory")]
    public bool? hasActiveInventory { get; set; } = null;

    /// <summary>
    /// Whether this location has orders that need to be fulfilled.
    /// </summary>
    [JsonPropertyName("hasUnfulfilledOrders")]
    public bool? hasUnfulfilledOrders { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The quantities of an inventory item at this location.
    /// </summary>
    [JsonPropertyName("inventoryLevel")]
    public InventoryLevel? inventoryLevel { get; set; } = null;

    /// <summary>
    /// A list of the quantities of the inventory items that can be stocked at this location.
    /// </summary>
    [JsonPropertyName("inventoryLevels")]
    public InventoryLevelConnection? inventoryLevels { get; set; } = null;

    /// <summary>
    /// Whether the location is active. A deactivated location can be activated (change `isActive: true`) if it has
    /// `activatable` set to `true` by calling the
    /// [`locationActivate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/locationActivate)
    /// mutation.
    /// </summary>
    [JsonPropertyName("isActive")]
    public bool? isActive { get; set; } = null;

    /// <summary>
    /// Whether this location is a fulfillment service.
    /// </summary>
    [JsonPropertyName("isFulfillmentService")]
    public bool? isFulfillmentService { get; set; } = null;

    /// <summary>
    /// Whether the location is your primary location for shipping inventory.
    /// </summary>
    [JsonPropertyName("isPrimary")]
    [Obsolete("The concept of a primary location is deprecated, shipsInventory can be used to get a fallback location")]
    public bool? isPrimary { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// Local pickup settings for the location.
    /// </summary>
    [JsonPropertyName("localPickupSettingsV2")]
    public DeliveryLocalPickupSettings? localPickupSettingsV2 { get; set; } = null;

    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; } = null;

    /// <summary>
    /// List of metafield definitions.
    /// </summary>
    [JsonPropertyName("metafieldDefinitions")]
    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public MetafieldDefinitionConnection? metafieldDefinitions { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// The name of the location.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Whether this location is used for calculating shipping rates. In multi-origin shipping mode, this flag is ignored.
    /// </summary>
    [JsonPropertyName("shipsInventory")]
    public bool? shipsInventory { get; set; } = null;

    /// <summary>
    /// List of suggested addresses for this location (empty if none).
    /// </summary>
    [JsonPropertyName("suggestedAddresses")]
    public ICollection<LocationSuggestedAddress>? suggestedAddresses { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the location was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;
}