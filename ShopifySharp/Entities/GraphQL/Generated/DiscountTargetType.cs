#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of line (line item or shipping line) on an order that the subscription discount is applicable towards.
/// </summary>
public enum DiscountTargetType
{
    LINE_ITEM,
    SHIPPING_LINE,
}