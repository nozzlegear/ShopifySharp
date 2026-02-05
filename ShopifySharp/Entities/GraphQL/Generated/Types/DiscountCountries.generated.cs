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
/// Defines the geographic scope where a shipping discount can be applied based on
/// customer shipping destinations. This configuration determines which countries
/// are eligible for the promotional offer.
/// For example, a "Free Shipping to EU" promotion would specify European Union
/// countries, while a domestic-only sale might target just the store's home country.
/// The object includes both specific country selections and an option to include
/// all remaining countries not explicitly listed, providing flexible geographic
/// targeting for international merchants.
/// </summary>
public record DiscountCountries : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The codes for the countries where the discount can be applied.
    /// </summary>
    [JsonPropertyName("countries")]
    public ICollection<CountryCode>? countries { get; set; } = null;

    /// <summary>
    /// Whether the discount is applicable to countries that haven't been defined in the shop's shipping zones.
    /// </summary>
    [JsonPropertyName("includeRestOfWorld")]
    public bool? includeRestOfWorld { get; set; } = null;
}