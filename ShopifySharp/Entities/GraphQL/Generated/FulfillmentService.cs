#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A **Fulfillment Service** is a third party warehouse that prepares and ships orders
/// on behalf of the store owner. Fulfillment services charge a fee to package and ship items
/// and update product inventory levels. Some well known fulfillment services with Shopify integrations
/// include: Amazon, Shipwire, and Rakuten. When an app registers a new `FulfillmentService` on a store,
/// Shopify automatically creates a `Location` that's associated to the fulfillment service.
/// To learn more about fulfillment services, refer to
/// [Manage fulfillments as a fulfillment service app](https://shopify.dev/apps/fulfillment/fulfillment-service-apps)
/// guide.
/// ## Mutations
/// You can work with the `FulfillmentService` object with the
/// [fulfillmentServiceCreate](https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentServiceCreate),
/// [fulfillmentServiceUpdate](https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentServiceUpdate),
/// and [fulfillmentServiceDelete](https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentServiceDelete)
/// mutations.
/// ## Hosted endpoints
/// Fulfillment service providers integrate with Shopify by providing Shopify with a set of hosted endpoints that
/// Shopify can query on certain conditions.
/// These endpoints must have a common prefix, and this prefix should be supplied in the `callbackUrl` parameter
/// in the
/// [fulfillmentServiceCreate](https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentServiceCreate)
/// mutation.
/// - Shopify sends POST requests to the `<callbackUrl>/fulfillment_order_notification` endpoint
///   to notify the fulfillment service about fulfillment requests and fulfillment cancellation requests.
///   For more information, refer to
///   [Receive fulfillment requests and cancellations](https://shopify.dev/apps/fulfillment/fulfillment-service-apps/manage-fulfillments#step-2-receive-fulfillment-requests-and-cancellations).
/// - Shopify sends GET requests to the `<callbackUrl>/fetch_tracking_numbers` endpoint to retrieve tracking numbers for orders
///   if `trackingSupport` is set to `true`.
///   For more information, refer to
///   [Enable tracking support](https://shopify.dev/apps/fulfillment/fulfillment-service-apps/manage-fulfillments#step-8-enable-tracking-support-optional).
///   Fulfillment services can also update tracking information using the
///   [fulfillmentTrackingInfoUpdate](https://shopify.dev/api/admin-graphql/latest/mutations/fulfillmentTrackingInfoUpdate) mutation,
///   rather than waiting for Shopify to ask for tracking numbers.
/// - Shopify sends GET requests to the `<callbackUrl>/fetch_stock` endpoint to retrieve
///   on hand inventory levels for the fulfillment service location if `inventoryManagement` is set to `true`.
///   For more information, refer to
///   [Sharing inventory levels with Shopify](https://shopify.dev/apps/build/orders-fulfillment/fulfillment-service-apps/build-for-fulfillment-services#step-10-optional-share-inventory-levels-with-shopify).
/// To make sure you have everything set up correctly, you can test the `callbackUrl`-prefixed endpoints
/// in your development store.
/// ## Resources and webhooks
/// There are a variety of objects and webhooks that enable a fulfillment service to work.
/// To exchange fulfillment information with Shopify, fulfillment services use the
/// [FulfillmentOrder](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrder),
/// [Fulfillment](https://shopify.dev/api/admin-graphql/latest/objects/Fulfillment) and
/// [Order](https://shopify.dev/api/admin-graphql/latest/objects/Order) objects and related mutations.
/// To act on fulfillment process events that happen on the Shopify side,
/// besides awaiting calls to `callbackUrl`-prefixed endpoints,
/// fulfillment services can subscribe to the
/// [fulfillment order](https://shopify.dev/apps/fulfillment/fulfillment-service-apps/manage-fulfillments#webhooks)
/// and [order](https://shopify.dev/api/admin-rest/latest/resources/webhook)
/// webhooks.
/// </summary>
public record FulfillmentService : IGraphQLObject
{
    /// <summary>
    /// The callback URL that the fulfillment service has registered for requests. The following considerations apply:
    /// - Shopify queries the `<callbackUrl>/fetch_tracking_numbers` endpoint to retrieve tracking numbers
    ///     for orders, if `trackingSupport` is set to `true`.
    /// - Shopify queries the `<callbackUrl>/fetch_stock` endpoint to retrieve inventory levels,
    ///     if `inventoryManagement` is set to `true`.
    /// - Shopify uses the `<callbackUrl>/fulfillment_order_notification` endpoint to send
    ///     [fulfillment and cancellation requests](https://shopify.dev/apps/build/orders-fulfillment/fulfillment-service-apps/build-for-fulfillment-services#step-9-optional-enable-tracking-support).
    /// </summary>
    [JsonPropertyName("callbackUrl")]
    public string? callbackUrl { get; set; } = null;

    /// <summary>
    /// Whether the fulfillment service uses the [fulfillment order based workflow](https://shopify.dev/apps/fulfillment/fulfillment-service-apps/manage-fulfillments)
    /// for managing fulfillments.
    /// As the migration is now finished, the `fulfillmentOrdersOptIn` property is [deprecated](
    /// https://shopify.dev/changelog/deprecation-of-the-fulfillmentservice-fulfillmentordersoptin-field)
    /// and is always set to `true` on correctly functioning fulfillment services.
    /// </summary>
    [JsonPropertyName("fulfillmentOrdersOptIn")]
    [Obsolete("Migration period ended. All correctly functioning fulfillment services have `fulfillmentOrdersOptIn` set to `true`.")]
    public bool? fulfillmentOrdersOptIn { get; set; } = null;

    /// <summary>
    /// Human-readable unique identifier for this fulfillment service.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The ID of the fulfillment service.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the fulfillment service tracks product inventory and provides updates to Shopify.
    /// </summary>
    [JsonPropertyName("inventoryManagement")]
    public bool? inventoryManagement { get; set; } = null;

    /// <summary>
    /// Location associated with the fulfillment service.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// Whether the fulfillment service can stock inventory alongside other locations.
    /// </summary>
    [JsonPropertyName("permitsSkuSharing")]
    public bool? permitsSkuSharing { get; set; } = null;

    /// <summary>
    /// Whether the fulfillment service requires products to be physically shipped.
    /// </summary>
    [JsonPropertyName("requiresShippingMethod")]
    public bool? requiresShippingMethod { get; set; } = null;

    /// <summary>
    /// The name of the fulfillment service as seen by merchants.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public string? serviceName { get; set; } = null;

    /// <summary>
    /// Whether the fulfillment service implemented the /fetch_tracking_numbers endpoint.
    /// </summary>
    [JsonPropertyName("trackingSupport")]
    public bool? trackingSupport { get; set; } = null;

    /// <summary>
    /// Type associated with the fulfillment service.
    /// </summary>
    [JsonPropertyName("type")]
    public FulfillmentServiceType? type { get; set; } = null;
}