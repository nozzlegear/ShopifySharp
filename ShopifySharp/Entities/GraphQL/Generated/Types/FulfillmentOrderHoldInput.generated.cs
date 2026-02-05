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
/// The input fields for the fulfillment hold applied on the fulfillment order.
/// </summary>
public record FulfillmentOrderHoldInput : GraphQLInputObject<FulfillmentOrderHoldInput>
{
    /// <summary>
    /// A configurable ID used to track the automation system releasing these holds.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? externalId { get; set; } = null;

    /// <summary>
    /// The fulfillment order line items to be placed on hold.
    /// If left blank, all line items of the fulfillment order are placed on hold.
    /// Not supported when placing a hold on a fulfillment order that is already held.
    /// If supplied when a fulfillment order is already on hold, [a user error](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderHoldUserErrorCode#value-fulfillmentordernotsplittable)
    /// will be returned indicating that the fulfillment order is not able to be split.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderLineItems")]
    public ICollection<FulfillmentOrderLineItemInput>? fulfillmentOrderLineItems { get; set; } = null;

    /// <summary>
    /// An identifier that an app can use to reference one of the holds that it applies to a
    /// fulfillment order.
    /// This field must be unique among the holds that a single app applies to a single fulfillment order.
    /// It prevents apps from inadvertently creating duplicate holds.
    /// This field cannot exceed 64 characters.
    /// For example, an app can place multiple holds on a single fulfillment order each with a different `handle`.
    /// If an app attempts to place two holds with the same `handle`, the second hold will be rejected with
    /// [a duplicate hold user error](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderHoldUserErrorCode#value-duplicatefulfillmentholdhandle).
    /// The same `handle` can however be re-used on different fulfillment orders and by different apps.
    /// By default, `handle` will be an empty string. If an app wishes to place multiple holds on a single
    /// fulfillment order, then a different `handle` must be provided for each.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Whether the merchant receives a notification about the fulfillment hold. The default value is `false`.
    /// </summary>
    [JsonPropertyName("notifyMerchant")]
    public bool? notifyMerchant { get; set; } = null;

    /// <summary>
    /// The reason for the fulfillment hold.
    /// </summary>
    [JsonPropertyName("reason")]
    public FulfillmentHoldReason? reason { get; set; } = null;

    /// <summary>
    /// Additional information about the fulfillment hold reason.
    /// </summary>
    [JsonPropertyName("reasonNotes")]
    public string? reasonNotes { get; set; } = null;
}