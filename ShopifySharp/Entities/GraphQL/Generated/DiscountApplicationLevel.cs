#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The level at which the discount's value is applied.
/// </summary>
public enum DiscountApplicationLevel
{
    ORDER,
    LINE,
}