#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to create a price list.
/// </summary>
public record PriceListCreateInput : GraphQLInputObject<PriceListCreateInput>
{
    /// <summary>
    /// The ID of the catalog to associate with this price list.If the catalog was
    /// already associated with another price list then it will be unlinked.
    /// </summary>
    [JsonPropertyName("catalogId")]
    public string? catalogId { get; set; } = null;

    /// <summary>
    /// Three letter currency code for fixed prices associated with this price list.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? currency { get; set; } = null;

    /// <summary>
    /// The unique name of the price list, used as a human-readable identifier.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Relative adjustments to other prices.
    /// </summary>
    [JsonPropertyName("parent")]
    public PriceListParentCreateInput? parent { get; set; } = null;
}