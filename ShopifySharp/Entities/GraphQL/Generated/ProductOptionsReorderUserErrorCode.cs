#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `ProductOptionsReorderUserError`.
/// </summary>
public enum ProductOptionsReorderUserErrorCode
{
    OPTION_NAME_DOES_NOT_EXIST,
    OPTION_VALUE_DOES_NOT_EXIST,
    OPTION_ID_DOES_NOT_EXIST,
    OPTION_VALUE_ID_DOES_NOT_EXIST,
    DUPLICATED_OPTION_NAME,
    DUPLICATED_OPTION_VALUE,
    MISSING_OPTION_NAME,
    MISSING_OPTION_VALUE,
    PRODUCT_DOES_NOT_EXIST,
    PRODUCT_SUSPENDED,
    NO_KEY_ON_REORDER,
    MIXING_ID_AND_NAME_KEYS_IS_NOT_ALLOWED,
    CANNOT_MAKE_CHANGES_IF_VARIANT_IS_MISSING_REQUIRED_SKU,
}