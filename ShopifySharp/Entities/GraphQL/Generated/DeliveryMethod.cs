#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The delivery method used by a fulfillment order.
/// </summary>
public record DeliveryMethod : IGraphQLObject, INode
{
    /// <summary>
    /// The Additional information to consider when performing the delivery.
    /// </summary>
    [JsonPropertyName("additionalInformation")]
    public DeliveryMethodAdditionalInformation? additionalInformation { get; set; } = null;

    /// <summary>
    /// The branded promise that was presented to the buyer during checkout.  For example: Shop Promise.
    /// </summary>
    [JsonPropertyName("brandedPromise")]
    public DeliveryBrandedPromise? brandedPromise { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The latest delivery date and time when the fulfillment is expected to arrive at the buyer's location.
    /// </summary>
    [JsonPropertyName("maxDeliveryDateTime")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? maxDeliveryDateTime { get; set; } = null;

    /// <summary>
    /// The type of the delivery method.
    /// </summary>
    [JsonPropertyName("methodType")]
    public DeliveryMethodType? methodType { get; set; } = null;

    /// <summary>
    /// The earliest delivery date and time when the fulfillment is expected to arrive at the buyer's location.
    /// </summary>
    [JsonPropertyName("minDeliveryDateTime")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? minDeliveryDateTime { get; set; } = null;

    /// <summary>
    /// The name of the delivery option that was presented to the buyer during checkout.
    /// </summary>
    [JsonPropertyName("presentedName")]
    public string? presentedName { get; set; } = null;

    /// <summary>
    /// A reference to the shipping method.
    /// </summary>
    [JsonPropertyName("serviceCode")]
    public string? serviceCode { get; set; } = null;

    /// <summary>
    /// Source reference is promise provider specific data associated with delivery promise.
    /// </summary>
    [JsonPropertyName("sourceReference")]
    public string? sourceReference { get; set; } = null;
}