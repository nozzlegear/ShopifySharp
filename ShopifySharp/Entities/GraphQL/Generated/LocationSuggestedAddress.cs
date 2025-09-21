#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a suggested address for a location.
/// </summary>
public record LocationSuggestedAddress : IGraphQLObject
{
    /// <summary>
    /// The first line of the suggested address.
    /// </summary>
    [JsonPropertyName("address1")]
    public string? address1 { get; set; } = null;

    /// <summary>
    /// The second line of the suggested address.
    /// </summary>
    [JsonPropertyName("address2")]
    public string? address2 { get; set; } = null;

    /// <summary>
    /// The city of the suggested address.
    /// </summary>
    [JsonPropertyName("city")]
    public string? city { get; set; } = null;

    /// <summary>
    /// The country of the suggested address.
    /// </summary>
    [JsonPropertyName("country")]
    public string? country { get; set; } = null;

    /// <summary>
    /// The country code of the suggested address.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// A formatted version of the suggested address.
    /// </summary>
    [JsonPropertyName("formatted")]
    public ICollection<string>? formatted { get; set; } = null;

    /// <summary>
    /// The province of the suggested address.
    /// </summary>
    [JsonPropertyName("province")]
    public string? province { get; set; } = null;

    /// <summary>
    /// The code for the province, state, or district of the suggested address.
    /// </summary>
    [JsonPropertyName("provinceCode")]
    public string? provinceCode { get; set; } = null;

    /// <summary>
    /// The ZIP code of the suggested address.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;
}