#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for an inventory shipment's tracking information.
/// </summary>
public record InventoryShipmentTrackingInput : GraphQLInputObject<InventoryShipmentTrackingInput>
{
    /// <summary>
    /// The estimated date and time that the shipment will arrive.
    /// </summary>
    [JsonPropertyName("arrivesAt")]
    public DateTime? arrivesAt { get; set; } = null;

    /// <summary>
    /// The name of the shipping carrier company.
    /// Given a shipping carrier company name from
    /// [the list](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentTrackingInfo#field-company),
    /// Shopify can build a tracking URL for a provided tracking number.
    /// </summary>
    [JsonPropertyName("company")]
    public string? company { get; set; } = null;

    /// <summary>
    /// The tracking number for the shipment.
    /// </summary>
    [JsonPropertyName("trackingNumber")]
    public string? trackingNumber { get; set; } = null;

    /// <summary>
    /// The URL to track the shipment.
    /// Use this field to specify a custom tracking URL. If no custom tracking URL is set, Shopify will automatically provide
    /// this field on query for a tracking number and a supported shipping carrier company from
    /// [the list](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentTrackingInfo#field-company).
    /// </summary>
    [JsonPropertyName("trackingUrl")]
    public string? trackingUrl { get; set; } = null;
}