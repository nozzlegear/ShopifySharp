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
/// A value for a product category exclusion condition.
/// </summary>
public record CollectionSourceExclusionConditionProductCategoryValue : IGraphQLObject
{
    /// <summary>
    /// The product category to match against.
    /// </summary>
    [JsonPropertyName("category")]
    public TaxonomyCategory? category { get; set; } = null;

    /// <summary>
    /// Whether to include descendants of the product category.
    /// </summary>
    [JsonPropertyName("includeDescendants")]
    public bool? includeDescendants { get; set; } = null;
}