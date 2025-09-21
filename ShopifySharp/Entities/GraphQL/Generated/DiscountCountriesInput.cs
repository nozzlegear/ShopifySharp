#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a list of countries to add or remove from the free shipping discount.
/// </summary>
public record DiscountCountriesInput : GraphQLInputObject<DiscountCountriesInput>
{
    /// <summary>
    /// The country codes to add to the list of countries where the discount applies.
    /// </summary>
    [JsonPropertyName("add")]
    public ICollection<CountryCode>? @add { get; set; } = null;

    /// <summary>
    /// Whether the discount code is applicable to countries that haven't been defined in the shop's shipping zones.
    /// </summary>
    [JsonPropertyName("includeRestOfWorld")]
    public bool? includeRestOfWorld { get; set; } = null;

    /// <summary>
    /// The country codes to remove from the list of countries where the discount applies.
    /// </summary>
    [JsonPropertyName("remove")]
    public ICollection<CountryCode>? @remove { get; set; } = null;
}