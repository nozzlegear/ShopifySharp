#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `customerSmsMarketingConsentUpdate` mutation.
/// </summary>
public record CustomerSmsMarketingConsentUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated customer.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CustomerSmsMarketingConsentError>? userErrors { get; set; } = null;
}