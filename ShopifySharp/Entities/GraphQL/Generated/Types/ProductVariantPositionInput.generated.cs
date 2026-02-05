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
/// The input fields representing a product variant position.
/// </summary>
public record ProductVariantPositionInput : GraphQLInputObject<ProductVariantPositionInput>
{
    /// <summary>
    /// Specifies the ID of the product variant to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The order of the product variant in the list of product variants. The first position in the list is 1.
    /// </summary>
    [JsonPropertyName("position")]
    public int? position { get; set; } = null;
}