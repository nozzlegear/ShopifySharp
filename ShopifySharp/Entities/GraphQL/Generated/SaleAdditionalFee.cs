#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The additional fee details for a line item.
/// </summary>
public record SaleAdditionalFee : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the additional fee.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The price of the additional fee.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyBag? price { get; set; } = null;

    /// <summary>
    /// A list of taxes charged on the additional fee.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<TaxLine>? taxLines { get; set; } = null;
}