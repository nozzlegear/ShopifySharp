#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A change to the order representing the addition of an existing product variant.
/// </summary>
public record OrderStagedChangeAddVariant : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The quantity of the product variant that was added.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The product variant that was added.
    /// </summary>
    [JsonPropertyName("variant")]
    public ProductVariant? variant { get; set; } = null;
}