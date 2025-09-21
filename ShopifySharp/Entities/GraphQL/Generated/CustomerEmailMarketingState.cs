#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The possible email marketing states for a customer.
/// </summary>
public enum CustomerEmailMarketingState
{
    NOT_SUBSCRIBED,
    PENDING,
    SUBSCRIBED,
    UNSUBSCRIBED,
    REDACTED,
    INVALID,
}