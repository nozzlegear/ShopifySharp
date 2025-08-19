#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents an email address.
/// </summary>
public record CustomerEmailAddress : IGraphQLObject
{
    /// <summary>
    /// The customer's default email address.
    /// </summary>
    [JsonPropertyName("emailAddress")]
    public string? emailAddress { get; set; } = null;

    /// <summary>
    /// The marketing subscription opt-in level, as described by the M3AAWG best practices guidelines,
    /// received when the marketing consent was updated.
    /// </summary>
    [JsonPropertyName("marketingOptInLevel")]
    public CustomerMarketingOptInLevel? marketingOptInLevel { get; set; } = null;

    /// <summary>
    /// Whether the customer has subscribed to email marketing.
    /// </summary>
    [JsonPropertyName("marketingState")]
    public CustomerEmailAddressMarketingState? marketingState { get; set; } = null;

    /// <summary>
    /// The URL to unsubscribe a member from all mailing lists.
    /// </summary>
    [JsonPropertyName("marketingUnsubscribeUrl")]
    public string? marketingUnsubscribeUrl { get; set; } = null;

    /// <summary>
    /// The date and time at which the marketing consent was updated.
    /// No date is provided if the email address never updated its marketing consent.
    /// </summary>
    [JsonPropertyName("marketingUpdatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? marketingUpdatedAt { get; set; } = null;

    /// <summary>
    /// Whether the customer has opted in to having their opened emails tracked.
    /// </summary>
    [JsonPropertyName("openTrackingLevel")]
    public CustomerEmailAddressOpenTrackingLevel? openTrackingLevel { get; set; } = null;

    /// <summary>
    /// The URL that can be used to opt a customer in or out of email open tracking.
    /// </summary>
    [JsonPropertyName("openTrackingUrl")]
    public string? openTrackingUrl { get; set; } = null;

    /// <summary>
    /// The location where the customer consented to receive marketing material by email.
    /// </summary>
    [JsonPropertyName("sourceLocation")]
    public Location? sourceLocation { get; set; } = null;

    /// <summary>
    /// Whether the email address is formatted correctly.
    /// Returns `true` when the email is formatted correctly. This doesn't guarantee that the email address
    /// actually exists.
    /// </summary>
    [JsonPropertyName("validFormat")]
    public bool? validFormat { get; set; } = null;
}