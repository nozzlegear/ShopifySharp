#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `ProductBundleMutationUserError`.
/// </summary>
public enum ProductBundleMutationUserErrorCode
{
    GENERIC_ERROR,
    PRODUCT_DOES_NOT_EXIST,
    INVALID_INPUT,
    JOB_ERROR,
}