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
/// The marketing consent information for a
/// [customer](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)
/// on a specific marketing channel. Channel-specific types like [`CustomerWhatsAppMarketingConsent`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CustomerWhatsAppMarketingConsent)
/// implement this interface.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CustomerWhatsAppMarketingConsent), typeDiscriminator: "CustomerWhatsAppMarketingConsent")]
public interface ICustomerMarketingConsent : IGraphQLObject
{
    /// <summary>
    /// The [source](https://shopify.dev/docs/api/admin-graphql/latest/enums/CustomerConsentCollectedFrom) from which the marketing consent was collected.
    /// </summary>
    [JsonPropertyName("collectedFrom")]
    public CustomerConsentCollectedFrom? collectedFrom { get; set; }

    /// <summary>
    /// The [marketing subscription opt-in level](https://shopify.dev/docs/api/admin-graphql/latest/enums/CustomerMarketingOptInLevel)
    /// that was set when the customer's marketing consent was last updated. Follows
    /// M3AAWG best practices guidelines.
    /// </summary>
    [JsonPropertyName("optInLevel")]
    public CustomerMarketingOptInLevel? optInLevel { get; set; }

    /// <summary>
    /// The [location](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location)
    /// where the customer consented to receive marketing material.
    /// </summary>
    [JsonPropertyName("sourceLocation")]
    public Location? sourceLocation { get; set; }

    /// <summary>
    /// The customer's current [marketing consent state](https://shopify.dev/docs/api/admin-graphql/latest/enums/CustomerMarketingConsentState)
    /// for this channel.
    /// </summary>
    [JsonPropertyName("state")]
    public CustomerMarketingConsentState? state { get; set; }

    /// <summary>
    /// The date and time when the marketing consent was updated.
    /// No date is provided if the customer has never updated their marketing consent for this channel.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; }
}