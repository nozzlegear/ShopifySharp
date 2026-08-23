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
/// The input fields for updating a condition that determines which products are
/// excluded from a collection. Exactly one condition type must be provided.
/// </summary>
public record CollectionSourceExclusionConditionUpdateInput : GraphQLInputObject<CollectionSourceExclusionConditionUpdateInput>
{
    /// <summary>
    /// An update to an exclusion condition based on collections.
    /// </summary>
    [JsonPropertyName("collection")]
    public CollectionSourceExclusionConditionUpdateCollectionInput? collection { get; set; } = null;

    /// <summary>
    /// An update to an exclusion condition based on product categories.
    /// </summary>
    [JsonPropertyName("productCategory")]
    public CollectionSourceExclusionConditionUpdateProductCategoryInput? productCategory { get; set; } = null;

    /// <summary>
    /// An update to an exclusion condition based on product tags.
    /// </summary>
    [JsonPropertyName("productTag")]
    public CollectionSourceExclusionConditionUpdateProductTagInput? productTag { get; set; } = null;

    /// <summary>
    /// An update to an exclusion condition based on product types.
    /// </summary>
    [JsonPropertyName("productType")]
    public CollectionSourceExclusionConditionUpdateProductTypeInput? productType { get; set; } = null;

    /// <summary>
    /// An update to an exclusion condition based on product vendors.
    /// </summary>
    [JsonPropertyName("productVendor")]
    public CollectionSourceExclusionConditionUpdateProductVendorInput? productVendor { get; set; } = null;
}