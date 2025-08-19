#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `productFullSync` mutation.
/// </summary>
public record ProductFullSyncPayload : IGraphQLObject
{
    /// <summary>
    /// The ID for the full sync operation.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ProductFullSyncUserError>? userErrors { get; set; } = null;
}