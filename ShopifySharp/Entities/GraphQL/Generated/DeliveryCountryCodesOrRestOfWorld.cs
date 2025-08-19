#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The list of country codes and information whether the countries
/// are a part of the 'Rest Of World' shipping zone.
/// </summary>
public record DeliveryCountryCodesOrRestOfWorld : IGraphQLObject
{
    /// <summary>
    /// List of applicable country codes in the ISO 3166-1 alpha-2 format.
    /// </summary>
    [JsonPropertyName("countryCodes")]
    public ICollection<CountryCode>? countryCodes { get; set; } = null;

    /// <summary>
    /// Whether the countries are a part of the 'Rest of World' shipping zone.
    /// </summary>
    [JsonPropertyName("restOfWorld")]
    public bool? restOfWorld { get; set; } = null;
}