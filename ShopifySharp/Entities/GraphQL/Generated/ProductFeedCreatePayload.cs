#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `productFeedCreate` mutation.
/// </summary>
public record ProductFeedCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The newly created product feed.
    /// </summary>
    [JsonPropertyName("productFeed")]
    public ProductFeed? productFeed { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ProductFeedCreateUserError>? userErrors { get; set; } = null;
}