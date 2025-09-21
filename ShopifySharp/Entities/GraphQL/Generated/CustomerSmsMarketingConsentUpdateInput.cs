#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for updating SMS marketing consent information for a given customer ID.
/// </summary>
public record CustomerSmsMarketingConsentUpdateInput : GraphQLInputObject<CustomerSmsMarketingConsentUpdateInput>
{
    /// <summary>
    /// The ID of the customer to update the SMS marketing consent information for.
    /// The customer must have a unique phone number associated to the record. If not,
    /// add the phone number using the `customerUpdate` mutation first.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? customerId { get; set; } = null;

    /// <summary>
    /// The marketing consent information when the customer consented to receiving marketing material by SMS.
    /// </summary>
    [JsonPropertyName("smsMarketingConsent")]
    public CustomerSmsMarketingConsentInput? smsMarketingConsent { get; set; } = null;
}