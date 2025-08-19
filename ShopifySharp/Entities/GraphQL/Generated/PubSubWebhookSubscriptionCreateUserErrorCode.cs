#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `PubSubWebhookSubscriptionCreateUserError`.
/// </summary>
public enum PubSubWebhookSubscriptionCreateUserErrorCode
{
    INVALID_PARAMETERS,
    TAKEN,
}