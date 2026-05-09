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
/// A cash count activity.
/// </summary>
public record CashCountActivity : IGraphQLObject, ICashActivity
{
    /// <summary>
    /// The amount of cash added or removed as part of the activity.
    /// </summary>
    [JsonPropertyName("cash")]
    public MoneyV2? cash { get; set; } = null;

    /// <summary>
    /// The amount of cash counted during the activity.
    /// </summary>
    [JsonPropertyName("cashCounted")]
    public MoneyV2? cashCounted { get; set; } = null;

    /// <summary>
    /// The discrepancy between the counted and expected cash amounts.
    /// </summary>
    [JsonPropertyName("cashDiscrepancy")]
    public MoneyV2? cashDiscrepancy { get; set; } = null;

    /// <summary>
    /// The expected amount of cash in the drawer at the time of the activity.
    /// </summary>
    [JsonPropertyName("cashExpected")]
    public MoneyV2? cashExpected { get; set; } = null;

    /// <summary>
    /// The point of sale device payment session associated with the activity.
    /// </summary>
    [JsonPropertyName("paymentSession")]
    public PointOfSaleDevicePaymentSession? paymentSession { get; set; } = null;

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
    /// The type of count activity.
    /// </summary>
    [JsonPropertyName("type")]
    public CashCountActivityType? type { get; set; } = null;
}