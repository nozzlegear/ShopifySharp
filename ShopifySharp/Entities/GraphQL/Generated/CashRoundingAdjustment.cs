#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The rounding adjustment applied to total payment or refund received for an Order involving cash payments.
/// </summary>
public record CashRoundingAdjustment : IGraphQLObject
{
    /// <summary>
    /// The rounding adjustment that can be applied to totalReceived for an Order
    /// involving cash payments in shop and presentment currencies. Could be a
    /// positive or negative value. Value is 0 if there's no rounding, or for non-cash payments.
    /// </summary>
    [JsonPropertyName("paymentSet")]
    public MoneyBag? paymentSet { get; set; } = null;

    /// <summary>
    /// The rounding adjustment that can be applied to totalRefunded for an Order
    /// involving cash payments in shop and presentment currencies. Could be a
    /// positive or negative value. Value is 0 if there's no rounding, or for non-cash refunds.
    /// </summary>
    [JsonPropertyName("refundSet")]
    public MoneyBag? refundSet { get; set; } = null;
}