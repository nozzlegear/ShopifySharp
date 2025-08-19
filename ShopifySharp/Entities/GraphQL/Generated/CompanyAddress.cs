#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a billing or shipping address for a company location.
/// </summary>
public record CompanyAddress : IGraphQLObject, INode
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
    /// The name of the company.
    /// </summary>
    [JsonPropertyName("companyName")]
    public string? companyName { get; set; } = null;

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
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) at which the company address was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The first name of the recipient.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// The formatted version of the address.
    /// </summary>
    [JsonPropertyName("formattedAddress")]
    public ICollection<string>? formattedAddress { get; set; } = null;

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
    /// The last name of the recipient.
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
    /// The region of the address, such as the province, state, or district.
    /// </summary>
    [JsonPropertyName("province")]
    public string? province { get; set; } = null;

    /// <summary>
    /// The identity of the recipient e.g. 'Receiving Department'.
    /// </summary>
    [JsonPropertyName("recipient")]
    public string? recipient { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601))
    /// at which the company address was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;

    /// <summary>
    /// The zip or postal code of the address.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;

    /// <summary>
    /// The alphanumeric code for the region.
    /// For example, ON.
    /// </summary>
    [JsonPropertyName("zoneCode")]
    public string? zoneCode { get; set; } = null;
}