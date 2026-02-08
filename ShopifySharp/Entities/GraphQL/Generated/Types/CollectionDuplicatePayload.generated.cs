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
/// Return type for `collectionDuplicate` mutation.
/// </summary>
public record CollectionDuplicatePayload : IGraphQLObject
{
    /// <summary>
    /// The newly created duplicate collection. Will contain all data if duplication completed synchronously.
    /// If async processing is required, the collection will be created but products will be added in the background
    /// and can be tracked via the job field or the collection's active_operations field.
    /// </summary>
    [JsonPropertyName("collection")]
    public Collection? collection { get; set; } = null;

    /// <summary>
    /// The background job copying manually included products onto the target
    /// collection. Only returned if async processing is required, otherwise products
    /// will be copied synchronously when the collection is created.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CollectionDuplicateUserError>? userErrors { get; set; } = null;
}