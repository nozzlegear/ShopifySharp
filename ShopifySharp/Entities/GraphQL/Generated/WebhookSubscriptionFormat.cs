#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The supported formats for webhook subscriptions.
/// </summary>
public enum WebhookSubscriptionFormat
{
    JSON,
    XML,
}