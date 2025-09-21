#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `productFeedDelete` mutation.
/// </summary>
public record ProductFeedDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the product feed that was deleted.
    /// </summary>
    [JsonPropertyName("deletedId")]
    public string? deletedId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ProductFeedDeleteUserError>? userErrors { get; set; } = null;
}