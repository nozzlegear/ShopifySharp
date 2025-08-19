#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Billing preferences for the shop.
/// </summary>
public record ShopBillingPreferences : IGraphQLObject
{
    /// <summary>
    /// The currency the shop uses to pay for apps and services.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? currency { get; set; } = null;
}