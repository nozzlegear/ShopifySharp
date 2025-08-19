#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for creating a market region with exactly one required option.
/// </summary>
public record MarketRegionCreateInput : GraphQLInputObject<MarketRegionCreateInput>
{
    /// <summary>
    /// A country code for the region.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;
}