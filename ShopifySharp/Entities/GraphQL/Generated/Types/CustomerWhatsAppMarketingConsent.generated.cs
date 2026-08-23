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
/// The WhatsApp marketing consent information for a [customer's phone number](https://shopify.dev/docs/api/admin-graphql/latest/objects/CustomerPhoneNumber). Implements the [`CustomerMarketingConsent`](https://shopify.dev/docs/api/admin-graphql/latest/interfaces/CustomerMarketingConsent)
/// interface. Use the [`customerWhatsAppMarketingConsentUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/customerWhatsAppMarketingConsentUpdate)
/// mutation to update it.
/// </summary>
public record CustomerWhatsAppMarketingConsent : IGraphQLObject, ICustomerMarketingConsent
{
    /// <summary>
    /// The [source](https://shopify.dev/docs/api/admin-graphql/latest/enums/CustomerConsentCollectedFrom) from which the marketing consent was collected.
    /// </summary>
    [JsonPropertyName("collectedFrom")]
    public CustomerConsentCollectedFrom? collectedFrom { get; set; } = null;

    /// <summary>
    /// The [marketing subscription opt-in level](https://shopify.dev/docs/api/admin-graphql/latest/enums/CustomerMarketingOptInLevel)
    /// that was set when the customer's marketing consent was last updated. Follows
    /// M3AAWG best practices guidelines.
    /// </summary>
    [JsonPropertyName("optInLevel")]
    public CustomerMarketingOptInLevel? optInLevel { get; set; } = null;

    /// <summary>
    /// The [location](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location)
    /// where the customer consented to receive marketing material.
    /// </summary>
    [JsonPropertyName("sourceLocation")]
    public Location? sourceLocation { get; set; } = null;

    /// <summary>
    /// The customer's current [marketing consent state](https://shopify.dev/docs/api/admin-graphql/latest/enums/CustomerMarketingConsentState)
    /// for this channel.
    /// </summary>
    [JsonPropertyName("state")]
    public CustomerMarketingConsentState? state { get; set; } = null;

    /// <summary>
    /// The date and time when the marketing consent was updated.
    /// No date is provided if the customer has never updated their marketing consent for this channel.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}