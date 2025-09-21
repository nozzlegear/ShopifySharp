#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The type of the price rule value. The price rule value might be a percentage value, or a fixed amount.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<PriceRuleValue>))]
public record PriceRuleValue : GraphQLObject<PriceRuleValue>, IGraphQLUnionType
{
    public PriceRuleFixedAmountValue? AsPriceRuleFixedAmountValue() => this is PriceRuleValuePriceRuleFixedAmountValue wrapper ? wrapper.Value : null;
    public PriceRulePercentValue? AsPriceRulePercentValue() => this is PriceRuleValuePriceRulePercentValue wrapper ? wrapper.Value : null;
}