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
/// The shipping lines to which the price rule applies to.
/// </summary>
public record PriceRuleShippingLineEntitlements : IGraphQLObject
{
    /// <summary>
    /// The codes for the countries to which the price rule applies to.
    /// </summary>
    [JsonPropertyName("countryCodes")]
    public ICollection<CountryCode>? countryCodes { get; set; } = null;

    /// <summary>
    /// Whether the price rule is applicable to countries that haven't been defined in the shop's shipping zones.
    /// </summary>
    [JsonPropertyName("includeRestOfWorld")]
    public bool? includeRestOfWorld { get; set; } = null;

    /// <summary>
    /// Whether the price rule applies to all shipping lines.
    /// </summary>
    [JsonPropertyName("targetAllShippingLines")]
    public bool? targetAllShippingLines { get; set; } = null;
}