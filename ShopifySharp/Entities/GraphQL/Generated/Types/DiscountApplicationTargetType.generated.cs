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
/// The type of line (i.e. line item or shipping line) on an order that the discount is applicable towards.
/// </summary>
public enum DiscountApplicationTargetType
{
    LINE_ITEM,
    SHIPPING_LINE,
}