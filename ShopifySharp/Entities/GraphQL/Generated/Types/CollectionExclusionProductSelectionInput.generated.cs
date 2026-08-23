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
/// The input fields for selecting specific products to exclude from a collection.
/// </summary>
public record CollectionExclusionProductSelectionInput : GraphQLInputObject<CollectionExclusionProductSelectionInput>
{
    /// <summary>
    /// The ID of the product to exclude from the collection.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? productId { get; set; } = null;
}