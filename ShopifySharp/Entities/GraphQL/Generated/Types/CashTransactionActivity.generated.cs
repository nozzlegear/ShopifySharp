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
/// A cash transaction activity.
/// </summary>
public record CashTransactionActivity : IGraphQLObject, ICashActivity
{
    /// <summary>
    /// The amount of cash added or removed as part of the activity.
    /// </summary>
    [JsonPropertyName("cash")]
    public MoneyV2? cash { get; set; } = null;

    /// <summary>
    /// The order transaction associated with the activity.
    /// </summary>
    [JsonPropertyName("orderTransaction")]
    public OrderTransaction? orderTransaction { get; set; } = null;

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
    /// The type of transaction activity.
    /// </summary>
    [JsonPropertyName("type")]
    public CashTransactionActivityType? type { get; set; } = null;
}