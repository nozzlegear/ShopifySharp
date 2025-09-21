#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The possible product subscription states for a customer, as defined by the customer's subscription contracts.
/// </summary>
public enum CustomerProductSubscriberStatus
{
    ACTIVE,
    CANCELLED,
    EXPIRED,
    FAILED,
    NEVER_SUBSCRIBED,
    PAUSED,
}