#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The record of when a customer consented to receive marketing material by SMS.
/// The customer's consent state reflects the record with the most recent date when consent was updated.
/// </summary>
public record CustomerSmsMarketingConsentState : IGraphQLObject
{
    /// <summary>
    /// The source from which the SMS marketing information for the customer was collected.
    /// </summary>
    [JsonPropertyName("consentCollectedFrom")]
    public CustomerConsentCollectedFrom? consentCollectedFrom { get; set; } = null;

    /// <summary>
    /// The date and time when the customer consented to receive marketing material by SMS.
    /// If no date is provided, then the date and time when the consent information was sent is used.
    /// </summary>
    [JsonPropertyName("consentUpdatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? consentUpdatedAt { get; set; } = null;

    /// <summary>
    /// The marketing subscription opt-in level that was set when the customer consented to receive marketing information.
    /// </summary>
    [JsonPropertyName("marketingOptInLevel")]
    public CustomerMarketingOptInLevel? marketingOptInLevel { get; set; } = null;

    /// <summary>
    /// The current SMS marketing state for the customer.
    /// </summary>
    [JsonPropertyName("marketingState")]
    public CustomerSmsMarketingState? marketingState { get; set; } = null;

    /// <summary>
    /// The location where the customer consented to receive marketing material by SMS.
    /// </summary>
    [JsonPropertyName("sourceLocation")]
    public Location? sourceLocation { get; set; } = null;
}