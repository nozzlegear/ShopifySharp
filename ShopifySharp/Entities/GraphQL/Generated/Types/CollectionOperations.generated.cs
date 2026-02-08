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
/// Represents operations involving a collection.
/// </summary>
public record CollectionOperations : IGraphQLObject
{
    /// <summary>
    /// Collection duplicate operations.
    /// </summary>
    [JsonPropertyName("duplicate")]
    public ICollection<CollectionDuplicateOperation>? duplicate { get; set; } = null;
}