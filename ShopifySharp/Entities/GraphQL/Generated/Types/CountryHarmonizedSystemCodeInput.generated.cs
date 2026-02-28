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
/// The input fields required to specify a harmonized system code.
/// </summary>
public record CountryHarmonizedSystemCodeInput : GraphQLInputObject<CountryHarmonizedSystemCodeInput>
{
    /// <summary>
    /// The ISO 3166-1 alpha-2 country code for the country that issued the specified
    /// harmonized system code. Represents global harmonized system code when set to null.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// Country specific harmonized system code.
    /// </summary>
    [JsonPropertyName("harmonizedSystemCode")]
    public string? harmonizedSystemCode { get; set; } = null;
}