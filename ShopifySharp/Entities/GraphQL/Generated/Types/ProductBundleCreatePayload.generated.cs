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
/// Return type for `productBundleCreate` mutation.
/// </summary>
public record ProductBundleCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous ProductBundleOperation creating the product bundle or componentized product.
    /// </summary>
    [JsonPropertyName("productBundleOperation")]
    public ProductBundleOperation? productBundleOperation { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}