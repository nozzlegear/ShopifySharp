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
/// A country that is used to define a shipping zone.
/// </summary>
public record DeliveryCountry : IGraphQLObject, INode
{
    /// <summary>
    /// A two-letter country code in ISO 3166-1 alpha-2 standard.
    /// It also includes a flag indicating whether the country should be
    /// a part of the 'Rest Of World' shipping zone.
    /// </summary>
    [JsonPropertyName("code")]
    public DeliveryCountryCodeOrRestOfWorld? code { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The full name of the country.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The list of regions associated with this country.
    /// </summary>
    [JsonPropertyName("provinces")]
    public ICollection<DeliveryProvince>? provinces { get; set; } = null;

    /// <summary>
    /// The translated name of the country. The translation returned is based on the system's locale.
    /// </summary>
    [JsonPropertyName("translatedName")]
    public string? translatedName { get; set; } = null;
}