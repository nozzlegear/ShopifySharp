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
/// The input fields to update a customer's WhatsApp marketing consent information.
/// </summary>
public record CustomerWhatsAppMarketingConsentUpdateInput : GraphQLInputObject<CustomerWhatsAppMarketingConsentUpdateInput>
{
    /// <summary>
    /// The ID of the [customer](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)
    /// to update the WhatsApp marketing consent information for. The customer must
    /// have a unique phone number associated with their record. If not, then add the
    /// phone number using the [`customerUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/customerUpdate)
    /// mutation first.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? customerId { get; set; } = null;

    /// <summary>
    /// The marketing consent information when the customer consented to receiving marketing material by WhatsApp.
    /// </summary>
    [JsonPropertyName("whatsAppMarketingConsent")]
    public CustomerMarketingConsentInput? whatsAppMarketingConsent { get; set; } = null;
}