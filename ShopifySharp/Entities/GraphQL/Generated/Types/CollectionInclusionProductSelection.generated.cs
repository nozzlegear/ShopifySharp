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
/// Represents a product that has been manually selected for inclusion in a collection.
/// </summary>
public record CollectionInclusionProductSelection : IGraphQLObject
{
    /// <summary>
    /// The product that's manually included in the collection.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The IDs of variants of this product that have been manually included
    /// in the collection. Null when no variant-level manual selections exist
    /// for this product; non-empty when one or more variants have been
    /// manually included.
    /// </summary>
    [JsonPropertyName("variantIds")]
    public ICollection<string>? variantIds { get; set; } = null;
}