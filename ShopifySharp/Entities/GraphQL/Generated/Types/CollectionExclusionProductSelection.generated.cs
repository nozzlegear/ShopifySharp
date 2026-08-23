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
/// Represents a product that has been manually selected for exclusion from a collection.
/// </summary>
public record CollectionExclusionProductSelection : IGraphQLObject
{
    /// <summary>
    /// The product that's manually excluded from the collection.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;
}