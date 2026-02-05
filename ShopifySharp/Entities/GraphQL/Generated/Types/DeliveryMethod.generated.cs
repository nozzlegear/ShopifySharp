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
/// Information about the delivery method selected for a [`FulfillmentOrder`](https://shopify.dev/docs/api/admin-graphql/latest/objects/FulfillmentOrder).
/// Includes the method type, expected delivery timeframe, and any additional
/// information needed for delivery.
/// The delivery method stores details from checkout such as the carrier, branded
/// promises like Shop Promise, and the delivery option name shown to the buyer.
/// Additional information like delivery instructions or contact phone numbers helps fulfill
/// the [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order) correctly.
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
    public DateTimeOffset? maxDeliveryDateTime { get; set; } = null;

    /// <summary>
    /// The type of the delivery method.
    /// </summary>
    [JsonPropertyName("methodType")]
    public DeliveryMethodType? methodType { get; set; } = null;

    /// <summary>
    /// The earliest delivery date and time when the fulfillment is expected to arrive at the buyer's location.
    /// </summary>
    [JsonPropertyName("minDeliveryDateTime")]
    public DateTimeOffset? minDeliveryDateTime { get; set; } = null;

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