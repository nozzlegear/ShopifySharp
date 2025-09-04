#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a Shopify product taxonomy value.
/// </summary>
public record TaxonomyValue : IGraphQLUnionCase, IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the product taxonomy value. For example, Red.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}