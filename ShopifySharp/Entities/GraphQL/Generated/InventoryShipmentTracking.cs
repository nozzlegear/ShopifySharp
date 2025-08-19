#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the tracking information for an inventory shipment.
/// </summary>
public record InventoryShipmentTracking : IGraphQLObject
{
    /// <summary>
    /// The estimated date and time that the shipment will arrive.
    /// </summary>
    [JsonPropertyName("arrivesAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? arrivesAt { get; set; } = null;

    /// <summary>
    /// The name of the shipping carrier company.
    /// </summary>
    [JsonPropertyName("company")]
    public string? company { get; set; } = null;

    /// <summary>
    /// The tracking number used by the carrier to identify the shipment.
    /// </summary>
    [JsonPropertyName("trackingNumber")]
    public string? trackingNumber { get; set; } = null;

    /// <summary>
    /// The URL to track the shipment.
    /// Given a tracking number and a shipping carrier company name from
    /// [the list](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentTrackingInfo#field-company),
    /// Shopify will return a generated tracking URL if no tracking URL was set manually.
    /// </summary>
    [JsonPropertyName("trackingUrl")]
    public string? trackingUrl { get; set; } = null;
}