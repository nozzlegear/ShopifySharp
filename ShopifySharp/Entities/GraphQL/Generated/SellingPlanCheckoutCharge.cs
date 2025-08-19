#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The amount charged at checkout when the full amount isn't charged at checkout.
/// </summary>
public record SellingPlanCheckoutCharge : IGraphQLObject
{
    /// <summary>
    /// The charge type for the checkout charge.
    /// </summary>
    [JsonPropertyName("type")]
    public SellingPlanCheckoutChargeType? type { get; set; } = null;

    /// <summary>
    /// The charge value for the checkout charge.
    /// </summary>
    [JsonPropertyName("value")]
    public SellingPlanCheckoutChargeValue? @value { get; set; } = null;
}