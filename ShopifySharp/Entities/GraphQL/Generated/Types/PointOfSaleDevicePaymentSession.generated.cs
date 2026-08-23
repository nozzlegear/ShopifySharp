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
/// Tracks the payment activity for a point of sale device.
/// </summary>
public record PointOfSaleDevicePaymentSession : IGraphQLObject, INode
{
    /// <summary>
    /// The activities on the point of sale device payment session.
    /// </summary>
    [JsonPropertyName("cashActivities")]
    public CashActivityConnection? cashActivities { get; set; } = null;

    /// <summary>
    /// The cash that was physically counted when the point of sale device payment session was closed.
    /// </summary>
    [JsonPropertyName("cashCountedAtClose")]
    public MoneyV2? cashCountedAtClose { get; set; } = null;

    /// <summary>
    /// The cash that was physically counted when the point of sale device payment session was opened.
    /// </summary>
    [JsonPropertyName("cashCountedAtOpen")]
    public MoneyV2? cashCountedAtOpen { get; set; } = null;

    /// <summary>
    /// The cash drawer associated with the point of sale device payment session. The
    /// session's sales andcash tracking activity will affect the cash drawer's balance.
    /// </summary>
    [JsonPropertyName("cashDrawer")]
    public CashDrawer? cashDrawer { get; set; } = null;

    /// <summary>
    /// The amount that the cash drawer balance was adjusted when the session was closed.
    /// </summary>
    [JsonPropertyName("closingAdjustment")]
    public MoneyV2? closingAdjustment { get; set; } = null;

    /// <summary>
    /// The counted balance of the cash drawer when the point of sale device payment session was closed.
    /// </summary>
    [JsonPropertyName("closingBalance")]
    public MoneyV2? closingBalance { get; set; } = null;

    /// <summary>
    /// The note associated with the point of sale device payment session closing.
    /// </summary>
    [JsonPropertyName("closingNote")]
    public string? closingNote { get; set; } = null;

    /// <summary>
    /// The staff member who closed the point of sale device payment session.
    /// </summary>
    [JsonPropertyName("closingStaffMember")]
    public StaffMember? closingStaffMember { get; set; } = null;

    /// <summary>
    /// The time the point of sale device payment session was closed.
    /// </summary>
    [JsonPropertyName("closingTime")]
    public DateTimeOffset? closingTime { get; set; } = null;

    /// <summary>
    /// The currency of the point of sale device payment session.
    /// </summary>
    [JsonPropertyName("currency")]
    public string? currency { get; set; } = null;

    /// <summary>
    /// The expected cash when the point of sale device payment session was closed.
    /// </summary>
    [JsonPropertyName("expectedCashAtClose")]
    public MoneyV2? expectedCashAtClose { get; set; } = null;

    /// <summary>
    /// The expected balance of the cash drawer when the point of sale device payment session was opened.
    /// </summary>
    [JsonPropertyName("expectedCashAtOpen")]
    public MoneyV2? expectedCashAtOpen { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The location associated with the point of sale device payment session. The
    /// session's sales and cash tracking activity will contribute to the location's totals.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The net cash sales for the point of sale device payment session.
    /// </summary>
    [JsonPropertyName("netCashSales")]
    public MoneyV2? netCashSales { get; set; } = null;

    /// <summary>
    /// The net sales for the duration of this session.
    /// </summary>
    [JsonPropertyName("netSales")]
    public MoneyV2? netSales { get; set; } = null;

    /// <summary>
    /// The note associated with the point of sale device payment session opening.
    /// </summary>
    [JsonPropertyName("openingNote")]
    public string? openingNote { get; set; } = null;

    /// <summary>
    /// The staff member who opened the point of sale device payment session.
    /// </summary>
    [JsonPropertyName("openingStaffMember")]
    public StaffMember? openingStaffMember { get; set; } = null;

    /// <summary>
    /// The time the point of sale device payment session was opened.
    /// </summary>
    [JsonPropertyName("openingTime")]
    public DateTimeOffset? openingTime { get; set; } = null;

    /// <summary>
    /// The point of sale device.
    /// </summary>
    [JsonPropertyName("pointOfSaleDevice")]
    public PointOfSaleDevice? pointOfSaleDevice { get; set; } = null;

    /// <summary>
    /// Whether the point of sale device payment session is open. Payments can't be
    /// processed or refunded during a closed session, and the cash drawer balance
    /// can't be adjusted or corrected.
    /// </summary>
    [JsonPropertyName("status")]
    public PointOfSaleDevicePaymentSessionStatus? status { get; set; } = null;

    /// <summary>
    /// The total adjustments for the point of sale device payment session.
    /// </summary>
    [JsonPropertyName("totalAdjustments")]
    public MoneyV2? totalAdjustments { get; set; } = null;

    /// <summary>
    /// The total cash refunds for the point of sale device payment session.
    /// </summary>
    [JsonPropertyName("totalCashRefunds")]
    public MoneyV2? totalCashRefunds { get; set; } = null;

    /// <summary>
    /// The total cash sales for the point of sale device payment session.
    /// </summary>
    [JsonPropertyName("totalCashSales")]
    public MoneyV2? totalCashSales { get; set; } = null;

    /// <summary>
    /// The total discrepancy for the point of sale device payment session.
    /// </summary>
    [JsonPropertyName("totalDiscrepancy")]
    public MoneyV2? totalDiscrepancy { get; set; } = null;

    /// <summary>
    /// The sum of all refunds for the duration of this session.
    /// </summary>
    [JsonPropertyName("totalRefunds")]
    public MoneyV2? totalRefunds { get; set; } = null;

    /// <summary>
    /// The sum of all sales for the duration of this session.
    /// </summary>
    [JsonPropertyName("totalSales")]
    public MoneyV2? totalSales { get; set; } = null;

    /// <summary>
    /// Whether the point of sale device payment session totals are ready.
    /// </summary>
    [JsonPropertyName("totalsReady")]
    public bool? totalsReady { get; set; } = null;
}