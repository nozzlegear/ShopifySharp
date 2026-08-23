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
/// The input fields required to identify a product for update.
/// </summary>
public record ProductUpdateIdentifiers : GraphQLInputObject<ProductUpdateIdentifiers>
{
    /// <summary>
    /// Custom ID of product to update.
    /// </summary>
    [JsonPropertyName("customId")]
    public UniqueMetafieldValueInput? customId { get; set; } = null;

    /// <summary>
    /// Handle of product to update.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// ID of product to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}