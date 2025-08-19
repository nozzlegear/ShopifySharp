#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a valid PayPal Express subscriptions gateway status.
/// </summary>
public enum PaypalExpressSubscriptionsGatewayStatus
{
    ENABLED,
    DISABLED,
    PENDING,
}