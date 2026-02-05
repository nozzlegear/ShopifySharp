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
/// The FulfillmentOrder object represents either an item or a group of items in an
/// [Order](https://shopify.dev/api/admin-graphql/latest/objects/Order)
/// that are expected to be fulfilled from the same location.
/// There can be more than one fulfillment order for an
/// [order](https://shopify.dev/api/admin-graphql/latest/objects/Order)
/// at a given location.
/// {{ '/api/reference/fulfillment_order_relationships.png' | image }}
/// Fulfillment orders represent the work which is intended to be done in relation to an order.
/// When fulfillment has started for one or more line items, a
/// [Fulfillment](https://shopify.dev/api/admin-graphql/latest/objects/Fulfillment)
/// is created by a merchant or third party to represent the ongoing or completed work of fulfillment.
/// [See below for more details on creating fulfillments](#the-lifecycle-of-a-fulfillment-order-at-a-location-which-is-managed-by-a-fulfillment-service).
/// > Note:
/// > Shopify creates fulfillment orders automatically when an order is created.
/// > It is not possible to manually create fulfillment orders.
/// >
/// > [See below for more details on the lifecycle of a fulfillment order](#the-lifecycle-of-a-fulfillment-order).
/// ## Retrieving fulfillment orders
/// ### Fulfillment orders from an order
/// All fulfillment orders related to a given order can be retrieved with the
/// [Order.fulfillmentOrders](https://shopify.dev/api/admin-graphql/latest/objects/Order#connection-order-fulfillmentorders)
/// connection.
/// [API access scopes](#api-access-scopes)
/// govern which fulfillments orders are returned to clients.
/// An API client will only receive a subset of the fulfillment orders which belong to an order
/// if they don't have the necessary access scopes to view all of the fulfillment orders.
/// ### Fulfillment orders assigned to the app for fulfillment
/// Fulfillment service apps can retrieve the fulfillment orders which have been assigned to their locations with the
/// [assignedFulfillmentOrders](https://shopify.dev/api/admin-graphql/2024-07/objects/queryroot#connection-assignedfulfillmentorders)
/// connection.
/// Use the `assignmentStatus` argument to control whether all assigned fulfillment orders
/// should be returned or only those where a merchant has sent a
/// [fulfillment request](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrderMerchantRequest)
/// and it has yet to be responded to.
/// The API client must be granted the `read_assigned_fulfillment_orders` access scope to access
/// the assigned fulfillment orders.
/// ### All fulfillment orders
/// Apps can retrieve all fulfillment orders with the
/// [fulfillmentOrders](https://shopify.dev/api/admin-graphql/latest/queries/fulfillmentOrders)
/// query. This query returns all assigned, merchant-managed, and third-party fulfillment orders on the shop,
/// which are accessible to the app according to the
/// [fulfillment order access scopes](#api-access-scopes) it was granted with.
/// ## The lifecycle of a fulfillment order
/// ### Fulfillment Order Creation
/// After an order is created, a background worker performs the order routing process which determines
/// which locations will be responsible for fulfilling the purchased items.
/// Once the order routing process is complete, one or more fulfillment orders will be created
/// and assigned to these locations. It is not possible to manually create fulfillment orders.
/// Once a fulfillment order has been created, it will have one of two different lifecycles depending on
/// the type of location which the fulfillment order is assigned to.
/// ### The lifecycle of a fulfillment order at a merchant managed location
/// Fulfillment orders are completed by creating
/// [fulfillments](https://shopify.dev/api/admin-graphql/latest/objects/Fulfillment).
/// Fulfillments represents the work done.
/// For digital products a merchant or an order management app would create a fulfilment once the digital asset
/// has been provisioned.
/// For example, in the case of a digital gift card, a merchant would to do this once
/// the gift card has been activated - before the email has been shipped.
/// On the other hand, for a traditional shipped order,
/// a merchant or an order management app would create a fulfillment after picking and packing the items relating
/// to a fulfillment order, but before the courier has collected the goods.
/// [Learn about managing fulfillment orders as an order management app](https://shopify.dev/apps/fulfillment/order-management-apps/manage-fulfillments).
/// ### The lifecycle of a fulfillment order at a location which is managed by a fulfillment service
/// For fulfillment orders which are assigned to a location that is managed by a fulfillment service,
/// a merchant or an Order Management App can
/// [send a fulfillment request](https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentOrderSubmitFulfillmentRequest)
/// to the fulfillment service which operates the location to request that they fulfill the associated items.
/// A fulfillment service has the option to
/// [accept](https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentOrderAcceptFulfillmentRequest)
/// or [reject](https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentOrderRejectFulfillmentRequest)
/// this fulfillment request.
/// Once the fulfillment service has accepted the request, the request can no longer be cancelled by the merchant
/// or order management app and instead a
/// [cancellation request must be submitted](https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentOrderSubmitCancellationRequest)
/// to the fulfillment service.
/// Once a fulfillment service accepts a fulfillment request,
/// then after they are ready to pack items and send them for delivery, they create fulfillments with the
/// [fulfillmentCreate](https://shopify.dev/api/admin-graphql/unstable/mutations/fulfillmentCreate)
/// mutation.
/// They can provide tracking information right away or create fulfillments without it and then
/// update the tracking information for fulfillments with the
/// [fulfillmentTrackingInfoUpdate](https://shopify.dev/api/admin-graphql/unstable/mutations/fulfillmentTrackingInfoUpdate)
/// mutation.
/// [Learn about managing fulfillment orders as a fulfillment service](https://shopify.dev/apps/fulfillment/fulfillment-service-apps/manage-fulfillments).
/// ## API access scopes
/// Fulfillment orders are governed by the following API access scopes:
/// * The `read_merchant_managed_fulfillment_orders` and
///   `write_merchant_managed_fulfillment_orders` access scopes
///   grant access to fulfillment orders assigned to merchant-managed locations.
/// * The `read_assigned_fulfillment_orders` and `write_assigned_fulfillment_orders`
///   access scopes are intended for fulfillment services.
///   These scopes grant access to fulfillment orders assigned to locations that are being managed
///   by fulfillment services.
/// * The `read_third_party_fulfillment_orders` and `write_third_party_fulfillment_orders`
///   access scopes grant access to fulfillment orders
///   assigned to locations managed by other fulfillment services.
/// ### Fulfillment service app access scopes
/// Usually, **fulfillment services** have the `write_assigned_fulfillment_orders` access scope
/// and don't have the `*_third_party_fulfillment_orders`
/// or `*_merchant_managed_fulfillment_orders` access scopes.
/// The app will only have access to the fulfillment orders assigned to their location
/// (or multiple locations if the app registers multiple fulfillment services on the shop).
/// The app will not have access to fulfillment orders assigned to merchant-managed locations
/// or locations owned by other fulfillment service apps.
/// ### Order management app access scopes
/// **Order management apps** will usually request `write_merchant_managed_fulfillment_orders` and
/// `write_third_party_fulfillment_orders` access scopes. This will allow them to manage all fulfillment orders
/// on behalf of a merchant.
/// If an app combines the functions of an order management app and a fulfillment service,
/// then the app should request all
/// access scopes to manage all assigned and all unassigned fulfillment orders.
/// ## Notifications about fulfillment orders
/// Fulfillment services are required to
/// [register](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentService)
/// a self-hosted callback URL which has a number of uses. One of these uses is that this callback URL will be notified
/// whenever a merchant submits a fulfillment or cancellation request.
/// Both merchants and apps can
/// [subscribe](https://shopify.dev/apps/fulfillment/fulfillment-service-apps/manage-fulfillments#webhooks)
/// to the
/// [fulfillment order webhooks](https://shopify.dev/api/admin-graphql/latest/enums/WebhookSubscriptionTopic#value-fulfillmentorderscancellationrequestaccepted)
/// to be notified whenever fulfillment order related domain events occur.
/// [Learn about fulfillment workflows](https://shopify.dev/apps/fulfillment).
/// </summary>
public record FulfillmentOrder : IGraphQLUnionCase, IGraphQLObject, INode
{
    /// <summary>
    /// The fulfillment order's assigned location. This is the location where the fulfillment is expected to happen.
    /// The fulfillment order's assigned location might change in the following cases:
    /// - The fulfillment order has been entirely moved to a new location. For example, the [fulfillmentOrderMove](
    ///   https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentOrderMove
    ///   ) mutation has been called, and you see the original fulfillment order in the [movedFulfillmentOrder](
    ///   https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentOrderMove#field-fulfillmentordermovepayload-movedfulfillmentorder
    ///   ) field within the mutation's response.
    /// - Work on the fulfillment order hasn't yet begun, which means that the fulfillment order has the
    ///     [OPEN](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderStatus#value-open),
    ///     [SCHEDULED](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderStatus#value-scheduled), or
    ///     [ON_HOLD](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderStatus#value-onhold)
    ///     status, and the shop's location properties might be undergoing edits (for example, in the Shopify admin).
    /// </summary>
    [JsonPropertyName("assignedLocation")]
    public FulfillmentOrderAssignedLocation? assignedLocation { get; set; } = null;

