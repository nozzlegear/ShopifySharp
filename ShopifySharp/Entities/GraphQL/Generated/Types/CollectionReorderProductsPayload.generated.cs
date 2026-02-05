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
/// Return type for `collectionReorderProducts` mutation.
/// </summary>
public record CollectionReorderProductsPayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous job reordering the products.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CollectionReorderProductsUserError>? userErrors { get; set; } = null;
}