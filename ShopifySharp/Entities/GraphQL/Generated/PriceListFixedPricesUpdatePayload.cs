#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `priceListFixedPricesUpdate` mutation.
/// </summary>
public record PriceListFixedPricesUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// A list of deleted variant IDs for prices.
    /// </summary>
    [JsonPropertyName("deletedFixedPriceVariantIds")]
    public ICollection<string>? deletedFixedPriceVariantIds { get; set; } = null;

    /// <summary>
    /// The price list for which the fixed prices were modified.
    /// </summary>
    [JsonPropertyName("priceList")]
    public PriceList? priceList { get; set; } = null;

    /// <summary>
    /// The prices that were added to the price list.
    /// </summary>
    [JsonPropertyName("pricesAdded")]
    public ICollection<PriceListPrice>? pricesAdded { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PriceListPriceUserError>? userErrors { get; set; } = null;
}