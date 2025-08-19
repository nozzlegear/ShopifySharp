#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of strategies available for use on the `productVariantsBulkCreate` mutation.
/// </summary>
public enum ProductVariantsBulkCreateStrategy
{
    DEFAULT,
    REMOVE_STANDALONE_VARIANT,
}