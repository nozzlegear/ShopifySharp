#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a selling plan pricing policy adjustment value type.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SellingPlanPricingPolicyAdjustmentValue>))]
public record SellingPlanPricingPolicyAdjustmentValue : GraphQLObject<SellingPlanPricingPolicyAdjustmentValue>, IGraphQLUnionType
{
    public MoneyV2? AsMoneyV2() => this is SellingPlanPricingPolicyAdjustmentValueMoneyV2 wrapper ? wrapper.Value : null;
    public SellingPlanPricingPolicyPercentageValue? AsSellingPlanPricingPolicyPercentageValue() => this is SellingPlanPricingPolicyAdjustmentValueSellingPlanPricingPolicyPercentageValue wrapper ? wrapper.Value : null;
}