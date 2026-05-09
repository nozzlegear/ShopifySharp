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
/// A summary of cash management data.
/// </summary>
public record CashManagementSummary : IGraphQLObject
{
    /// <summary>
    /// The cumulative cash balance of all cash drawers at the provided end date.
    /// </summary>
    [JsonPropertyName("cashBalanceAtEnd")]
    public MoneyV2? cashBalanceAtEnd { get; set; } = null;

    /// <summary>
    /// The cumulative cash balance of all cash drawers at the provided start date.
    /// </summary>
    [JsonPropertyName("cashBalanceAtStart")]
    public MoneyV2? cashBalanceAtStart { get; set; } = null;

    /// <summary>
    /// The net cash flow during the specified period (start date to end date). Calculated as net sales plus adjustments.
    /// </summary>
    [JsonPropertyName("netCash")]
    public MoneyV2? netCash { get; set; } = null;

    /// <summary>
    /// The number of sessions that were closed during the specified period (start date to end date).
    /// </summary>
    [JsonPropertyName("sessionsClosed")]
    public int? sessionsClosed { get; set; } = null;

    /// <summary>
    /// The number of sessions that were opened during the specified period (start date to end date).
    /// </summary>
    [JsonPropertyName("sessionsOpened")]
    public int? sessionsOpened { get; set; } = null;

    /// <summary>
    /// The total cash discrepancies during the specified period (start date to end date).
    /// </summary>
    [JsonPropertyName("totalDiscrepancies")]
    public MoneyV2? totalDiscrepancies { get; set; } = null;
}