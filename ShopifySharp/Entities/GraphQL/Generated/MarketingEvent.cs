#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents actions that market a merchant's store or products.
/// </summary>
public record MarketingEvent : IGraphQLObject, ILegacyInteroperability, INode
{
    /// <summary>
    /// The app that the marketing event is attributed to.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The medium through which the marketing activity and event reached consumers. This is used for reporting aggregation.
    /// </summary>
    [JsonPropertyName("channel")]
    [Obsolete("Use `marketingChannelType` instead.")]
    public MarketingChannel? channel { get; set; } = null;

    /// <summary>
    /// The unique string identifier of the channel to which this activity belongs.
    /// For the correct handle for your channel, contact your partner manager.
    /// </summary>
    [JsonPropertyName("channelHandle")]
    public string? channelHandle { get; set; } = null;

    /// <summary>
    /// A human-readable description of the marketing event.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The date and time when the marketing event ended.
    /// </summary>
    [JsonPropertyName("endedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? endedAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The URL where the marketing event can be managed.
    /// </summary>
    [JsonPropertyName("manageUrl")]
    public string? manageUrl { get; set; } = null;

    /// <summary>
    /// The medium through which the marketing activity and event reached consumers. This is used for reporting aggregation.
    /// </summary>
    [JsonPropertyName("marketingChannelType")]
    public MarketingChannel? marketingChannelType { get; set; } = null;

    /// <summary>
    /// The URL where the marketing event can be previewed.
    /// </summary>
    [JsonPropertyName("previewUrl")]
    public string? previewUrl { get; set; } = null;

    /// <summary>
    /// An optional ID that helps Shopify validate engagement data.
    /// </summary>
    [JsonPropertyName("remoteId")]
    public string? remoteId { get; set; } = null;

    /// <summary>
    /// The date and time when the marketing event is scheduled to end.
    /// </summary>
    [JsonPropertyName("scheduledToEndAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? scheduledToEndAt { get; set; } = null;

    /// <summary>
    /// Where the `MarketingEvent` occurred and what kind of content was used.
    /// Because `utmSource` and `utmMedium` are often used interchangeably, this is
    /// based on a combination of `marketingChannel`, `referringDomain`, and `type` to
    /// provide a consistent representation for any given piece of marketing
    /// regardless of the app that created it.
    /// </summary>
    [JsonPropertyName("sourceAndMedium")]
    public string? sourceAndMedium { get; set; } = null;

    /// <summary>
    /// The date and time when the marketing event started.
    /// </summary>
    [JsonPropertyName("startedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? startedAt { get; set; } = null;

    /// <summary>
    /// The display text for the marketing event type.
    /// </summary>
    [JsonPropertyName("targetTypeDisplayText")]
    [Obsolete("Use `sourceAndMedium` instead.")]
    public string? targetTypeDisplayText { get; set; } = null;

    /// <summary>
    /// The marketing event type.
    /// </summary>
    [JsonPropertyName("type")]
    public MarketingTactic? type { get; set; } = null;

    /// <summary>
    /// The name of the marketing campaign.
    /// </summary>
    [JsonPropertyName("utmCampaign")]
    public string? utmCampaign { get; set; } = null;

    /// <summary>
    /// The medium that the marketing campaign is using. Example values: `cpc`, `banner`.
    /// </summary>
    [JsonPropertyName("utmMedium")]
    public string? utmMedium { get; set; } = null;

    /// <summary>
    /// The referrer of the marketing event. Example values: `google`, `newsletter`.
    /// </summary>
    [JsonPropertyName("utmSource")]
    public string? utmSource { get; set; } = null;
}