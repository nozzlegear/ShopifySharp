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
/// The input fields for selecting specific products to include in a collection.
/// </summary>
public record CollectionInclusionProductSelectionInput : GraphQLInputObject<CollectionInclusionProductSelectionInput>
{
    /// <summary>
    /// The ID of the product to include in the collection.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? productId { get; set; } = null;

    /// <summary>
    /// The IDs of the product variants to include in the collection.
    /// </summary>
    [JsonPropertyName("variantIds")]
    public ICollection<string>? variantIds { get; set; } = null;
}