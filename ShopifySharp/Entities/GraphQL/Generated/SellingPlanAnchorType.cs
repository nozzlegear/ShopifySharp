#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the anchor type.
/// </summary>
public enum SellingPlanAnchorType
{
    WEEKDAY,
    MONTHDAY,
    YEARDAY,
}