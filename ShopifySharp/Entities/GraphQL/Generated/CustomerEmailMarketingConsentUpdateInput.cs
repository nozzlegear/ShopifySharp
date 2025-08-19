#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the email consent information to update for a given customer ID.
/// </summary>
public record CustomerEmailMarketingConsentUpdateInput : GraphQLInputObject<CustomerEmailMarketingConsentUpdateInput>
{
    /// <summary>
    /// The ID of the customer for which to update the email marketing consent
    /// information. The customer must have a unique email address associated to the
    /// record. If not, add the email address using the `customerUpdate` mutation first.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? customerId { get; set; } = null;

    /// <summary>
    /// The marketing consent information when the customer consented to receiving marketing material by email.
    /// </summary>
    [JsonPropertyName("emailMarketingConsent")]
    public CustomerEmailMarketingConsentInput? emailMarketingConsent { get; set; } = null;
}