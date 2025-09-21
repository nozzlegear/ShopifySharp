#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to create or update the address of a company location.
/// </summary>
public record CompanyAddressInput : GraphQLInputObject<CompanyAddressInput>
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
    /// The two-letter code ([ISO 3166-1
    /// alpha-2]](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format) for the
    /// country of the address. For example, `US`` for the United States.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// The first name of the recipient.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// The last name of the recipient.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// A phone number for the recipient. Formatted using E.164 standard. For example, _+16135551111_.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The identity of the recipient e.g. 'Receiving Department'.
    /// </summary>
    [JsonPropertyName("recipient")]
    public string? recipient { get; set; } = null;

    /// <summary>
    /// The zip or postal code of the address.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;

    /// <summary>
    /// The alphanumeric code for the region of the address, such as the province,
    /// state, or district. For example, `ON` for Ontario, Canada.
    /// </summary>
    [JsonPropertyName("zoneCode")]
    public string? zoneCode { get; set; } = null;
}