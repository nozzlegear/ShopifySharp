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
/// The fulfillment order's assigned location. This is the location where the fulfillment is expected to happen.
///  The fulfillment order's assigned location might change in the following cases:
///   - The fulfillment order has been entirely moved to a new location. For example, the [fulfillmentOrderMove](
///     https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentOrderMove
///     ) mutation has been called, and you see the original fulfillment order in the [movedFulfillmentOrder](
///     https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentOrderMove#field-fulfillmentordermovepayload-movedfulfillmentorder
///     ) field within the mutation's response.
///   - Work on the fulfillment order has not yet begun, which means that the fulfillment order has the
///       [OPEN](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderStatus#value-open),
///       [SCHEDULED](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderStatus#value-scheduled), or
///       [ON_HOLD](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderStatus#value-onhold)
///       status, and the shop's location properties might be undergoing edits (for example, in the Shopify admin).
/// If the [fulfillmentOrderMove](
/// https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentOrderMove
/// ) mutation has moved the fulfillment order's line items to a new location,
/// but hasn't moved the fulfillment order instance itself, then the original fulfillment order's assigned location
/// doesn't change.
/// This happens if the fulfillment order is being split during the move, or if all line items can be moved
/// to an existing fulfillment order at a new location.
/// Once the fulfillment order has been taken into work or canceled,
/// which means that the fulfillment order has the
/// [IN_PROGRESS](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderStatus#value-inprogress),
/// [CLOSED](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderStatus#value-closed),
/// [CANCELLED](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderStatus#value-cancelled), or
/// [INCOMPLETE](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderStatus#value-incomplete)
/// status, `FulfillmentOrderAssignedLocation` acts as a snapshot of the shop's location content.
/// Up-to-date shop's location data may be queried through [location](
///   https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrderAssignedLocation#field-fulfillmentorderassignedlocation-location
/// ) connection.
/// </summary>
public record FulfillmentOrderAssignedLocation : IGraphQLObject
{
    /// <summary>
    /// The first line of the address for the location.
    /// </summary>
    [JsonPropertyName("address1")]
    public string? address1 { get; set; } = null;

    /// <summary>
    /// The second line of the address for the location.
    /// </summary>
    [JsonPropertyName("address2")]
    public string? address2 { get; set; } = null;

    /// <summary>
    /// The city of the location.
    /// </summary>
    [JsonPropertyName("city")]
    public string? city { get; set; } = null;

    /// <summary>
    /// The two-letter country code of the location.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// The location where the fulfillment is expected to happen. This value might be different from
    /// `FulfillmentOrderAssignedLocation` if the location's attributes were updated
    /// after the fulfillment order was taken into work of canceled.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The name of the location.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The phone number of the location.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The province of the location.
    /// </summary>
    [JsonPropertyName("province")]
    public string? province { get; set; } = null;

    /// <summary>
    /// The ZIP code of the location.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;
}