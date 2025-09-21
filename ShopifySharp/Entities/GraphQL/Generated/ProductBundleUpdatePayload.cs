#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `productBundleUpdate` mutation.
/// </summary>
public record ProductBundleUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous ProductBundleOperation updating the componentized product.
    /// </summary>
    [JsonPropertyName("productBundleOperation")]
    public ProductBundleOperation? productBundleOperation { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}