#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Answers the question if prices include duties and / or taxes.
/// </summary>
public enum InclusiveDutiesPricingStrategy
{
    ADD_DUTIES_AT_CHECKOUT,
    INCLUDE_DUTIES_IN_PRICE,
}