#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A Shopify product taxonomy choice list attribute.
/// </summary>
public record TaxonomyChoiceListAttribute : IGraphQLUnionCase, IGraphQLObject, INode
{
    /// <summary>
    /// The unique ID of the TaxonomyAttribute.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the product taxonomy attribute. For example, Color.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A list of values on the choice list attribute.
    /// </summary>
    [JsonPropertyName("values")]
    public TaxonomyValueConnection? values { get; set; } = null;
}