#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of the price rule value. The price rule value might be a percentage value, or a fixed amount.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(PriceRuleFixedAmountValue), typeDiscriminator: "PriceRuleFixedAmountValue")]
[JsonDerivedType(typeof(PriceRulePercentValue), typeDiscriminator: "PriceRulePercentValue")]
public record PriceRuleValue : GraphQLObject<PriceRuleValue>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public PriceRuleFixedAmountValue? AsPriceRuleFixedAmountValue() => this is PriceRuleValuePriceRuleFixedAmountValue wrapper ? wrapper.Value : null;
	public PriceRulePercentValue? AsPriceRulePercentValue() => this is PriceRuleValuePriceRulePercentValue wrapper ? wrapper.Value : null;
#endif
}