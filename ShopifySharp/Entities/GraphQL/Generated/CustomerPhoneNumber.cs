#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A phone number.
/// </summary>
public record CustomerPhoneNumber : IGraphQLObject
{
    /// <summary>
    /// The source from which the SMS marketing information for the customer was collected.
    /// </summary>
    [JsonPropertyName("marketingCollectedFrom")]
    public CustomerConsentCollectedFrom? marketingCollectedFrom { get; set; } = null;

    /// <summary>
    /// The marketing subscription opt-in level, as described by the M3AAWG best practices guidelines,
    /// received when the marketing consent was updated.
    /// </summary>
    [JsonPropertyName("marketingOptInLevel")]
    public CustomerMarketingOptInLevel? marketingOptInLevel { get; set; } = null;

    /// <summary>
    /// Whether the customer has subscribed to SMS marketing material.
    /// </summary>
    [JsonPropertyName("marketingState")]
    public CustomerSmsMarketingState? marketingState { get; set; } = null;

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
    /// A customer's phone number.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public string? phoneNumber { get; set; } = null;

    /// <summary>
    /// The location where the customer consented to receive marketing material by SMS.
    /// </summary>
    [JsonPropertyName("sourceLocation")]
    public Location? sourceLocation { get; set; } = null;
}