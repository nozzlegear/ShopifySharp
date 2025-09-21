#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The list of all the countries from the combined shipping zones for the shop.
/// </summary>
public record CountriesInShippingZones : IGraphQLObject
{
    /// <summary>
    /// The list of all the countries from all the combined shipping zones.
    /// </summary>
    [JsonPropertyName("countryCodes")]
    public ICollection<CountryCode>? countryCodes { get; set; } = null;

    /// <summary>
    /// Whether 'Rest of World' has been defined in any of the shipping zones.
    /// </summary>
    [JsonPropertyName("includeRestOfWorld")]
    public bool? includeRestOfWorld { get; set; } = null;
}