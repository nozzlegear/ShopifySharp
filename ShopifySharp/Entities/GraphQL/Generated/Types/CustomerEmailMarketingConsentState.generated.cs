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
/// The record of when a customer consented to receive marketing material by email.
/// </summary>
public record CustomerEmailMarketingConsentState : IGraphQLObject
{
    /// <summary>
    /// The date and time at which the customer consented to receive marketing material by email.
    /// The customer's consent state reflects the consent record with the most recent `consent_updated_at` date.
    /// If no date is provided, then the date and time at which the consent information was sent is used.
    /// </summary>
    [JsonPropertyName("consentUpdatedAt")]
    public DateTimeOffset? consentUpdatedAt { get; set; } = null;

    /// <summary>
    /// The marketing subscription opt-in level, as described by the M3AAWG best practices guidelines,
    /// that the customer gave when they consented to receive marketing material by email.
    /// </summary>
    [JsonPropertyName("marketingOptInLevel")]
    public CustomerMarketingOptInLevel? marketingOptInLevel { get; set; } = null;

    /// <summary>
    /// The current email marketing state for the customer.
    /// </summary>
    [JsonPropertyName("marketingState")]
    public CustomerEmailMarketingState? marketingState { get; set; } = null;

    /// <summary>
    /// The location where the customer consented to receive marketing material by email.
    /// </summary>
    [JsonPropertyName("sourceLocation")]
    public Location? sourceLocation { get; set; } = null;
}