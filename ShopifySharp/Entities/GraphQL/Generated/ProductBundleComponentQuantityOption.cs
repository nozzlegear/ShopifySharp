#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A quantity option related to a bundle.
/// </summary>
public record ProductBundleComponentQuantityOption : IGraphQLObject
{
    /// <summary>
    /// The name of the option value.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The option that was created on the parent product.
    /// </summary>
    [JsonPropertyName("parentOption")]
    public ProductOption? parentOption { get; set; } = null;

    /// <summary>
    /// The quantity values of the option.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<ProductBundleComponentQuantityOptionValue>? values { get; set; } = null;
}