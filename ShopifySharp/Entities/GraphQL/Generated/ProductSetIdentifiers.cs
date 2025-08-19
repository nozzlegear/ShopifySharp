#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to identify a resource.
/// </summary>
public record ProductSetIdentifiers : GraphQLInputObject<ProductSetIdentifiers>
{
    /// <summary>
    /// Custom ID of product to upsert.
    /// </summary>
    [JsonPropertyName("customId")]
    public UniqueMetafieldValueInput? customId { get; set; } = null;

    /// <summary>
    /// Handle of product to upsert.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// ID of product to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}