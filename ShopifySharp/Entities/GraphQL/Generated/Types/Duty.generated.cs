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
/// The duty details for a line item.
/// </summary>
public record Duty : IGraphQLObject, INode
{
    /// <summary>
    /// The ISO 3166-1 alpha-2 country code of the country of origin used in calculating the duty.
    /// </summary>
    [JsonPropertyName("countryCodeOfOrigin")]
    public CountryCode? countryCodeOfOrigin { get; set; } = null;

    /// <summary>
    /// The harmonized system code of the item used in calculating the duty.
    /// </summary>
    [JsonPropertyName("harmonizedSystemCode")]
    public string? harmonizedSystemCode { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The amount of the duty.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyBag? price { get; set; } = null;

    /// <summary>
    /// A list of taxes charged on the duty.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<TaxLine>? taxLines { get; set; } = null;
}