#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A Shopify product taxonomy attribute.
/// </summary>
public record TaxonomyAttribute : TaxonomyCategoryAttribute, IGraphQLUnionCase, IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}