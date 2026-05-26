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
/// The input fields for the quantity to be set for an inventory item at a location.
/// </summary>
public record InventoryQuantityInput : GraphQLInputObject<InventoryQuantityInput>
{
    /// <summary>
    /// The quantity currently expected at this location, before setting the new quantity.
    /// This field enables a compare-and-swap (CAS) safety check. If the location’s
    /// current quantity doesn't match the value you provide, then the mutation fails
    /// with a `CHANGE_FROM_QUANTITY_STALE` error. This helps prevent unintended
    /// overwrites when the request is based on stale inventory data.
    /// To skip the CAS check, pass `null`. Use this only when your system is the
    /// source of truth for this inventory and you don’t need to protect against
    /// concurrent updates.
    /// This field is mandatory: you must explicitly pass in a value, even if that
    /// value is `null`, or the mutation returns an error.
    /// For more information, refer to the [compare and swap documentation](https://shopify.dev/docs/apps/build/orders-fulfillment/inventory-management-apps/manage-quantities-states#compare-and-swap).
    /// </summary>
    [JsonPropertyName("changeFromQuantity")]
    public int? changeFromQuantity { get; set; } = null;

    /// <summary>
    /// Specifies the inventory item to which the quantity will be set.
    /// </summary>
    [JsonPropertyName("inventoryItemId")]
    public string? inventoryItemId { get; set; } = null;

    /// <summary>
    /// Specifies the location at which the quantity will be set.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// The quantity to which the inventory quantity will be set.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}