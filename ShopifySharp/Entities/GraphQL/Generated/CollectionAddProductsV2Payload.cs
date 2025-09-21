#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `collectionAddProductsV2` mutation.
/// </summary>
public record CollectionAddProductsV2Payload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous job adding the products.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CollectionAddProductsV2UserError>? userErrors { get; set; } = null;
}