#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Marketing engagement represents customer activity taken on a marketing activity or a marketing channel.
/// </summary>
public record MarketingEngagement : IGraphQLObject
{
    /// <summary>
    /// The total ad spend for the marketing content. Recurring weekly, monthly, or
    /// yearly spend needs to be divided into daily amounts.
    /// </summary>
    [JsonPropertyName("adSpend")]
    public MoneyV2? adSpend { get; set; } = null;

    /// <summary>
    /// The unique string identifier of the channel to which the engagement metrics
    /// are being provided. This should be set when and only when providing
    /// channel-level engagements. This should be nil when providing activity-level
    /// engagements. For the correct handle for your channel, contact your partner manager.
    /// </summary>
    [JsonPropertyName("channelHandle")]
    public string? channelHandle { get; set; } = null;

    /// <summary>
    /// The total number of interactions, such as a button press or a screen touch, that occurred on the marketing content.
    /// </summary>
    [JsonPropertyName("clicksCount")]
    public int? clicksCount { get; set; } = null;

    /// <summary>
    /// The total number of comments on the marketing content.
    /// </summary>
    [JsonPropertyName("commentsCount")]
    public int? commentsCount { get; set; } = null;

    /// <summary>
    /// The total number of complaints on the marketing content. For message-based
    /// platforms such as email or SMS, this represents the number of marketing emails
    /// or messages that were marked as spam. For social media platforms, this
    /// represents the number of dislikes or the number of times marketing content was reported.
    /// </summary>
    [JsonPropertyName("complaintsCount")]
    public int? complaintsCount { get; set; } = null;

    /// <summary>
    /// The total number of fails for the marketing content. For message-based
    /// platforms such as email or SMS, this represents the number of bounced
    /// marketing emails or messages.
    /// </summary>
    [JsonPropertyName("failsCount")]
    public int? failsCount { get; set; } = null;

    /// <summary>
    /// The total number of favorites, likes, saves, or bookmarks on the marketing content.
    /// </summary>
    [JsonPropertyName("favoritesCount")]
    public int? favoritesCount { get; set; } = null;

    /// <summary>
    /// The number of customers that have placed their first order. Doesn't include
    /// adjustments such as edits, exchanges, or returns.
    /// </summary>
    [JsonPropertyName("firstTimeCustomers")]
    public decimal? firstTimeCustomers { get; set; } = null;

    /// <summary>
    /// The total number of times marketing content was displayed to users, whether or
    /// not an interaction occurred. For message-based platforms such as email or SMS,
    /// this represents the number of marketing emails or messages that were delivered.
    /// </summary>
    [JsonPropertyName("impressionsCount")]
    public int? impressionsCount { get; set; } = null;

    /// <summary>
    /// Specifies how the provided metrics have been aggregated. Cumulative metrics
    /// are aggregated from the first day of reporting up to and including
    /// `occuredOn`. Non-cumulative metrics are aggregated over the single day
    /// indicated in `occuredOn`. Cumulative metrics will monotonically increase in
    /// time as each record includes the previous day's values, and so on.
    /// Non-cumulative is strongly preferred, and support for cumulative metrics may
    /// be deprecated in the future.
    /// </summary>
    [JsonPropertyName("isCumulative")]
    public bool? isCumulative { get; set; } = null;

    /// <summary>
    /// The marketing activity object related to this engagement. This corresponds to
    /// the marketingActivityId passed in on creation of the engagement.
    /// </summary>
    [JsonPropertyName("marketingActivity")]
    public MarketingActivity? marketingActivity { get; set; } = null;

    /// <summary>
    /// The calendar date (in the time zone offset specified by the utcOffset field)
    /// for which the metrics are being reported. For example, a shop in UTC-5 would
    /// set utcOffset="-05:00" and aggregate all engagements from 05:00:00Z up to
    /// 29:00:00Z (5am UTC next day) for each call.
    /// </summary>
    [JsonPropertyName("occurredOn")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateOnly? occurredOn { get; set; } = null;

    /// <summary>
    /// The number of orders generated from the marketing content.
    /// </summary>
    [JsonPropertyName("orders")]
    public decimal? orders { get; set; } = null;

    /// <summary>
    /// The number of returning customers that have placed an order. Doesn't include
    /// adjustments such as edits, exchanges, or returns.
    /// </summary>
    [JsonPropertyName("returningCustomers")]
    public decimal? returningCustomers { get; set; } = null;

    /// <summary>
    /// The amount of sales generated from the marketing content.
    /// </summary>
    [JsonPropertyName("sales")]
    public MoneyV2? sales { get; set; } = null;

    /// <summary>
    /// The total number of marketing emails or messages that were sent.
    /// </summary>
    [JsonPropertyName("sendsCount")]
    public int? sendsCount { get; set; } = null;

    /// <summary>
    /// The number of online store sessions generated from the marketing content.
    /// </summary>
    [JsonPropertyName("sessionsCount")]
    public int? sessionsCount { get; set; } = null;

    /// <summary>
    /// The total number of times marketing content was distributed or reposted to
    /// either one's own network of followers through a social media platform or other
    /// digital channels. For message-based platforms such as email or SMS, this
    /// represents the number of times marketing emails or messages were forwarded.
    /// </summary>
    [JsonPropertyName("sharesCount")]
    public int? sharesCount { get; set; } = null;

    /// <summary>
    /// The total number of unique clicks on the marketing content.
    /// </summary>
    [JsonPropertyName("uniqueClicksCount")]
    public int? uniqueClicksCount { get; set; } = null;

    /// <summary>
    /// The total number of all users who saw marketing content since it was
    /// published. For  message-based platforms such as email or SMS, this represents
    /// the number of unique users that opened a  marketing email or message. For
    /// video-based content, this represents the number of unique users that  played video content.
    /// </summary>
    [JsonPropertyName("uniqueViewsCount")]
    public int? uniqueViewsCount { get; set; } = null;

    /// <summary>
    /// The total number of unsubscribes on the marketing content. For social media
    /// platforms, this represents the number of unfollows.
    /// </summary>
    [JsonPropertyName("unsubscribesCount")]
    public int? unsubscribesCount { get; set; } = null;

    /// <summary>
    /// The UTC offset for the time zone in which the metrics are being reported, in
    /// the format `"+HH:MM"` or `"-HH:MM"`. Used in combination with occurredOn when
    /// aggregating daily metrics. Must match the account settings for the shop to
    /// minimize eventual discrepancies in reporting.
    /// </summary>
    [JsonPropertyName("utcOffset")]
    public TimeSpan? utcOffset { get; set; } = null;

    /// <summary>
    /// The total number of views on the marketing content. For message-based
    /// platforms such as email or SMS, this represents the number of times marketing
    /// emails or messages were opened. For video-based content, this represents the
    /// number of times videos were played.
    /// </summary>
    [JsonPropertyName("viewsCount")]
    public int? viewsCount { get; set; } = null;
}