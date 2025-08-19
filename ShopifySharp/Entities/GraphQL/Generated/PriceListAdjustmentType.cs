#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a percentage price adjustment type.
/// </summary>
public enum PriceListAdjustmentType
{
    PERCENTAGE_DECREASE,
    PERCENTAGE_INCREASE,
}