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
/// The marketing activity resource represents marketing that a
///         merchant created through an app.
/// </summary>
public record MarketingActivity : IGraphQLObject, INode
{
    /// <summary>
    /// The URL of the marketing activity listing page in the marketing section.
    /// </summary>
    [JsonPropertyName("activityListUrl")]
    public string? activityListUrl { get; set; } = null;

    /// <summary>
    /// The amount spent on the marketing activity.
    /// </summary>
    [JsonPropertyName("adSpend")]
    public MoneyV2? adSpend { get; set; } = null;

    /// <summary>
    /// The app which created this marketing activity.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The errors generated when an app publishes the marketing activity.
    /// </summary>
    [JsonPropertyName("appErrors")]
    public MarketingActivityExtensionAppErrors? appErrors { get; set; } = null;

    /// <summary>
    /// The allocated budget for the marketing activity.
    /// </summary>
    [JsonPropertyName("budget")]
    public MarketingBudget? budget { get; set; } = null;

    /// <summary>
    /// The date and time when the marketing activity was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The completed content in the marketing activity creation form.
    /// </summary>
    [JsonPropertyName("formData")]
    public string? formData { get; set; } = null;

    /// <summary>
    /// The hierarchy level of the marketing activity.
    /// </summary>
    [JsonPropertyName("hierarchyLevel")]
    public MarketingActivityHierarchyLevel? hierarchyLevel { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the marketing activity is in the main workflow version of the marketing automation.
    /// </summary>
    [JsonPropertyName("inMainWorkflowVersion")]
    public bool? inMainWorkflowVersion { get; set; } = null;

    /// <summary>
    /// The marketing activity represents an external marketing activity.
    /// </summary>
    [JsonPropertyName("isExternal")]
    public bool? isExternal { get; set; } = null;

    /// <summary>
    /// The medium through which the marketing activity and event reached consumers. This is used for reporting aggregation.
    /// </summary>
    [JsonPropertyName("marketingChannel")]
    [Obsolete("Use `marketingChannelType` instead.")]
    public MarketingChannel? marketingChannel { get; set; } = null;

    /// <summary>
    /// The medium through which the marketing activity and event reached consumers. This is used for reporting aggregation.
    /// </summary>
    [JsonPropertyName("marketingChannelType")]
    public MarketingChannel? marketingChannelType { get; set; } = null;

    /// <summary>
    /// Associated marketing event of this marketing activity.
    /// </summary>
    [JsonPropertyName("marketingEvent")]
    public MarketingEvent? marketingEvent { get; set; } = null;

    /// <summary>
    /// ID of the parent activity of this marketing activity.
    /// </summary>
    [JsonPropertyName("parentActivityId")]
    public string? parentActivityId { get; set; } = null;

    /// <summary>
    /// ID of the parent activity of this marketing activity.
    /// </summary>
    [JsonPropertyName("parentRemoteId")]
    public string? parentRemoteId { get; set; } = null;

    /// <summary>
    /// A contextual description of the marketing activity based on the platform and tactic used.
    /// </summary>
    [JsonPropertyName("sourceAndMedium")]
    public string? sourceAndMedium { get; set; } = null;

    /// <summary>
    /// The current state of the marketing activity.
    /// </summary>
    [JsonPropertyName("status")]
    public MarketingActivityStatus? status { get; set; } = null;

    /// <summary>
    /// The severity of the marketing activity's status.
    /// </summary>
    [JsonPropertyName("statusBadgeType")]
    [Obsolete("Use `statusBadgeTypeV2` instead.")]
    public MarketingActivityStatusBadgeType? statusBadgeType { get; set; } = null;

    /// <summary>
    /// The severity of the marketing activity's status.
    /// </summary>
    [JsonPropertyName("statusBadgeTypeV2")]
    public BadgeType? statusBadgeTypeV2 { get; set; } = null;

    /// <summary>
    /// The rendered status of the marketing activity.
    /// </summary>
    [JsonPropertyName("statusLabel")]
    public string? statusLabel { get; set; } = null;

    /// <summary>
    /// The [date and time](
    ///           https://help.shopify.com/https://en.wikipedia.org/wiki/ISO_8601
    ///           ) when the activity's status last changed.
    /// </summary>
    [JsonPropertyName("statusTransitionedAt")]
    public DateTimeOffset? statusTransitionedAt { get; set; } = null;

    /// <summary>
    /// The method of marketing used for this marketing activity.
    /// </summary>
    [JsonPropertyName("tactic")]
    public MarketingTactic? tactic { get; set; } = null;

    /// <summary>
    /// The status to which the marketing activity is currently transitioning.
    /// </summary>
    [JsonPropertyName("targetStatus")]
    public MarketingActivityStatus? targetStatus { get; set; } = null;

    /// <summary>
    /// The marketing activity's title, which is rendered on the marketing listing page.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The date and time when the marketing activity was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;

    /// <summary>
    /// The value portion of the URL query parameter used in attributing sessions to this activity.
    /// </summary>
    [JsonPropertyName("urlParameterValue")]
    public string? urlParameterValue { get; set; } = null;

    /// <summary>
    /// The set of [Urchin Tracking Module](
    ///           https://help.shopify.com/https://en.wikipedia.org/wiki/UTM_parameters
    ///           ) used in the URL for tracking this marketing activity.
    /// </summary>
    [JsonPropertyName("utmParameters")]
    public UTMParameters? utmParameters { get; set; } = null;
}