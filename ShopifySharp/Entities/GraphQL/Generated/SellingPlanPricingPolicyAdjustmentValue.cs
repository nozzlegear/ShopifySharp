#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a selling plan pricing policy adjustment value type.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(SellingPlanPricingPolicyAdjustmentValueMoneyV2), typeDiscriminator: "MoneyV2")]
[JsonDerivedType(typeof(SellingPlanPricingPolicyAdjustmentValueSellingPlanPricingPolicyPercentageValue), typeDiscriminator: "SellingPlanPricingPolicyPercentageValue")]
public record SellingPlanPricingPolicyAdjustmentValue : GraphQLObject<SellingPlanPricingPolicyAdjustmentValue>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public MoneyV2? AsMoneyV2() => this is SellingPlanPricingPolicyAdjustmentValueMoneyV2 wrapper ? wrapper.Value : null;
	public SellingPlanPricingPolicyPercentageValue? AsSellingPlanPricingPolicyPercentageValue() => this is SellingPlanPricingPolicyAdjustmentValueSellingPlanPricingPolicyPercentageValue wrapper ? wrapper.Value : null;
#endif
}