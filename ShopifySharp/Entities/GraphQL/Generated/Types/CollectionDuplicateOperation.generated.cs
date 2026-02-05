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
/// Represents an in-progress collection duplication operation. Collection
/// duplication is a synchronous operation for simple collections, and an
/// asynchronous operation for collections containing too many products to process synchronously.
/// </summary>
public record CollectionDuplicateOperation : IGraphQLObject
{
    /// <summary>
    /// Whether the collection is the source that products are being duplicated from,
    /// or the target collection that products are being duplicated onto.
    /// </summary>
    [JsonPropertyName("collectionRole")]
    public CollectionDuplicateOperationRole? collectionRole { get; set; } = null;

    /// <summary>
    /// The background job performing the duplication.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;
}