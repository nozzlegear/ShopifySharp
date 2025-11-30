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
/// The input fields used to specify the refund method for an order cancellation.
/// </summary>
public record OrderCancelRefundMethodInput : GraphQLInputObject<OrderCancelRefundMethodInput>
{
    /// <summary>
    /// Whether to refund to the original payment method.
    /// </summary>
    [JsonPropertyName("originalPaymentMethodsRefund")]
    public bool? originalPaymentMethodsRefund { get; set; } = null;

    /// <summary>
    /// Whether to refund to store credit.
    /// </summary>
    [JsonPropertyName("storeCreditRefund")]
    public OrderCancelStoreCreditRefundInput? storeCreditRefund { get; set; } = null;
}