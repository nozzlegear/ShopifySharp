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
/// Possible error codes that can be returned by `ProductVariantsBulkDeleteUserError`.
/// </summary>
public enum ProductVariantsBulkDeleteUserErrorCode
{
    PRODUCT_DOES_NOT_EXIST,
    PRODUCT_SUSPENDED,
    CANNOT_DELETE_LAST_VARIANT,
    AT_LEAST_ONE_VARIANT_DOES_NOT_BELONG_TO_THE_PRODUCT,
    UNSUPPORTED_COMBINED_LISTING_PARENT_OPERATION,
}