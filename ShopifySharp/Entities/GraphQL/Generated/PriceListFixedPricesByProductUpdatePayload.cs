#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `priceListFixedPricesByProductUpdate` mutation.
/// </summary>
public record PriceListFixedPricesByProductUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The price list for which the fixed prices were modified.
    /// </summary>
    [JsonPropertyName("priceList")]
    public PriceList? priceList { get; set; } = null;

    /// <summary>
    /// The product for which the fixed prices were added.
    /// </summary>
    [JsonPropertyName("pricesToAddProducts")]
    public ICollection<Product>? pricesToAddProducts { get; set; } = null;

    /// <summary>
    /// The product for which the fixed prices were deleted.
    /// </summary>
    [JsonPropertyName("pricesToDeleteProducts")]
    public ICollection<Product>? pricesToDeleteProducts { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PriceListFixedPricesByProductBulkUpdateUserError>? userErrors { get; set; } = null;
}