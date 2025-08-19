#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A summary of Shopify Protect details for an order.
/// </summary>
public record ShopifyProtectOrderSummary : IGraphQLObject
{
    /// <summary>
    /// The eligibility details of an order's protection against fraudulent chargebacks.
    /// </summary>
    [JsonPropertyName("eligibility")]
    public ShopifyProtectOrderEligibility? eligibility { get; set; } = null;

    /// <summary>
    /// The status of the order's protection against fraudulent chargebacks.
    /// </summary>
    [JsonPropertyName("status")]
    public ShopifyProtectStatus? status { get; set; } = null;
}