#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the delivery frequency associated to the selling plan (for example, deliver every month, or deliver
/// every other week). The selling plan delivery policy and associated records (selling plan groups, selling plans,
/// pricing policies, and billing policy) are deleted 48 hours after a merchant uninstalls their subscriptions app.
/// We recommend backing up these records if you need to restore them later.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SellingPlanDeliveryPolicy>))]
public record SellingPlanDeliveryPolicy : GraphQLObject<SellingPlanDeliveryPolicy>, IGraphQLUnionType
{
    public SellingPlanFixedDeliveryPolicy? AsSellingPlanFixedDeliveryPolicy() => this is SellingPlanDeliveryPolicySellingPlanFixedDeliveryPolicy wrapper ? wrapper.Value : null;
    public SellingPlanRecurringDeliveryPolicy? AsSellingPlanRecurringDeliveryPolicy() => this is SellingPlanDeliveryPolicySellingPlanRecurringDeliveryPolicy wrapper ? wrapper.Value : null;
}