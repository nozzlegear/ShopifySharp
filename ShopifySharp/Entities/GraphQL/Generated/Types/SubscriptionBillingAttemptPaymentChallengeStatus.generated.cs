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
/// The status of the billing attempt authentication process.
/// </summary>
public enum SubscriptionBillingAttemptPaymentChallengeStatus
{
    OFF_SESSION_REJECTED,
    ON_SESSION_CHALLENGED,
}