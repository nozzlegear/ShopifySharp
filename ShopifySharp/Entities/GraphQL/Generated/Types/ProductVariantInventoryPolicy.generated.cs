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
/// The valid values for the inventory policy of a product variant once it is out of stock.
/// </summary>
public enum ProductVariantInventoryPolicy
{
    DENY,
    CONTINUE,
}