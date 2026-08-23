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
/// A condition that determines which products are included in a collection.
/// Available condition types, grouped by what they filter on:
/// - **Product attributes**: `productTag`, `productTitle`, `productType`, `productVendor`, `productStatus`,
/// `productCategory`.
/// - **Variant attributes**: `variantTitle`, `variantPrice`, `variantCompareAtPrice`, `variantInventory`,
/// `variantWeight`.
/// - **Pricing**: `isPriceReduced`.
/// - **Metafields**: `metafieldBoolean`, `metafieldDecimal`, `metafieldString`, `metafieldStringList`,
/// `metafieldMetaobject`, `metafieldMetaobjectList`, and either `metafieldInteger` or `metafieldInt` for
/// integer metafields. Use `metafieldInteger` before API version 2026-10 and `metafieldInt` from 2026-10
/// onward. `metafieldInteger` is deprecated as of 2026-10 and removed as of 2027-01.
/// Each condition type specifies its own `relation` (for example, `EQUALS`, `CONTAINS`, `TAGGED_WITH`) and
/// value shape. Combine multiple conditions in a single source's `inclusion.conditions` list and use the
/// source's `matchType` to require that products match `ANY` or `ALL` of them.
/// </summary>
public record CollectionSourceInclusionConditionInput : GraphQLInputObject<CollectionSourceInclusionConditionInput>
{
    /// <summary>
    /// A condition based on boolean metafield values.
    /// </summary>
    [JsonPropertyName("metafieldBoolean")]
    public CollectionSourceInclusionConditionMetafieldBooleanInput? metafieldBoolean { get; set; } = null;

    /// <summary>
    /// A condition based on decimal metafield values.
    /// </summary>
    [JsonPropertyName("metafieldDecimal")]
    public CollectionSourceInclusionConditionMetafieldDecimalInput? metafieldDecimal { get; set; } = null;

    /// <summary>
    /// A condition based on integer metafield values.
    /// </summary>
    [JsonPropertyName("metafieldInteger")]
    public CollectionSourceInclusionConditionMetafieldIntegerInput? metafieldInteger { get; set; } = null;

    /// <summary>
    /// A condition based on single metaobject reference metafield values.
    /// </summary>
    [JsonPropertyName("metafieldMetaobject")]
    public CollectionSourceInclusionConditionMetafieldMetaobjectInput? metafieldMetaobject { get; set; } = null;

    /// <summary>
    /// A condition based on metaobject list reference metafield values.
    /// </summary>
    [JsonPropertyName("metafieldMetaobjectList")]
    public CollectionSourceInclusionConditionMetafieldMetaobjectListInput? metafieldMetaobjectList { get; set; } = null;

    /// <summary>
    /// A condition based on string metafield values.
    /// </summary>
    [JsonPropertyName("metafieldString")]
    public CollectionSourceInclusionConditionMetafieldStringInput? metafieldString { get; set; } = null;

    /// <summary>
    /// A condition based on string list metafield values.
    /// </summary>
    [JsonPropertyName("metafieldStringList")]
    public CollectionSourceInclusionConditionMetafieldStringListInput? metafieldStringList { get; set; } = null;

    /// <summary>
    /// A condition based on product categories.
    /// </summary>
    [JsonPropertyName("productCategory")]
    public CollectionSourceInclusionConditionProductCategoryInput? productCategory { get; set; } = null;

    /// <summary>
    /// A condition based on product status.
    /// </summary>
    [JsonPropertyName("productStatus")]
    public CollectionSourceInclusionConditionProductStatusInput? productStatus { get; set; } = null;

    /// <summary>
    /// A condition based on product tags.
    /// </summary>
    [JsonPropertyName("productTag")]
    public CollectionSourceInclusionConditionProductTagInput? productTag { get; set; } = null;

    /// <summary>
    /// A condition based on product titles.
    /// </summary>
    [JsonPropertyName("productTitle")]
    public CollectionSourceInclusionConditionProductTitleInput? productTitle { get; set; } = null;

    /// <summary>
    /// A condition based on product types.
    /// </summary>
    [JsonPropertyName("productType")]
    public CollectionSourceInclusionConditionProductTypeInput? productType { get; set; } = null;

    /// <summary>
    /// A condition based on product vendors.
    /// </summary>
    [JsonPropertyName("productVendor")]
    public CollectionSourceInclusionConditionProductVendorInput? productVendor { get; set; } = null;

    /// <summary>
    /// A condition based on variant compare at prices.
    /// </summary>
    [JsonPropertyName("variantCompareAtPrice")]
    public CollectionSourceInclusionConditionVariantCompareAtPriceInput? variantCompareAtPrice { get; set; } = null;

    /// <summary>
    /// A condition based on variant inventory quantities.
    /// </summary>
    [JsonPropertyName("variantInventory")]
    public CollectionSourceInclusionConditionVariantInventoryInput? variantInventory { get; set; } = null;

    /// <summary>
    /// A condition based on variant prices.
    /// </summary>
    [JsonPropertyName("variantPrice")]
    public CollectionSourceInclusionConditionVariantPriceInput? variantPrice { get; set; } = null;

    /// <summary>
    /// A condition based on variant titles.
    /// </summary>
    [JsonPropertyName("variantTitle")]
    public CollectionSourceInclusionConditionVariantTitleInput? variantTitle { get; set; } = null;

    /// <summary>
    /// A condition based on variant weights.
    /// </summary>
    [JsonPropertyName("variantWeight")]
    public CollectionSourceInclusionConditionVariantWeightInput? variantWeight { get; set; } = null;
}