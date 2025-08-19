#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of lines (line_item or shipping_line) to which the price rule applies.
/// </summary>
public enum PriceRuleTarget
{
    LINE_ITEM,
    SHIPPING_LINE,
}