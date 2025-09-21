#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents relative adjustments from one price list to other prices.
///   You can use a `PriceListParent` to specify an adjusted relative price using a percentage-based
///   adjustment. Adjusted prices work in conjunction with exchange rules and rounding.
///   [Adjustment types](https://shopify.dev/api/admin-graphql/latest/enums/pricelistadjustmenttype)
///   support both percentage increases and decreases.
/// </summary>
public record PriceListParent : IGraphQLObject
{
    /// <summary>
    /// A price list adjustment.
    /// </summary>
    [JsonPropertyName("adjustment")]
    public PriceListAdjustment? adjustment { get; set; } = null;

    /// <summary>
    /// A price list's settings for adjustment.
    /// </summary>
    [JsonPropertyName("settings")]
    public PriceListAdjustmentSettings? settings { get; set; } = null;
}