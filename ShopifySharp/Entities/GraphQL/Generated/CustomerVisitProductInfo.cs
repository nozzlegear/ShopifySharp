#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// This type returns the information about the product and product variant from a customer visit.
/// </summary>
public record CustomerVisitProductInfo : IGraphQLObject
{
    /// <summary>
    /// The product information. If `null`, then the product was deleted from the store.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The quantity of the product that the customer requested.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The product variant information, if the product variant exists.
    /// </summary>
    [JsonPropertyName("variant")]
    public ProductVariant? variant { get; set; } = null;
}