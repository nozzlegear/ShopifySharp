#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A product and the subset of associated variants that are part of this delivery profile.
/// </summary>
public record DeliveryProfileItem : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A product associated with this profile.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The product variants associated with this delivery profile.
    /// </summary>
    [JsonPropertyName("variants")]
    public ProductVariantConnection? variants { get; set; } = null;
}