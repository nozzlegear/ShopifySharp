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
/// The input fields for the fulfillment order, shipping date and time, package
/// details, weight, notification setting, and optional rate preference used to
/// purchase a shipping label.
/// </summary>
public record ShippingLabelPurchaseInput : GraphQLInputObject<ShippingLabelPurchaseInput>
{
    /// <summary>
    /// The ID of the fulfillment order to create the shipping label for. The
    /// fulfillment order must be fulfillable, require shipping, and have a
    /// destination shipping address.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderId")]
    public string? fulfillmentOrderId { get; set; } = null;

    /// <summary>
    /// Whether to notify the customer after the shipping label is purchased.
    /// </summary>
    [JsonPropertyName("notifyCustomer")]
    public bool? notifyCustomer { get; set; } = null;

    /// <summary>
    /// A custom ship-from origin address that overrides the fulfillment order's
    /// assigned location for this label. If not provided, the assigned location is used.
    /// </summary>
    [JsonPropertyName("originAddress")]
    public MailingAddressInput? originAddress { get; set; } = null;

    /// <summary>
    /// The package to use for the shipment. Provide either a custom package or a carrier-provided package.
    /// </summary>
    [JsonPropertyName("packageInfo")]
    public PackageInfoInput? packageInfo { get; set; } = null;

    /// <summary>
    /// The preferred carrier and service to use for the shipping label. If omitted,
    /// the mutation uses Shopify Shipping's default rate selection.
    /// </summary>
    [JsonPropertyName("preferredRateSelection")]
    public PreferredRateSelectionInput? preferredRateSelection { get; set; } = null;

    /// <summary>
    /// The date and time when the package is expected to be shipped. The value must not be in the past.
    /// </summary>
    [JsonPropertyName("shippingDatetime")]
    public DateTimeOffset? shippingDatetime { get; set; } = null;

    /// <summary>
    /// Total shipment weight, including the items being fulfilled and the package. If
    /// omitted, the total weight used is calculated using the weight of the empty
    /// package and the weight of the fulfillable line items.
    /// </summary>
    [JsonPropertyName("totalWeight")]
    public WeightInput? totalWeight { get; set; } = null;
}