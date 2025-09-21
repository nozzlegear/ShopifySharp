#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields used to create a fulfillment event.
/// </summary>
public record FulfillmentEventInput : GraphQLInputObject<FulfillmentEventInput>
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
    /// The estimated delivery date and time of the fulfillment.
    /// </summary>
    [JsonPropertyName("estimatedDeliveryAt")]
    public DateTime? estimatedDeliveryAt { get; set; } = null;

    /// <summary>
    /// The ID for the fulfillment that's associated with this fulfillment event.
    /// </summary>
    [JsonPropertyName("fulfillmentId")]
    public string? fulfillmentId { get; set; } = null;

    /// <summary>
    /// The time at which this fulfillment event happened.
    /// </summary>
    [JsonPropertyName("happenedAt")]
    public DateTime? happenedAt { get; set; } = null;

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