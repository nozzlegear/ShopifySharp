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
/// A Shopify product taxonomy measurement attribute.
/// </summary>
public record TaxonomyMeasurementAttribute : IGraphQLUnionCase, IGraphQLObject, INode
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
    /// The product taxonomy attribute options.
    /// </summary>
    [JsonPropertyName("options")]
    public ICollection<Attribute>? options { get; set; } = null;
}