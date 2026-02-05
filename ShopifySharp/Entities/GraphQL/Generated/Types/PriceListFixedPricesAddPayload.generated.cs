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
/// Return type for `priceListFixedPricesAdd` mutation.
/// </summary>
public record PriceListFixedPricesAddPayload : IGraphQLObject
{
    /// <summary>
    /// The list of fixed prices that were added to or updated in the price list.
    /// </summary>
    [JsonPropertyName("prices")]
    public ICollection<PriceListPrice>? prices { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PriceListPriceUserError>? userErrors { get; set; } = null;
}