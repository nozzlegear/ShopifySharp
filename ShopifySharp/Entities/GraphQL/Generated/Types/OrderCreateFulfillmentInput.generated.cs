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
/// The input fields for a fulfillment to create for an order.
/// </summary>
public record OrderCreateFulfillmentInput : GraphQLInputObject<OrderCreateFulfillmentInput>
{
    /// <summary>
    /// The ID of the location to fulfill the order from.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// Whether the customer should be notified of changes with the fulfillment.
    /// </summary>
    [JsonPropertyName("notifyCustomer")]
    public bool? notifyCustomer { get; set; } = null;

    /// <summary>
    /// The address at which the fulfillment occurred.
    /// </summary>
    [JsonPropertyName("originAddress")]
    public FulfillmentOriginAddressInput? originAddress { get; set; } = null;

    /// <summary>
    /// The status of the shipment.
    /// </summary>
    [JsonPropertyName("shipmentStatus")]
    public FulfillmentEventStatus? shipmentStatus { get; set; } = null;

    /// <summary>
    /// The name of the tracking company.
    /// If you specify a tracking company name from
    /// [the list](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentTrackingInfo#supported-tracking-companies),
    /// Shopify will automatically build tracking URLs for all provided tracking numbers,
    /// which will make the tracking numbers clickable in the interface.
    /// The same tracking company will be applied to all tracking numbers specified.
    /// Additionally, for the tracking companies listed on the
    /// [Shipping Carriers help page](https://help.shopify.com/manual/shipping/understanding-shipping/shipping-carriers#integrated-shipping-carriers)
    /// Shopify will automatically update the fulfillment's `shipment_status` field during the fulfillment process.
    /// > Note:
    /// > Send the tracking company name exactly as written in
    /// > [the list](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentTrackingInfo#supported-tracking-companies)
    /// > (capitalization matters).
    /// </summary>
    [JsonPropertyName("trackingCompany")]
    public string? trackingCompany { get; set; } = null;

    /// <summary>
    /// The tracking number of the fulfillment.
    /// The tracking number will be clickable in the interface if one of the following applies
    /// (the highest in the list has the highest priority):
    /// * [Shopify-known tracking company name](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentTrackingInfo#supported-tracking-companies)
    ///   specified in the `company` field.
    ///   Shopify will build the tracking URL automatically based on the tracking number specified.
    /// * The tracking number has a Shopify-known format.
    ///   Shopify will guess the tracking provider and build the tracking url based on the tracking number format.
    ///   Not all tracking carriers are supported, and multiple tracking carriers may use similarly formatted tracking numbers.
    ///   This can result in an invalid tracking URL.
    /// </summary>
    [JsonPropertyName("trackingNumber")]
    public string? trackingNumber { get; set; } = null;
}