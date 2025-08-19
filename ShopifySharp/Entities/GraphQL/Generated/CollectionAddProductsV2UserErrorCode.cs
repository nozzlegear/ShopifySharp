#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `CollectionAddProductsV2UserError`.
/// </summary>
public enum CollectionAddProductsV2UserErrorCode
{
    CANT_ADD_TO_SMART_COLLECTION,
    COLLECTION_DOES_NOT_EXIST,
}