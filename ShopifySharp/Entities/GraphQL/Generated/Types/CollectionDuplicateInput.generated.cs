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
/// The input fields for duplicating a collection.
/// </summary>
public record CollectionDuplicateInput : GraphQLInputObject<CollectionDuplicateInput>
{
    /// <summary>
    /// The ID of the collection to be duplicated.
    /// </summary>
    [JsonPropertyName("collectionId")]
    public string? collectionId { get; set; } = null;

    /// <summary>
    /// Whether to duplicate the collection's publications (channel availability).
    /// When `true` (default), the duplicated collection will be published to the same
    /// channels as the original. When `false`, the duplicated collection will be
    /// unpublished on all channels.
    /// </summary>
    [JsonPropertyName("copyPublications")]
    public bool? copyPublications { get; set; } = null;

    /// <summary>
    /// The new title of the collection.
    /// </summary>
    [JsonPropertyName("newTitle")]
    public string? newTitle { get; set; } = null;
}