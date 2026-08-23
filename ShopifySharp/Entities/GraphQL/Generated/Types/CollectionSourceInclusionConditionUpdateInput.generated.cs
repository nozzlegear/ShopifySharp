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
/// included in a collection. Exactly one condition type must be provided.
/// </summary>
public record CollectionSourceInclusionConditionUpdateInput : GraphQLInputObject<CollectionSourceInclusionConditionUpdateInput>
{
    /// <summary>
    /// An update to a condition based on boolean metafield values.
    /// </summary>
    [JsonPropertyName("metafieldBoolean")]
    public CollectionSourceInclusionConditionUpdateMetafieldBooleanInput? metafieldBoolean { get; set; } = null;

    /// <summary>
    /// An update to a condition based on decimal metafield values.
    /// </summary>
    [JsonPropertyName("metafieldDecimal")]
    public CollectionSourceInclusionConditionUpdateMetafieldDecimalInput? metafieldDecimal { get; set; } = null;

    /// <summary>
    /// An update to a condition based on integer metafield values.
    /// </summary>
    [JsonPropertyName("metafieldInteger")]
    public CollectionSourceInclusionConditionUpdateMetafieldIntegerInput? metafieldInteger { get; set; } = null;

    /// <summary>
    /// An update to a condition based on single metaobject reference metafield values.
    /// </summary>
    [JsonPropertyName("metafieldMetaobject")]
    public CollectionSourceInclusionConditionUpdateMetafieldMetaobjectInput? metafieldMetaobject { get; set; } = null;

    /// <summary>
    /// An update to a condition based on metaobject list reference metafield values.
    /// </summary>
    [JsonPropertyName("metafieldMetaobjectList")]
    public CollectionSourceInclusionConditionUpdateMetafieldMetaobjectListInput? metafieldMetaobjectList { get; set; } = null;

    /// <summary>
    /// An update to a condition based on string metafield values.
    /// </summary>
    [JsonPropertyName("metafieldString")]
    public CollectionSourceInclusionConditionUpdateMetafieldStringInput? metafieldString { get; set; } = null;

    /// <summary>
    /// An update to a condition based on string list metafield values.
    /// </summary>
    [JsonPropertyName("metafieldStringList")]
    public CollectionSourceInclusionConditionUpdateMetafieldStringListInput? metafieldStringList { get; set; } = null;

    /// <summary>
    /// An update to a condition based on product categories.
    /// </summary>
    [JsonPropertyName("productCategory")]
    public CollectionSourceInclusionConditionUpdateProductCategoryInput? productCategory { get; set; } = null;

    /// <summary>
    /// An update to a condition based on product status.
    /// </summary>
    [JsonPropertyName("productStatus")]
    public CollectionSourceInclusionConditionUpdateProductStatusInput? productStatus { get; set; } = null;

    /// <summary>
    /// An update to a condition based on product tags.
    /// </summary>
    [JsonPropertyName("productTag")]
    public CollectionSourceInclusionConditionUpdateProductTagInput? productTag { get; set; } = null;

    /// <summary>
    /// An update to a condition based on product titles.
    /// </summary>
    [JsonPropertyName("productTitle")]
    public CollectionSourceInclusionConditionUpdateProductTitleInput? productTitle { get; set; } = null;

    /// <summary>
    /// An update to a condition based on product types.
    /// </summary>
    [JsonPropertyName("productType")]
    public CollectionSourceInclusionConditionUpdateProductTypeInput? productType { get; set; } = null;

    /// <summary>
    /// An update to a condition based on product vendors.
    /// </summary>
    [JsonPropertyName("productVendor")]
    public CollectionSourceInclusionConditionUpdateProductVendorInput? productVendor { get; set; } = null;

    /// <summary>
    /// An update to a condition based on variant compare at prices.
    /// </summary>
    [JsonPropertyName("variantCompareAtPrice")]
    public CollectionSourceInclusionConditionUpdateVariantCompareAtPriceInput? variantCompareAtPrice { get; set; } = null;

    /// <summary>
    /// An update to a condition based on variant inventory quantities.
    /// </summary>
    [JsonPropertyName("variantInventory")]
    public CollectionSourceInclusionConditionUpdateVariantInventoryInput? variantInventory { get; set; } = null;

    /// <summary>
    /// An update to a condition based on variant prices.
    /// </summary>
    [JsonPropertyName("variantPrice")]
    public CollectionSourceInclusionConditionUpdateVariantPriceInput? variantPrice { get; set; } = null;

    /// <summary>
    /// An update to a condition based on variant titles.
    /// </summary>
    [JsonPropertyName("variantTitle")]
    public CollectionSourceInclusionConditionUpdateVariantTitleInput? variantTitle { get; set; } = null;

    /// <summary>
    /// An update to a condition based on variant weights.
    /// </summary>
    [JsonPropertyName("variantWeight")]
    public CollectionSourceInclusionConditionUpdateVariantWeightInput? variantWeight { get; set; } = null;
}