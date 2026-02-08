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
/// The set of strategies available for use on the `productVariantsBulkCreate` mutation.
/// </summary>
public enum ProductVariantsBulkCreateStrategy
{
    DEFAULT,
    REMOVE_STANDALONE_VARIANT,
    PRESERVE_STANDALONE_VARIANT,
}