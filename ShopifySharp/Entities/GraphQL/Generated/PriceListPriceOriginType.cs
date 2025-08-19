#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the origin of a price, either fixed (defined on the price list) or
/// relative (calculated using a price list adjustment configuration). For examples, refer to [PriceList](https://shopify.dev/api/admin-graphql/latest/queries/priceList#section-examples).
/// </summary>
public enum PriceListPriceOriginType
{
    FIXED,
    RELATIVE,
}