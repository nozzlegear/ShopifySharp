#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `priceListCreate` mutation.
/// </summary>
public record PriceListCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The newly created price list.
    /// </summary>
    [JsonPropertyName("priceList")]
    public PriceList? priceList { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PriceListUserError>? userErrors { get; set; } = null;
}