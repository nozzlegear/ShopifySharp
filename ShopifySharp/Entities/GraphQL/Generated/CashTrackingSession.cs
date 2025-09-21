#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Tracks the balance in a cash drawer for a point of sale device over the course of a shift.
/// </summary>
public record CashTrackingSession : IGraphQLObject, INode
{
    /// <summary>
    /// The adjustments made to the cash drawer during this session.
    /// </summary>
    [JsonPropertyName("adjustments")]
    public CashTrackingAdjustmentConnection? adjustments { get; set; } = null;

    /// <summary>
    /// Whether this session is tracking cash payments.
    /// </summary>
    [JsonPropertyName("cashTrackingEnabled")]
    public bool? cashTrackingEnabled { get; set; } = null;

    /// <summary>
    /// The cash transactions made during this session.
    /// </summary>
    [JsonPropertyName("cashTransactions")]
    public OrderTransactionConnection? cashTransactions { get; set; } = null;

    /// <summary>
    /// The counted cash balance when the session was closed.
    /// </summary>
    [JsonPropertyName("closingBalance")]
    public MoneyV2? closingBalance { get; set; } = null;

    /// <summary>
    /// The note entered when the session was closed.
    /// </summary>
    [JsonPropertyName("closingNote")]
    public string? closingNote { get; set; } = null;

    /// <summary>
    /// The user who closed the session.
    /// </summary>
    [JsonPropertyName("closingStaffMember")]
    public StaffMember? closingStaffMember { get; set; } = null;

    /// <summary>
    /// When the session was closed.
    /// </summary>
    [JsonPropertyName("closingTime")]
    public DateTime? closingTime { get; set; } = null;

    /// <summary>
    /// The expected balance at the end of the session or the expected current balance for sessions that are still open.
    /// </summary>
    [JsonPropertyName("expectedBalance")]
    public MoneyV2? expectedBalance { get; set; } = null;

    /// <summary>
    /// The amount that was expected to be in the cash drawer at the end of the session, calculated after the session was closed.
    /// </summary>
    [JsonPropertyName("expectedClosingBalance")]
    public MoneyV2? expectedClosingBalance { get; set; } = null;

    /// <summary>
    /// The amount expected to be in the cash drawer based on the previous session.
    /// </summary>
    [JsonPropertyName("expectedOpeningBalance")]
    public MoneyV2? expectedOpeningBalance { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The location of the point of sale device during this session.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The net cash sales made for the duration of this cash tracking session.
    /// </summary>
    [JsonPropertyName("netCashSales")]
    public MoneyV2? netCashSales { get; set; } = null;

    /// <summary>
    /// The counted cash balance when the session was opened.
    /// </summary>
    [JsonPropertyName("openingBalance")]
    public MoneyV2? openingBalance { get; set; } = null;

    /// <summary>
    /// The note entered when the session was opened.
    /// </summary>
    [JsonPropertyName("openingNote")]
    public string? openingNote { get; set; } = null;

    /// <summary>
    /// The user who opened the session.
    /// </summary>
    [JsonPropertyName("openingStaffMember")]
    public StaffMember? openingStaffMember { get; set; } = null;

    /// <summary>
    /// When the session was opened.
    /// </summary>
    [JsonPropertyName("openingTime")]
    public DateTime? openingTime { get; set; } = null;

    /// <summary>
    /// The register name for the point of sale device that this session is tracking cash for.
    /// </summary>
    [JsonPropertyName("registerName")]
    public string? registerName { get; set; } = null;

    /// <summary>
    /// The sum of all adjustments made during the session, excluding the final adjustment.
    /// </summary>
    [JsonPropertyName("totalAdjustments")]
    public MoneyV2? totalAdjustments { get; set; } = null;

    /// <summary>
    /// The sum of all cash refunds for the duration of this cash tracking session.
    /// </summary>
    [JsonPropertyName("totalCashRefunds")]
    public MoneyV2? totalCashRefunds { get; set; } = null;

    /// <summary>
    /// The sum of all cash sales for the duration of this cash tracking session.
    /// </summary>
    [JsonPropertyName("totalCashSales")]
    public MoneyV2? totalCashSales { get; set; } = null;

    /// <summary>
    /// The total discrepancy for the session including starting and ending.
    /// </summary>
    [JsonPropertyName("totalDiscrepancy")]
    public MoneyV2? totalDiscrepancy { get; set; } = null;
}