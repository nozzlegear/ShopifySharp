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
/// A cash adjustment activity.
/// </summary>
public record CashAdjustmentActivity : IGraphQLObject, ICashActivity
{
    /// <summary>
    /// The amount of cash added or removed as part of the activity.
    /// </summary>
    [JsonPropertyName("cash")]
    public MoneyV2? cash { get; set; } = null;

    /// <summary>
    /// The gift card associated with the activity.
    /// </summary>
    [JsonPropertyName("giftCard")]
    public GiftCard? giftCard { get; set; } = null;

    /// <summary>
    /// A note associated with the activity.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The point of sale device payment session associated with the activity.
    /// </summary>
    [JsonPropertyName("paymentSession")]
    public PointOfSaleDevicePaymentSession? paymentSession { get; set; } = null;

    /// <summary>
    /// The reason code for the activity.
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public CashManagementReasonCode? reasonCode { get; set; } = null;

    /// <summary>
    /// The staff member who performed the activity.
    /// </summary>
    [JsonPropertyName("staffMember")]
    public StaffMember? staffMember { get; set; } = null;

    /// <summary>
    /// The time at which the activity occurred.
    /// </summary>
    [JsonPropertyName("time")]
    public DateTimeOffset? time { get; set; } = null;

    /// <summary>
    /// The type of adjustment activity.
    /// </summary>
    [JsonPropertyName("type")]
    public CashAdjustmentActivityType? type { get; set; } = null;
}