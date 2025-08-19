#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `priceListUpdate` mutation.
/// </summary>
public record PriceListUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated price list.
    /// </summary>
    [JsonPropertyName("priceList")]
    public PriceList? priceList { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PriceListUserError>? userErrors { get; set; } = null;
}