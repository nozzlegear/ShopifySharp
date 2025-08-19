#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The portion of the price to be charged at checkout.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(MoneyV2), typeDiscriminator: "MoneyV2")]
[JsonDerivedType(typeof(SellingPlanCheckoutChargePercentageValue), typeDiscriminator: "SellingPlanCheckoutChargePercentageValue")]
public record SellingPlanCheckoutChargeValue : GraphQLObject<SellingPlanCheckoutChargeValue>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public MoneyV2? AsMoneyV2() => this is SellingPlanCheckoutChargeValueMoneyV2 wrapper ? wrapper.Value : null;
	public SellingPlanCheckoutChargePercentageValue? AsSellingPlanCheckoutChargePercentageValue() => this is SellingPlanCheckoutChargeValueSellingPlanCheckoutChargePercentageValue wrapper ? wrapper.Value : null;
#endif
}