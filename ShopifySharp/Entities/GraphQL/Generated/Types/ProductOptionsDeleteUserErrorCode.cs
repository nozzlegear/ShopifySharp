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
/// Possible error codes that can be returned by `ProductOptionsDeleteUserError`.
/// </summary>
public enum ProductOptionsDeleteUserErrorCode
{
    PRODUCT_DOES_NOT_EXIST,
    PRODUCT_SUSPENDED,
    OPTION_DOES_NOT_EXIST,
    OPTIONS_DO_NOT_BELONG_TO_THE_SAME_PRODUCT,
    CANNOT_DELETE_OPTION_WITH_MULTIPLE_VALUES,
    CANNOT_USE_NON_DESTRUCTIVE_STRATEGY,
    CANNOT_MAKE_CHANGES_IF_VARIANT_IS_MISSING_REQUIRED_SKU,
    UNSUPPORTED_COMBINED_LISTING_PARENT_OPERATION,
    CANNOT_DELETE_VARIANT_WITHOUT_PERMISSION,
}