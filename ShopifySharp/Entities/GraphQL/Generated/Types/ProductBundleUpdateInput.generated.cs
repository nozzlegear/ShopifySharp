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
/// The input fields for updating a componentized product.
/// </summary>
public record ProductBundleUpdateInput : GraphQLInputObject<ProductBundleUpdateInput>
{
    /// <summary>
    /// The components to update existing ones. If none provided, no changes occur.
    /// Note: This replaces, not adds to, current components.
    /// </summary>
    [JsonPropertyName("components")]
    public ICollection<ProductBundleComponentInput>? components { get; set; } = null;

    /// <summary>
    /// The consolidated options of the componentized product to update, if provided.
    /// </summary>
    [JsonPropertyName("consolidatedOptions")]
    public ICollection<ProductBundleConsolidatedOptionInput>? consolidatedOptions { get; set; } = null;

    /// <summary>
    /// The ID of the componentized product to update.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? productId { get; set; } = null;

    /// <summary>
    /// The title to rename the componentized product to, if provided.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}