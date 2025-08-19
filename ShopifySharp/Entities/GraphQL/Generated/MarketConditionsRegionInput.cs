#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to specify a region condition.
/// </summary>
public record MarketConditionsRegionInput : GraphQLInputObject<MarketConditionsRegionInput>
{
    /// <summary>
    /// A country code to which this condition should apply.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;
}