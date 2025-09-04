#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The shipping destinations where the discount can be applied.
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