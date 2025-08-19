#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the address of a location.
/// </summary>
public record LocationAddress : IGraphQLObject
{
    /// <summary>
    /// The first line of the address for the location.
    /// </summary>
    [JsonPropertyName("address1")]
    public string? address1 { get; set; } = null;

    /// <summary>
    /// The second line of the address for the location.
    /// </summary>
    [JsonPropertyName("address2")]
    public string? address2 { get; set; } = null;

    /// <summary>
    /// The city of the location.
    /// </summary>
    [JsonPropertyName("city")]
    public string? city { get; set; } = null;

    /// <summary>
    /// The country of the location.
    /// </summary>
    [JsonPropertyName("country")]
    public string? country { get; set; } = null;

    /// <summary>
    /// The country code of the location.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public string? countryCode { get; set; } = null;

    /// <summary>
    /// A formatted version of the address for the location.
    /// </summary>
    [JsonPropertyName("formatted")]
    public ICollection<string>? formatted { get; set; } = null;

    /// <summary>
    /// The approximate latitude coordinates of the location.
    /// </summary>
    [JsonPropertyName("latitude")]
    public decimal? latitude { get; set; } = null;

    /// <summary>
    /// The approximate longitude coordinates of the location.
    /// </summary>
    [JsonPropertyName("longitude")]
    public decimal? longitude { get; set; } = null;

    /// <summary>
    /// The phone number of the location.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The province of the location.
    /// </summary>
    [JsonPropertyName("province")]
    public string? province { get; set; } = null;

    /// <summary>
    /// The code for the province, state, or district of the address of the location.
    /// </summary>
    [JsonPropertyName("provinceCode")]
    public string? provinceCode { get; set; } = null;

    /// <summary>
    /// The ZIP code of the location.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;
}