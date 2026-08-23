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
/// The input fields for marketing consent information when a
/// [customer](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)
/// consents to receive marketing material on a specific channel. Channel-specific
/// consent mutations like [`customerWhatsAppMarketingConsentUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/customerWhatsAppMarketingConsentUpdate)
/// use this input.
/// </summary>
public record CustomerMarketingConsentInput : GraphQLInputObject<CustomerMarketingConsentInput>
{
    /// <summary>
    /// The [marketing subscription opt-in level](https://shopify.dev/docs/api/admin-graphql/latest/enums/CustomerMarketingOptInLevel)
    /// that was set when the customer consented to receive marketing information.
    /// </summary>
    [JsonPropertyName("optInLevel")]
    public CustomerMarketingOptInLevel? optInLevel { get; set; } = null;

    /// <summary>
    /// Identifies the [location](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location)
    /// where the customer consented to receiving marketing material.
    /// </summary>
    [JsonPropertyName("sourceLocationId")]
    public string? sourceLocationId { get; set; } = null;

    /// <summary>
    /// The [marketing consent state](https://shopify.dev/docs/api/admin-graphql/latest/enums/CustomerMarketingConsentState)
    /// to set for the customer on this channel.
    /// </summary>
    [JsonPropertyName("state")]
    public CustomerMarketingConsentState? state { get; set; } = null;

    /// <summary>
    /// The date and time when the customer consented to receive marketing material.
    /// If no date is provided, then the date and time when the consent information was sent is used.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}