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
/// Return type for `productVariantDetachMedia` mutation.
/// </summary>
public record ProductVariantDetachMediaPayload : IGraphQLObject
{
    /// <summary>
    /// The product associated with the variants and media.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The product variants that were updated.
    /// </summary>
    [JsonPropertyName("productVariants")]
    public ICollection<ProductVariant>? productVariants { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MediaUserError>? userErrors { get; set; } = null;
}