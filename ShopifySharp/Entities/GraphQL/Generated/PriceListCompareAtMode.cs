#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents how the compare at price will be determined for a price list.
/// </summary>
public enum PriceListCompareAtMode
{
    ADJUSTED,
    NULLIFY,
}