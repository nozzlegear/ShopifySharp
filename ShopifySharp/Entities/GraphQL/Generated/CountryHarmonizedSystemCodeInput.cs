#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to specify a harmonized system code.
/// </summary>
public record CountryHarmonizedSystemCodeInput : GraphQLInputObject<CountryHarmonizedSystemCodeInput>
{
    /// <summary>
    /// The ISO 3166-1 alpha-2 country code for the country that issued the specified harmonized system code.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// Country specific harmonized system code.
    /// </summary>
    [JsonPropertyName("harmonizedSystemCode")]
    public string? harmonizedSystemCode { get; set; } = null;
}