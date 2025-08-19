#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Input for the quantity option related to a component product. This will become a
/// new option on the parent bundle product that doesn't have a corresponding option
/// on the component.
/// </summary>
public record ProductBundleComponentQuantityOptionInput : GraphQLInputObject<ProductBundleComponentQuantityOptionInput>
{
    /// <summary>
    /// The option name to create on the parent product.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Array of option values.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<ProductBundleComponentQuantityOptionValueInput>? values { get; set; } = null;
}