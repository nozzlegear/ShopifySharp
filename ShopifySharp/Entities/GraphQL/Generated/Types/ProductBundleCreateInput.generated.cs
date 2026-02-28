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
    /// The consolidated options of the componentized product to create, if provided.
    /// </summary>
    [JsonPropertyName("consolidatedOptions")]
    public ICollection<ProductBundleConsolidatedOptionInput>? consolidatedOptions { get; set; } = null;

    /// <summary>
    /// The title of the product to create.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}