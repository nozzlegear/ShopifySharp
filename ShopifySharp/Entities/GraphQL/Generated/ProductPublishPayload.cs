#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `productPublish` mutation.
/// </summary>
public record ProductPublishPayload : IGraphQLObject
{
    /// <summary>
    /// The product that has been published.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The channels where the product is published.
    /// </summary>
    [JsonPropertyName("productPublications")]
    [Obsolete("Use Product.publications instead.")]
    public ICollection<ProductPublication>? productPublications { get; set; } = null;

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