    /// <summary>
    /// ID of the channel that created the order.
    /// </summary>
    [JsonPropertyName("channelId")]
    public string? channelId { get; set; } = null;

    /// <summary>
    /// Date and time when the fulfillment order was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// Delivery method of this fulfillment order.
    /// </summary>
    [JsonPropertyName("deliveryMethod")]
    public DeliveryMethod? deliveryMethod { get; set; } = null;

    /// <summary>
    /// The destination where the items should be sent.
    /// </summary>
    [JsonPropertyName("destination")]
    public FulfillmentOrderDestination? destination { get; set; } = null;

    /// <summary>
    /// The date and time at which the fulfillment order will be fulfillable. When
    /// this date and time is reached, the scheduled fulfillment order is
    /// automatically transitioned to open. For example, the `fulfill_at` date for a
    /// subscription order might be the 1st of each month, a pre-order `fulfill_at`
    /// date would be `nil`, and a standard order `fulfill_at` date would be the order creation date.
    /// </summary>
    [JsonPropertyName("fulfillAt")]
    public DateTimeOffset? fulfillAt { get; set; } = null;

    /// <summary>
    /// The latest date and time by which all items in the fulfillment order need to be fulfilled.
    /// </summary>
    [JsonPropertyName("fulfillBy")]
    public DateTimeOffset? fulfillBy { get; set; } = null;

