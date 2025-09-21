#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `productDuplicate` mutation.
/// </summary>
public record ProductDuplicatePayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous job that duplicates the product images.
    /// </summary>
    [JsonPropertyName("imageJob")]
    public Job? imageJob { get; set; } = null;

    /// <summary>
    /// The duplicated product.
    /// </summary>
    [JsonPropertyName("newProduct")]
    public Product? newProduct { get; set; } = null;

    /// <summary>
    /// The product duplicate operation, returned when run in asynchronous mode.
    /// </summary>
    [JsonPropertyName("productDuplicateOperation")]
    public ProductDuplicateOperation? productDuplicateOperation { get; set; } = null;

    /// <summary>
    /// The user's shop.
    /// </summary>
    [JsonPropertyName("shop")]
    public Shop? shop { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}