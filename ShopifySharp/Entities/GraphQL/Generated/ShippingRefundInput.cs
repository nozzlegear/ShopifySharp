#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields that are required to reimburse shipping costs.
/// </summary>
public record ShippingRefundInput : GraphQLInputObject<ShippingRefundInput>
{
    /// <summary>
    /// The monetary value of the shipping fees to be reimbursed.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// Whether a full refund is provided.
    /// </summary>
    [JsonPropertyName("fullRefund")]
    public bool? fullRefund { get; set; } = null;
}