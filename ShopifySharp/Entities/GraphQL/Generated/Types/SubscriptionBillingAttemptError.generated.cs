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
/// Possible error types for a subscription billing attempt.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SubscriptionBillingAttemptError>))]
public record SubscriptionBillingAttemptError : GraphQLObject<SubscriptionBillingAttemptError>, IGraphQLUnionType
{
    public SubscriptionBillingAttemptGeneralError? AsSubscriptionBillingAttemptGeneralError() => this is SubscriptionBillingAttemptErrorSubscriptionBillingAttemptGeneralError wrapper ? wrapper.Value : null;
    public SubscriptionBillingAttemptInventoryError? AsSubscriptionBillingAttemptInventoryError() => this is SubscriptionBillingAttemptErrorSubscriptionBillingAttemptInventoryError wrapper ? wrapper.Value : null;
    public SubscriptionBillingAttemptPaymentError? AsSubscriptionBillingAttemptPaymentError() => this is SubscriptionBillingAttemptErrorSubscriptionBillingAttemptPaymentError wrapper ? wrapper.Value : null;
    public SubscriptionBillingAttemptUnexpectedError? AsSubscriptionBillingAttemptUnexpectedError() => this is SubscriptionBillingAttemptErrorSubscriptionBillingAttemptUnexpectedError wrapper ? wrapper.Value : null;
}