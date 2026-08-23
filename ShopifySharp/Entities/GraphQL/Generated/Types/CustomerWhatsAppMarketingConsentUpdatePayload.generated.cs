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
/// Return type for `customerWhatsAppMarketingConsentUpdate` mutation.
/// </summary>
public record CustomerWhatsAppMarketingConsentUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The [customer phone number](https://shopify.dev/docs/api/admin-graphql/latest/objects/CustomerPhoneNumber)
    /// with the updated WhatsApp marketing consent information.
    /// </summary>
    [JsonPropertyName("customerPhoneNumber")]
    public CustomerPhoneNumber? customerPhoneNumber { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CustomerMarketingConsentError>? userErrors { get; set; } = null;
}