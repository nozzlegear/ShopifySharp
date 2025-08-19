#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to update an externally managed marketing activity.
/// </summary>
public record MarketingActivityUpdateExternalInput : GraphQLInputObject<MarketingActivityUpdateExternalInput>
{
    /// <summary>
    /// The amount spent on the marketing activity.
    /// </summary>
    [JsonPropertyName("adSpend")]
    public MoneyInput? adSpend { get; set; } = null;

    /// <summary>
    /// The budget for this marketing activity.
    /// </summary>
    [JsonPropertyName("budget")]
    public MarketingActivityBudgetInput? budget { get; set; } = null;

    /// <summary>
    /// The date and time at which the activity ended.
    /// </summary>
    [JsonPropertyName("end")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? end { get; set; } = null;

    /// <summary>
    /// The medium through which the marketing activity and event reached consumers. This is used for reporting aggregation.
    /// </summary>
    [JsonPropertyName("marketingChannelType")]
    public MarketingChannel? marketingChannelType { get; set; } = null;

    /// <summary>
    /// The domain from which ad clicks are forwarded to the shop.
    /// </summary>
    [JsonPropertyName("referringDomain")]
    public string? referringDomain { get; set; } = null;

    /// <summary>
    /// The URL for a preview image that's used for the marketing activity.
    /// </summary>
    [JsonPropertyName("remotePreviewImageUrl")]
    public string? remotePreviewImageUrl { get; set; } = null;

    /// <summary>
    /// The URL for viewing and/or managing the activity outside of Shopify.
    /// </summary>
    [JsonPropertyName("remoteUrl")]
    public string? remoteUrl { get; set; } = null;

    /// <summary>
    /// The date and time at which the activity is scheduled to end.
    /// </summary>
    [JsonPropertyName("scheduledEnd")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? scheduledEnd { get; set; } = null;

    /// <summary>
    /// The date and time at which the activity is scheduled to start.
    /// </summary>
    [JsonPropertyName("scheduledStart")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? scheduledStart { get; set; } = null;

    /// <summary>
    /// The date and time at which the activity started.
    /// </summary>
    [JsonPropertyName("start")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? start { get; set; } = null;

    /// <summary>
    /// The status of the marketing activity.
    /// </summary>
    [JsonPropertyName("status")]
    public MarketingActivityExternalStatus? status { get; set; } = null;

    /// <summary>
    /// The method of marketing used for this marketing activity. The marketing tactic
    /// determines which default fields are included in the marketing activity.
    /// </summary>
    [JsonPropertyName("tactic")]
    public MarketingTactic? tactic { get; set; } = null;

    /// <summary>
    /// The title of the marketing activity.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}