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
/// A product variant component that is included within a bundle.
/// These are the individual product variants that make up a bundle product,
/// where each component has a specific required quantity.
/// </summary>
public record ProductVariantComponent : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The product variant associated with the component.
    /// </summary>
    [JsonPropertyName("productVariant")]
    public ProductVariant? productVariant { get; set; } = null;

    /// <summary>
    /// The required quantity of the component.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}