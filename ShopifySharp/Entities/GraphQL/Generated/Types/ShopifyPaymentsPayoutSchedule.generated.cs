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
/// The payment schedule for a payments account.
/// </summary>
public record ShopifyPaymentsPayoutSchedule : IGraphQLObject
{
    /// <summary>
    /// The interval at which payouts are sent to the connected bank account.
    /// </summary>
    [JsonPropertyName("interval")]
    public ShopifyPaymentsPayoutInterval? interval { get; set; } = null;

    /// <summary>
    /// The day of the month funds will be paid out.
    /// The value can be any day of the month from the 1st to the 31st.
    /// If the payment interval is set to monthly, this value will be used.
    /// Payouts scheduled between 29-31st of the month are sent on the last day of shorter months.
    /// </summary>
    [JsonPropertyName("monthlyAnchor")]
    public int? monthlyAnchor { get; set; } = null;

    /// <summary>
    /// The day of the week funds will be paid out.
    /// The value can be any weekday from Monday to Friday.
    /// If the payment interval is set to weekly, this value will be used.
    /// </summary>
    [JsonPropertyName("weeklyAnchor")]
    public DayOfTheWeek? weeklyAnchor { get; set; } = null;
}