#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Specifies the attribute of a product being used to populate the smart collection.
/// </summary>
public enum CollectionRuleColumn
{
    TAG,
    TITLE,
    TYPE,
    PRODUCT_TAXONOMY_NODE_ID,
    PRODUCT_CATEGORY_ID,
    PRODUCT_CATEGORY_ID_WITH_DESCENDANTS,
    VENDOR,
    VARIANT_PRICE,
    IS_PRICE_REDUCED,
    VARIANT_COMPARE_AT_PRICE,
    VARIANT_WEIGHT,
    VARIANT_INVENTORY,
    VARIANT_TITLE,
    PRODUCT_METAFIELD_DEFINITION,
    VARIANT_METAFIELD_DEFINITION,
}