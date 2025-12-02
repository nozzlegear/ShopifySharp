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
/// The input fields for the shipping cost to refund.
/// </summary>
public record RefundShippingInput : GraphQLInputObject<RefundShippingInput>
{
    /// <summary>
    /// Whether to refund the full shipping amount.
    /// </summary>
    [JsonPropertyName("fullRefund")]
    public bool? fullRefund { get; set; } = null;

    /// <summary>
    /// The input fields required to refund shipping cost, in the presentment currency of the order.
    /// This overrides the `fullRefund` argument.
    /// This field defaults to 0.00 when not provided and when the `fullRefund` argument is false.
    /// </summary>
    [JsonPropertyName("shippingRefundAmount")]
    public MoneyInput? shippingRefundAmount { get; set; } = null;
}