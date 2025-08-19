#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of strategies available for use on the `productOptionDelete` mutation.
/// </summary>
public enum ProductOptionDeleteStrategy
{
    DEFAULT,
    POSITION,
    NON_DESTRUCTIVE,
}