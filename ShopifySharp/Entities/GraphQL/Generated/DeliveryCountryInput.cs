#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to specify a country.
/// </summary>
public record DeliveryCountryInput : GraphQLInputObject<DeliveryCountryInput>
{
    /// <summary>
    /// The country code of the country in the ISO 3166-1 alpha-2 format.
    /// </summary>
    [JsonPropertyName("code")]
    public CountryCode? code { get; set; } = null;

    /// <summary>
    /// Associate all available provinces with this country.
    /// </summary>
    [JsonPropertyName("includeAllProvinces")]
    public bool? includeAllProvinces { get; set; } = null;

    /// <summary>
    /// The regions associated with this country.
    /// </summary>
    [JsonPropertyName("provinces")]
    public ICollection<DeliveryProvinceInput>? provinces { get; set; } = null;

    /// <summary>
    /// Whether the country is a part of the 'Rest of World' shipping zone.
    /// </summary>
    [JsonPropertyName("restOfWorld")]
    public bool? restOfWorld { get; set; } = null;
}