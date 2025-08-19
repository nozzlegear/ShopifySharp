#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `priceListFixedPricesDelete` mutation.
/// </summary>
public record PriceListFixedPricesDeletePayload : IGraphQLObject
{
    /// <summary>
    /// A list of product variant IDs whose fixed prices were removed from the price list.
    /// </summary>
    [JsonPropertyName("deletedFixedPriceVariantIds")]
    public ICollection<string>? deletedFixedPriceVariantIds { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PriceListPriceUserError>? userErrors { get; set; } = null;
}