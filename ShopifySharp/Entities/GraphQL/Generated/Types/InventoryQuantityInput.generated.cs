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
    /// The current quantity to be compared against the persisted quantity.
    /// Explicitly passing in `null` to this field opts out of the quantity comparison check.
    /// Explicitly passing in any value (be it `null` or an integer) to `changeFromQuantity` will cause the values
    /// passed into the `compareQuantity` and `InventorySetQuantitiesInput.ignoreCompareQuantity` fields to be
    /// ignored in favour of the `changeFromQuantity` value. For more information,
    /// refer to the [Compare and Swap documentation](https://shopify.dev/docs/apps/build/orders-fulfillment/inventory-management-apps/manage-quantities-states#compare-and-swap).
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