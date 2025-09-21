#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create or update a fixed billing policy.
/// </summary>
public record SellingPlanFixedBillingPolicyInput : GraphQLInputObject<SellingPlanFixedBillingPolicyInput>
{
    /// <summary>
    /// The checkout charge policy for the selling plan.
    /// </summary>
    [JsonPropertyName("checkoutCharge")]
    public SellingPlanCheckoutChargeInput? checkoutCharge { get; set; } = null;

    /// <summary>
    /// The date and time to capture the full payment.
    /// </summary>
    [JsonPropertyName("remainingBalanceChargeExactTime")]
    public DateTime? remainingBalanceChargeExactTime { get; set; } = null;

    /// <summary>
    /// The period after capturing the payment for the amount due
    /// (`remainingBalanceChargeTrigger`), and before capturing the full payment.
    /// Expressed as an ISO8601 duration.
    /// </summary>
    [JsonPropertyName("remainingBalanceChargeTimeAfterCheckout")]
    public string? remainingBalanceChargeTimeAfterCheckout { get; set; } = null;

    /// <summary>
    /// When to capture the payment for the amount due.
    /// </summary>
    [JsonPropertyName("remainingBalanceChargeTrigger")]
    public SellingPlanRemainingBalanceChargeTrigger? remainingBalanceChargeTrigger { get; set; } = null;
}