#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record PriceRuleValuePriceRuleFixedAmountValue(PriceRuleFixedAmountValue Value): PriceRuleValue;
internal record PriceRuleValuePriceRulePercentValue(PriceRulePercentValue Value): PriceRuleValue;
#endif /// <summary>

/// One type of value given to a customer when a discount is applied to an order.
/// The application of a discount with this value gives the customer the specified percentage off a specified item.
/// </summary>
public record PricingPercentageValue : PricingValue, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The percentage value of the object. This is a number between -100 (free) and 0 (no discount).
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}