#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `ProductVariantsBulkReorderUserError`.
/// </summary>
public enum ProductVariantsBulkReorderUserErrorCode
{
    PRODUCT_DOES_NOT_EXIST,
    MISSING_VARIANT,
    INVALID_POSITION,
    DUPLICATED_VARIANT_ID,
    GENERIC_ERROR,
}