#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the type of pricing associated to the selling plan (for example, a $10 or 20% discount that is set
/// for a limited period or that is fixed for the duration of the subscription). Selling plan pricing policies and
/// associated records (selling plan groups, selling plans, billing policy, and delivery policy) are deleted 48
/// hours after a merchant uninstalls their subscriptions app. We recommend backing up these records if you need
/// to restore them later.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(SellingPlanPricingPolicySellingPlanFixedPricingPolicy), typeDiscriminator: "SellingPlanFixedPricingPolicy")]
[JsonDerivedType(typeof(SellingPlanPricingPolicySellingPlanRecurringPricingPolicy), typeDiscriminator: "SellingPlanRecurringPricingPolicy")]
public record SellingPlanPricingPolicy : GraphQLObject<SellingPlanPricingPolicy>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public SellingPlanFixedPricingPolicy? AsSellingPlanFixedPricingPolicy() => this is SellingPlanPricingPolicySellingPlanFixedPricingPolicy wrapper ? wrapper.Value : null;
	public SellingPlanRecurringPricingPolicy? AsSellingPlanRecurringPricingPolicy() => this is SellingPlanPricingPolicySellingPlanRecurringPricingPolicy wrapper ? wrapper.Value : null;
#endif
}