#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `combinedListingUpdate` mutation.
/// </summary>
public record CombinedListingUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The parent product.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CombinedListingUpdateUserError>? userErrors { get; set; } = null;
}