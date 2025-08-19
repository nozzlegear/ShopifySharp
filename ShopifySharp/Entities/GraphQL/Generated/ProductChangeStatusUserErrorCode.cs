#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `ProductChangeStatusUserError`.
/// </summary>
public enum ProductChangeStatusUserErrorCode
{
    PRODUCT_NOT_FOUND,
    COMBINED_LISTINGS_NOT_COMPATIBLE_WITH_SHOP,
}