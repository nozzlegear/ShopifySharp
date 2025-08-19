#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to create or update a mailing address.
/// </summary>
public record MailingAddressInput : GraphQLInputObject<MailingAddressInput>
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
    /// The name of the customer's company or organization.
    /// </summary>
    [JsonPropertyName("company")]
    public string? company { get; set; } = null;

    /// <summary>
    /// The two-letter code for the country of the address.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// The first name of the customer.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// The last name of the customer.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// A unique phone number for the customer.
    /// Formatted using E.164 standard. For example, _+16135551111_.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The code for the region of the address, such as the province, state, or district.
    /// For example QC for Quebec, Canada.
    /// </summary>
    [JsonPropertyName("provinceCode")]
    public string? provinceCode { get; set; } = null;

    /// <summary>
    /// The zip or postal code of the address.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;
}