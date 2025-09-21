#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a single quantity option value related to a component product.
/// </summary>
public record ProductBundleComponentQuantityOptionValueInput : GraphQLInputObject<ProductBundleComponentQuantityOptionValueInput>
{
    /// <summary>
    /// The name associated with the option, e.g. one-pack, two-pack.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// How many of the variant will be included for the option value (e.g. two-pack has quantity 2).
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}