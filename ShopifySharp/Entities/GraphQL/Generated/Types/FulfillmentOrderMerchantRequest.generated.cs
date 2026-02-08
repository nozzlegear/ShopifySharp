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
/// A request made by the merchant or an order management app to a fulfillment service
/// for a fulfillment order.
/// </summary>
public record FulfillmentOrderMerchantRequest : IGraphQLObject, INode
{
    /// <summary>
    /// The fulfillment order associated with the merchant request.
    /// </summary>
    [JsonPropertyName("fulfillmentOrder")]
    public FulfillmentOrder? fulfillmentOrder { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The kind of request made.
    /// </summary>
    [JsonPropertyName("kind")]
    public FulfillmentOrderMerchantRequestKind? kind { get; set; } = null;

    /// <summary>
    /// The optional message that the merchant included in the request.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;

    /// <summary>
    /// Additional options requested by the merchant. These depend on the `kind` of the request.
    /// For example, for a `FULFILLMENT_REQUEST`, one option is `notify_customer`, which indicates whether the
    /// merchant intends to notify the customer upon fulfillment. The fulfillment service can then set
    /// `notifyCustomer` when making calls to `FulfillmentCreate`.
    /// </summary>
    [JsonPropertyName("requestOptions")]
    public string? requestOptions { get; set; } = null;

    /// <summary>
    /// The response from the fulfillment service.
    /// </summary>
    [JsonPropertyName("responseData")]
    public string? responseData { get; set; } = null;

    /// <summary>
    /// The timestamp when the request was made.
    /// </summary>
    [JsonPropertyName("sentAt")]
    public DateTimeOffset? sentAt { get; set; } = null;
}