#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The eligibility details of an order's protection against fraudulent chargebacks by Shopify Protect.
/// </summary>
public record ShopifyProtectOrderEligibility : IGraphQLObject
{
    /// <summary>
    /// The status of whether an order is eligible for protection against fraudulent chargebacks.
    /// </summary>
    [JsonPropertyName("status")]
    public ShopifyProtectEligibilityStatus? status { get; set; } = null;
}