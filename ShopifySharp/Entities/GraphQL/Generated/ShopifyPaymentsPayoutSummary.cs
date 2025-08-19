#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Breakdown of the total fees and gross of each of the different types of transactions associated
/// with the payout.
/// </summary>
public record ShopifyPaymentsPayoutSummary : IGraphQLObject
{
    /// <summary>
    /// Total fees for all adjustments including disputes.
    /// </summary>
    [JsonPropertyName("adjustmentsFee")]
    public MoneyV2? adjustmentsFee { get; set; } = null;

    /// <summary>
    /// Total gross amount for all adjustments including disputes.
    /// </summary>
    [JsonPropertyName("adjustmentsGross")]
    public MoneyV2? adjustmentsGross { get; set; } = null;

    /// <summary>
    /// Total fees for all advances.
    /// </summary>
    [JsonPropertyName("advanceFees")]
    public MoneyV2? advanceFees { get; set; } = null;

    /// <summary>
    /// Total gross amount for all advances.
    /// </summary>
    [JsonPropertyName("advanceGross")]
    public MoneyV2? advanceGross { get; set; } = null;

    /// <summary>
    /// Total fees for all charges.
    /// </summary>
    [JsonPropertyName("chargesFee")]
    public MoneyV2? chargesFee { get; set; } = null;

    /// <summary>
    /// Total gross amount for all charges.
    /// </summary>
    [JsonPropertyName("chargesGross")]
    public MoneyV2? chargesGross { get; set; } = null;

    /// <summary>
    /// Total fees for all refunds.
    /// </summary>
    [JsonPropertyName("refundsFee")]
    public MoneyV2? refundsFee { get; set; } = null;

    /// <summary>
    /// Total gross amount for all refunds.
    /// </summary>
    [JsonPropertyName("refundsFeeGross")]
    public MoneyV2? refundsFeeGross { get; set; } = null;

    /// <summary>
    /// Total fees for all reserved funds.
    /// </summary>
    [JsonPropertyName("reservedFundsFee")]
    public MoneyV2? reservedFundsFee { get; set; } = null;

    /// <summary>
    /// Total gross amount for all reserved funds.
    /// </summary>
    [JsonPropertyName("reservedFundsGross")]
    public MoneyV2? reservedFundsGross { get; set; } = null;

    /// <summary>
    /// Total fees for all retried payouts.
    /// </summary>
    [JsonPropertyName("retriedPayoutsFee")]
    public MoneyV2? retriedPayoutsFee { get; set; } = null;

    /// <summary>
    /// Total gross amount for all retried payouts.
    /// </summary>
    [JsonPropertyName("retriedPayoutsGross")]
    public MoneyV2? retriedPayoutsGross { get; set; } = null;
}