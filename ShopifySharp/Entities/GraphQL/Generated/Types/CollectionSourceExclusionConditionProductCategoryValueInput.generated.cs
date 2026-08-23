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
/// The input fields for a product category value in an exclusion condition.
/// </summary>
public record CollectionSourceExclusionConditionProductCategoryValueInput : GraphQLInputObject<CollectionSourceExclusionConditionProductCategoryValueInput>
{
    /// <summary>
    /// The ID of the product category.
    /// </summary>
    [JsonPropertyName("categoryId")]
    public string? categoryId { get; set; } = null;

    /// <summary>
    /// Whether to include descendants of the product category.
    /// </summary>
    [JsonPropertyName("includeDescendants")]
    public bool? includeDescendants { get; set; } = null;
}