#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the billing frequency associated to the selling plan (for example, bill every week, or bill every
/// three months). The selling plan billing policy and associated records (selling plan groups, selling plans, pricing
/// policies, and delivery policy) are deleted 48 hours after a merchant uninstalls their subscriptions app.
/// We recommend backing up these records if you need to restore them later.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SellingPlanBillingPolicy>))]
public record SellingPlanBillingPolicy : GraphQLObject<SellingPlanBillingPolicy>, IGraphQLUnionType
{
    public SellingPlanFixedBillingPolicy? AsSellingPlanFixedBillingPolicy() => this is SellingPlanBillingPolicySellingPlanFixedBillingPolicy wrapper ? wrapper.Value : null;
    public SellingPlanRecurringBillingPolicy? AsSellingPlanRecurringBillingPolicy() => this is SellingPlanBillingPolicySellingPlanRecurringBillingPolicy wrapper ? wrapper.Value : null;
}