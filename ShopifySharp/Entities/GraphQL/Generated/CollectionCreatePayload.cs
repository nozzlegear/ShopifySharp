#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `collectionCreate` mutation.
/// </summary>
public record CollectionCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The collection that has been created.
    /// </summary>
    [JsonPropertyName("collection")]
    public Collection? collection { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}