#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for creating a componentized product.
/// </summary>
public record ProductBundleCreateInput : GraphQLInputObject<ProductBundleCreateInput>
{
    /// <summary>
    /// The component products to bundle with the bundle product.
    /// </summary>
    [JsonPropertyName("components")]
    public ICollection<ProductBundleComponentInput>? components { get; set; } = null;

    /// <summary>
    /// The title of the product to create.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}