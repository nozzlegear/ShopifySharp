#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Information that describes when a customer consented to
///         receiving marketing material by email.
/// </summary>
public record CustomerEmailMarketingConsentInput : GraphQLInputObject<CustomerEmailMarketingConsentInput>
{
    /// <summary>
    /// The latest date and time when the customer consented or objected to
    ///           receiving marketing material by email.
    /// </summary>
    [JsonPropertyName("consentUpdatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? consentUpdatedAt { get; set; } = null;

    /// <summary>
    /// The customer opt-in level at the time of subscribing to marketing material.
    /// </summary>
    [JsonPropertyName("marketingOptInLevel")]
    public CustomerMarketingOptInLevel? marketingOptInLevel { get; set; } = null;

    /// <summary>
    /// The current marketing state associated with the customer's email.
    ///           If the customer doesn't have an email, then this field is `null`.
    /// </summary>
    [JsonPropertyName("marketingState")]
    public CustomerEmailMarketingState? marketingState { get; set; } = null;

    /// <summary>
    /// Identifies the location where the customer consented to receiving marketing material by email.
    /// </summary>
    [JsonPropertyName("sourceLocationId")]
    public string? sourceLocationId { get; set; } = null;
}