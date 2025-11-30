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
/// The input fields for specifying the product to delete.
/// </summary>
public record ProductDeleteInput : GraphQLInputObject<ProductDeleteInput>
{
    /// <summary>
    /// The ID of the product.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}