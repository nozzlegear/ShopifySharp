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
/// An address for a shop.
/// </summary>
public record ShopAddress : IGraphQLObject, INode
{
    /// <summary>
    /// The first line of the address. Typically the street address or PO Box number.
    /// </summary>
    [JsonPropertyName("address1")]
    public string? address1 { get; set; } = null;

    /// <summary>
    /// The second line of the address. Typically the number of the apartment, suite, or unit.
    /// </summary>
    [JsonPropertyName("address2")]
    public string? address2 { get; set; } = null;

    /// <summary>
    /// The name of the city, district, village, or town.
    /// </summary>
    [JsonPropertyName("city")]
    public string? city { get; set; } = null;

    /// <summary>
    /// The name of the company or organization.
    /// </summary>
    [JsonPropertyName("company")]
    public string? company { get; set; } = null;

    /// <summary>
    /// Whether the address coordinates are valid.
    /// </summary>
    [JsonPropertyName("coordinatesValidated")]
    public bool? coordinatesValidated { get; set; } = null;

    /// <summary>
    /// The name of the country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? country { get; set; } = null;

    /// <summary>
    /// The two-letter code for the country of the address.
    /// For example, US.
    /// </summary>
    [JsonPropertyName("countryCode")]
    [Obsolete("Use `countryCodeV2` instead.")]
    public string? countryCode { get; set; } = null;

    /// <summary>
    /// The two-letter code for the country of the address.
    /// For example, US.
    /// </summary>
    [JsonPropertyName("countryCodeV2")]
    public CountryCode? countryCodeV2 { get; set; } = null;

    /// <summary>
    /// The first name.
    /// </summary>
    [JsonPropertyName("firstName")]
    [Obsolete("Always null in this context.")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// A formatted version of the address, customized by the provided arguments.
    /// </summary>
    [JsonPropertyName("formatted")]
    public ICollection<string>? formatted { get; set; } = null;

    /// <summary>
    /// A comma-separated list of the values for city, province, and country.
    /// </summary>
    [JsonPropertyName("formattedArea")]
    public string? formattedArea { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The last name.
    /// </summary>
    [JsonPropertyName("lastName")]
    [Obsolete("Always null in this context.")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// The latitude coordinate of the address.
    /// </summary>
    [JsonPropertyName("latitude")]
    public decimal? latitude { get; set; } = null;

    /// <summary>
    /// The longitude coordinate of the address.
    /// </summary>
    [JsonPropertyName("longitude")]
    public decimal? longitude { get; set; } = null;

    /// <summary>
    /// The full name, based on firstName and lastName.
    /// </summary>
    [JsonPropertyName("name")]
    [Obsolete("Always null in this context.")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A phone number associated with the address.
    /// Formatted using E.164 standard. For example, _+16135551111_.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The region of the address, such as the province, state, or district.
    /// </summary>
    [JsonPropertyName("province")]
    public string? province { get; set; } = null;

    /// <summary>
    /// The alphanumeric code for the region.
    /// For example, ON.
    /// </summary>
    [JsonPropertyName("provinceCode")]
    public string? provinceCode { get; set; } = null;

    /// <summary>
    /// The zip or postal code of the address.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;
}