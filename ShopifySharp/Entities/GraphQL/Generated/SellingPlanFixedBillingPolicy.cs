#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The fixed selling plan billing policy defines how much of the price of the product will be billed to customer
/// at checkout. If there is an outstanding balance, it determines when it will be paid.
/// </summary>
public record SellingPlanFixedBillingPolicy : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The checkout charge when the full amount isn't charged at checkout.
    /// </summary>
    [JsonPropertyName("checkoutCharge")]
    public SellingPlanCheckoutCharge? checkoutCharge { get; set; } = null;

    /// <summary>
    /// The exact time when to capture the full payment.
    /// </summary>
    [JsonPropertyName("remainingBalanceChargeExactTime")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? remainingBalanceChargeExactTime { get; set; } = null;

    /// <summary>
    /// The period after remaining_balance_charge_trigger, before capturing the full payment. Expressed as an ISO8601 duration.
    /// </summary>
    [JsonPropertyName("remainingBalanceChargeTimeAfterCheckout")]
    public string? remainingBalanceChargeTimeAfterCheckout { get; set; } = null;

    /// <summary>
    /// When to capture payment for amount due.
    /// </summary>
    [JsonPropertyName("remainingBalanceChargeTrigger")]
    public SellingPlanRemainingBalanceChargeTrigger? remainingBalanceChargeTrigger { get; set; } = null;
}