#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `AppSubscriptionTrialExtendUserError`.
/// </summary>
public enum AppSubscriptionTrialExtendUserErrorCode
{
    SUBSCRIPTION_NOT_FOUND,
    TRIAL_NOT_ACTIVE,
    SUBSCRIPTION_NOT_ACTIVE,
}