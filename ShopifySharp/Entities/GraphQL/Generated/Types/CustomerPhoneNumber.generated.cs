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
/// A phone number.
/// </summary>
public record CustomerPhoneNumber : IGraphQLObject
{
    /// <summary>
    /// The source from which the SMS marketing information for the customer was collected.
    /// </summary>
    [JsonPropertyName("marketingCollectedFrom")]
    [Obsolete("Use `smsMarketingConsent.collectedFrom` instead.")]
    public CustomerConsentCollectedFrom? marketingCollectedFrom { get; set; } = null;

    /// <summary>
    /// The marketing subscription opt-in level, as described by the M3AAWG best practices guidelines,
    /// received when the marketing consent was updated.
    /// </summary>
    [JsonPropertyName("marketingOptInLevel")]
    [Obsolete("Use `smsMarketingConsent.optInLevel` instead.")]
    public CustomerMarketingOptInLevel? marketingOptInLevel { get; set; } = null;

    /// <summary>
    /// Whether the customer has subscribed to SMS marketing material.
    /// </summary>
    [JsonPropertyName("marketingState")]
    [Obsolete("Use `smsMarketingConsent.state` instead.")]
    public CustomerSmsMarketingState? marketingState { get; set; } = null;

    /// <summary>
    /// The date and time at which the marketing consent was updated.
    /// No date is provided if the email address never updated its marketing consent.
    /// </summary>
    [JsonPropertyName("marketingUpdatedAt")]
    [Obsolete("Use `smsMarketingConsent.updatedAt` instead.")]
    public DateTimeOffset? marketingUpdatedAt { get; set; } = null;

    /// <summary>
    /// A customer's phone number.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public string? phoneNumber { get; set; } = null;

    /// <summary>
    /// The location where the customer consented to receive marketing material by SMS.
    /// </summary>
    [JsonPropertyName("sourceLocation")]
    [Obsolete("Use `smsMarketingConsent.sourceLocation` instead.")]
    public Location? sourceLocation { get; set; } = null;

    /// <summary>
    /// The [WhatsApp marketing consent](https://shopify.dev/docs/api/admin-graphql/latest/objects/CustomerWhatsAppMarketingConsent)
    /// information for the customer's phone number. Update with the [`customerWhatsAppMarketingConsentUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/customerWhatsAppMarketingConsentUpdate) mutation.
    /// </summary>
    [JsonPropertyName("whatsAppMarketingConsent")]
    public CustomerWhatsAppMarketingConsent? whatsAppMarketingConsent { get; set; } = null;
}