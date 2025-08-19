#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `productDelete` mutation.
/// </summary>
public record ProductDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted product.
    /// </summary>
    [JsonPropertyName("deletedProductId")]
    public string? deletedProductId { get; set; } = null;

    /// <summary>
    /// The product delete operation, returned when run in asynchronous mode.
    /// </summary>
    [JsonPropertyName("productDeleteOperation")]
    public ProductDeleteOperation? productDeleteOperation { get; set; } = null;

    /// <summary>
    /// The shop associated with the product.
    /// </summary>
    [JsonPropertyName("shop")]
    public Shop? shop { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}