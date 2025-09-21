#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The marketing consent information when the customer consented to
///         receiving marketing material by SMS.
/// </summary>
public record CustomerSmsMarketingConsentInput : GraphQLInputObject<CustomerSmsMarketingConsentInput>
{
    /// <summary>
    /// The date and time when the customer consented to receive marketing material by SMS.
    /// If no date is provided, then the date and time when the consent information was sent is used.
    /// </summary>
    [JsonPropertyName("consentUpdatedAt")]
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
    /// Identifies the location where the customer consented to receiving marketing material by SMS.
    /// </summary>
    [JsonPropertyName("sourceLocationId")]
    public string? sourceLocationId { get; set; } = null;
}