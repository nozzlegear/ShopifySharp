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
/// The input fields to use to specify the address while adding a location.
/// </summary>
public record LocationAddAddressInput : GraphQLInputObject<LocationAddAddressInput>
{
    /// <summary>
    /// The first line of the address.
    /// </summary>
    [JsonPropertyName("address1")]
    public string? address1 { get; set; } = null;

    /// <summary>
    /// The second line of the address.
    /// </summary>
    [JsonPropertyName("address2")]
    public string? address2 { get; set; } = null;

    /// <summary>
    /// The name of the city, district, village, or town.
    /// </summary>
    [JsonPropertyName("city")]
    public string? city { get; set; } = null;

    /// <summary>
    /// The two-letter code of country for the address.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// The phone number of the location.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The code for the region of the address, such as the state, province, or district.
    /// For example CA for California, United States.
    /// </summary>
    [JsonPropertyName("provinceCode")]
    public string? provinceCode { get; set; } = null;

    /// <summary>
    /// The ZIP code or postal code of the address.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;
}