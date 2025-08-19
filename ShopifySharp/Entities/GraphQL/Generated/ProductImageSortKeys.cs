#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the ProductImage query.
/// </summary>
public enum ProductImageSortKeys
{
    CREATED_AT,
    ID,
    POSITION,
}