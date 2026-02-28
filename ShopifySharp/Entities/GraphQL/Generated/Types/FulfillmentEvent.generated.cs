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
/// A tracking event that records the status and location of a fulfillment at a
/// specific point in time. Each event captures details such as the [status](https://shopify.dev/docs/api/admin-graphql/latest/objects/FulfillmentEvent#field-FulfillmentEvent.fields.status)
/// (for example, in transit, out for delivery, delivered) and any [messages](https://shopify.dev/docs/api/admin-graphql/latest/objects/FulfillmentEvent#field-FulfillmentEvent.fields.message)
/// associated with the event.
/// Fulfillment events provide a chronological history of a package's journey from
/// shipment to delivery. They include timestamps, geographic coordinates, and
/// estimated delivery dates to track fulfillment progress.
/// </summary>
public record FulfillmentEvent : IGraphQLObject, INode
{
    /// <summary>
    /// The street address where this fulfillment event occurred.
    /// </summary>
    [JsonPropertyName("address1")]
    public string? address1 { get; set; } = null;

    /// <summary>
    /// The city where this fulfillment event occurred.
    /// </summary>
    [JsonPropertyName("city")]
    public string? city { get; set; } = null;

    /// <summary>
    /// The country where this fulfillment event occurred.
    /// </summary>
    [JsonPropertyName("country")]
    public string? country { get; set; } = null;

    /// <summary>
    /// The date and time when the fulfillment event was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The estimated delivery date and time of the fulfillment.
    /// </summary>
    [JsonPropertyName("estimatedDeliveryAt")]
    public DateTimeOffset? estimatedDeliveryAt { get; set; } = null;

    /// <summary>
    /// The time at which this fulfillment event happened.
    /// </summary>
    [JsonPropertyName("happenedAt")]
    public DateTimeOffset? happenedAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The latitude where this fulfillment event occurred.
    /// </summary>
    [JsonPropertyName("latitude")]
    public decimal? latitude { get; set; } = null;

    /// <summary>
    /// The longitude where this fulfillment event occurred.
    /// </summary>
    [JsonPropertyName("longitude")]
    public decimal? longitude { get; set; } = null;

    /// <summary>
    /// A message associated with this fulfillment event.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;

    /// <summary>
    /// The province where this fulfillment event occurred.
    /// </summary>
    [JsonPropertyName("province")]
    public string? province { get; set; } = null;

    /// <summary>
    /// The status of this fulfillment event.
    /// </summary>
    [JsonPropertyName("status")]
    public FulfillmentEventStatus? status { get; set; } = null;

    /// <summary>
    /// The zip code of the location where this fulfillment event occurred.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;
}