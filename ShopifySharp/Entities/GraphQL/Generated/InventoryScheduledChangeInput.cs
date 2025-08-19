#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a scheduled change of an inventory item.
/// </summary>
public record InventoryScheduledChangeInput : GraphQLInputObject<InventoryScheduledChangeInput>
{
    /// <summary>
    /// The date and time that the scheduled change is expected to happen.
    /// </summary>
    [JsonPropertyName("expectedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? expectedAt { get; set; } = null;

    /// <summary>
    /// The quantity
    /// [name](https://shopify.dev/docs/apps/fulfillment/inventory-management-apps/quantities-states#move-inventory-quantities-between-states)
    /// to transition from.
    /// </summary>
    [JsonPropertyName("fromName")]
    public string? fromName { get; set; } = null;

    /// <summary>
    /// The quantity
    /// [name](https://shopify.dev/docs/apps/fulfillment/inventory-management-apps/quantities-states#move-inventory-quantities-between-states)
    /// to transition to.
    /// </summary>
    [JsonPropertyName("toName")]
    public string? toName { get; set; } = null;
}