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
/// The action required to continue processing the billing attempt.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SubscriptionBillingAttemptAction>))]
public record SubscriptionBillingAttemptAction : GraphQLObject<SubscriptionBillingAttemptAction>, IGraphQLUnionType
{
    public SubscriptionBillingAttemptPaymentChallenge? AsSubscriptionBillingAttemptPaymentChallenge() => this is SubscriptionBillingAttemptActionSubscriptionBillingAttemptPaymentChallenge wrapper ? wrapper.Value : null;
}