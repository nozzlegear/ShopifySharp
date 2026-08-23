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
/// The input fields for a condition that determines which products are excluded
/// from a collection. Exactly one condition type must be provided.
/// </summary>
public record CollectionSourceExclusionConditionInput : GraphQLInputObject<CollectionSourceExclusionConditionInput>
{
    /// <summary>
    /// A condition based on collections.
    /// </summary>
    [JsonPropertyName("collection")]
    public CollectionSourceExclusionConditionCollectionInput? collection { get; set; } = null;

    /// <summary>
    /// A condition based on product categories.
    /// </summary>
    [JsonPropertyName("productCategory")]
    public CollectionSourceExclusionConditionProductCategoryInput? productCategory { get; set; } = null;

    /// <summary>
    /// A condition based on product tags.
    /// </summary>
    [JsonPropertyName("productTag")]
    public CollectionSourceExclusionConditionProductTagInput? productTag { get; set; } = null;

    /// <summary>
    /// A condition based on product types.
    /// </summary>
    [JsonPropertyName("productType")]
    public CollectionSourceExclusionConditionProductTypeInput? productType { get; set; } = null;

    /// <summary>
    /// A condition based on product vendors.
    /// </summary>
    [JsonPropertyName("productVendor")]
    public CollectionSourceExclusionConditionProductVendorInput? productVendor { get; set; } = null;
}