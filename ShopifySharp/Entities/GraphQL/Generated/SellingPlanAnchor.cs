#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies the date when delivery or fulfillment is completed by a merchant for a given time cycle. You can also
/// define a cutoff for which customers are eligible to enter this cycle and the desired behavior for customers who
/// start their subscription inside the cutoff period.
/// Some example scenarios where anchors can be useful to implement advanced delivery behavior:
/// - A merchant starts fulfillment on a specific date every month.
/// - A merchant wants to bill the 1st of every quarter.
/// - A customer expects their delivery every Tuesday.
/// For more details, see [About Selling Plans](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/selling-plans#anchors).
/// </summary>
public record SellingPlanAnchor : IGraphQLObject
{
    /// <summary>
    /// The cutoff day for the anchor. Specifies a buffer period before the anchor date for orders to be included in a
    /// delivery or fulfillment cycle.
    /// If `type` is WEEKDAY, then the value must be between 1-7. Shopify interprets
    /// the days of the week according to ISO 8601, where 1 is Monday.
    /// If `type` is MONTHDAY, then the value must be between 1-31.
    /// If `type` is YEARDAY, then the value must be `null`.
    /// </summary>
    [JsonPropertyName("cutoffDay")]
    public int? cutoffDay { get; set; } = null;

    /// <summary>
    /// The day of the anchor.
    /// If `type` is WEEKDAY, then the value must be between 1-7. Shopify interprets
    /// the days of the week according to ISO 8601, where 1 is Monday.
    /// If `type` isn't WEEKDAY, then the value must be between 1-31.
    /// </summary>
    [JsonPropertyName("day")]
    public int? day { get; set; } = null;

    /// <summary>
    /// The month of the anchor. If type is different than YEARDAY, then the value must
    /// be `null` or between 1-12.
    /// </summary>
    [JsonPropertyName("month")]
    public int? month { get; set; } = null;

    /// <summary>
    /// Represents the anchor type, it can be one one of WEEKDAY, MONTHDAY, YEARDAY.
    /// </summary>
    [JsonPropertyName("type")]
    public SellingPlanAnchorType? type { get; set; } = null;
}