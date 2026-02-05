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
/// Represents a valid PayPal Express subscriptions gateway status.
/// </summary>
public enum PaypalExpressSubscriptionsGatewayStatus
{
    ENABLED,
    DISABLED,
    PENDING,
}