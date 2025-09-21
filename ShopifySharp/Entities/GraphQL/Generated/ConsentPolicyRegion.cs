#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A country or region code.
/// </summary>
public record ConsentPolicyRegion : IGraphQLObject
{
    /// <summary>
    /// The `ISO 3166` country code for which the policy applies.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public PrivacyCountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// The `ISO 3166` region code for which the policy applies.
    /// </summary>
    [JsonPropertyName("regionCode")]
    public string? regionCode { get; set; } = null;
}