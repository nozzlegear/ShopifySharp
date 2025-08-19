#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The country code and whether the country is a part of the 'Rest Of World' shipping zone.
/// </summary>
public record DeliveryCountryCodeOrRestOfWorld : IGraphQLObject
{
    /// <summary>
    /// The country code in the ISO 3166-1 alpha-2 format.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// Whether the country is a part of the 'Rest of World' shipping zone.
    /// </summary>
    [JsonPropertyName("restOfWorld")]
    public bool? restOfWorld { get; set; } = null;
}