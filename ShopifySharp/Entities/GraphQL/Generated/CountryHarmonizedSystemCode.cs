#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The country-specific harmonized system code and ISO country code for an inventory item.
/// </summary>
public record CountryHarmonizedSystemCode : IGraphQLObject
{
    /// <summary>
    /// The ISO 3166-1 alpha-2 country code for the country that issued the specified harmonized system code.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// The country-specific harmonized system code. These are usually longer than 6 digits.
    /// </summary>
    [JsonPropertyName("harmonizedSystemCode")]
    public string? harmonizedSystemCode { get; set; } = null;
}