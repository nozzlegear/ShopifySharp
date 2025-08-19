#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The `DiscountCountryAll` object lets you target all countries as shipping destination for discount eligibility.
/// </summary>
public record DiscountCountryAll : DiscountShippingDestinationSelection, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Whether the discount can be applied to all countries as shipping destination. This value is always `true`.
    /// </summary>
    [JsonPropertyName("allCountries")]
    public bool? allCountries { get; set; } = null;
}