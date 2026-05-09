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
/// The payment processing policy for a billing attempt.
/// </summary>
public enum SubscriptionBillingAttemptPaymentProcessingPolicy
{
    FAIL_UNLESS_VALID_PAYMENT_METHOD,
    SKIP_PAYMENT_AND_CREATE_UNPAID_ORDER,
}