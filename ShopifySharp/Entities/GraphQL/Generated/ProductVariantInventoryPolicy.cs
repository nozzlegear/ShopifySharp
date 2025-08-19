#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The valid values for the inventory policy of a product variant once it is out of stock.
/// </summary>
public enum ProductVariantInventoryPolicy
{
    DENY,
    CONTINUE,
}