    /// <summary>
    /// The fulfillment holds applied on the fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillmentHolds")]
    public ICollection<FulfillmentHold>? fulfillmentHolds { get; set; } = null;

    /// <summary>
    /// Fulfillment orders eligible for merging with the given fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillmentOrdersForMerge")]
    public FulfillmentOrderConnection? fulfillmentOrdersForMerge { get; set; } = null;

    /// <summary>
    /// A list of fulfillments for the fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillments")]
    public FulfillmentConnection? fulfillments { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The duties delivery method of this fulfillment order.
    /// </summary>
    [JsonPropertyName("internationalDuties")]
    public FulfillmentOrderInternationalDuties? internationalDuties { get; set; } = null;

    /// <summary>
    /// A list of the fulfillment order's line items.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public FulfillmentOrderLineItemConnection? lineItems { get; set; } = null;

    /// <summary>
    /// A list of locations that the fulfillment order can potentially move to.
    /// </summary>
    [JsonPropertyName("locationsForMove")]
    public FulfillmentOrderLocationForMoveConnection? locationsForMove { get; set; } = null;

    /// <summary>
    /// A list of requests sent by the merchant or an order management app to the fulfillment service for the fulfillment order.
    /// </summary>
    [JsonPropertyName("merchantRequests")]
    public FulfillmentOrderMerchantRequestConnection? merchantRequests { get; set; } = null;

    /// <summary>
    /// The order that's associated with the fulfillment order.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// ID of the order that's associated with the fulfillment order.
    /// </summary>
    [JsonPropertyName("orderId")]
    public string? orderId { get; set; } = null;

    /// <summary>
    /// The unique identifier for the order that appears on the order page in the Shopify admin and the <b>Order status</b> page.
    /// For example, "#1001", "EN1001", or "1001-A".
    /// This value isn't unique across multiple stores.
    /// </summary>
    [JsonPropertyName("orderName")]
    public string? orderName { get; set; } = null;

    /// <summary>
    /// The date and time when the order was processed.
    /// This date and time might not match the date and time when the order was created.
    /// </summary>
    [JsonPropertyName("orderProcessedAt")]
    public DateTimeOffset? orderProcessedAt { get; set; } = null;

    /// <summary>
    /// The request status of the fulfillment order.
    /// </summary>
    [JsonPropertyName("requestStatus")]
    public FulfillmentOrderRequestStatus? requestStatus { get; set; } = null;

    /// <summary>
    /// The status of the fulfillment order.
    /// </summary>
    [JsonPropertyName("status")]
    public FulfillmentOrderStatus? status { get; set; } = null;

    /// <summary>
    /// The actions that can be performed on this fulfillment order.
    /// </summary>
    [JsonPropertyName("supportedActions")]
    public ICollection<FulfillmentOrderSupportedAction>? supportedActions { get; set; } = null;

    /// <summary>
    /// The date and time when the fulfillment order was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}