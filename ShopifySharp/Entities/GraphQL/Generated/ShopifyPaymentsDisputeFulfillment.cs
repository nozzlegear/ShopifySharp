#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The fulfillment associated with dispute evidence.
/// </summary>
public record ShopifyPaymentsDisputeFulfillment : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The shipping carrier for this fulfillment.
    /// </summary>
    [JsonPropertyName("shippingCarrier")]
    public string? shippingCarrier { get; set; } = null;

    /// <summary>
    /// The shipping date for this fulfillment.
    /// </summary>
    [JsonPropertyName("shippingDate")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateOnly? shippingDate { get; set; } = null;

    /// <summary>
    /// The shipping tracking number for this fulfillment.
    /// </summary>
    [JsonPropertyName("shippingTrackingNumber")]
    public string? shippingTrackingNumber { get; set; } = null;
}