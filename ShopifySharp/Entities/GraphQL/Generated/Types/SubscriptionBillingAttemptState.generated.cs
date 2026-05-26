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
/// The state of a subscription billing attempt with state-specific data.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SubscriptionBillingAttemptState>))]
public record SubscriptionBillingAttemptState : GraphQLObject<SubscriptionBillingAttemptState>, IGraphQLUnionType
{
    public SubscriptionBillingAttemptActionRequiredState? AsSubscriptionBillingAttemptActionRequiredState() => this is SubscriptionBillingAttemptStateSubscriptionBillingAttemptActionRequiredState wrapper ? wrapper.Value : null;
    public SubscriptionBillingAttemptFailedState? AsSubscriptionBillingAttemptFailedState() => this is SubscriptionBillingAttemptStateSubscriptionBillingAttemptFailedState wrapper ? wrapper.Value : null;
    public SubscriptionBillingAttemptPendingState? AsSubscriptionBillingAttemptPendingState() => this is SubscriptionBillingAttemptStateSubscriptionBillingAttemptPendingState wrapper ? wrapper.Value : null;
    public SubscriptionBillingAttemptSuccessState? AsSubscriptionBillingAttemptSuccessState() => this is SubscriptionBillingAttemptStateSubscriptionBillingAttemptSuccessState wrapper ? wrapper.Value : null;
}