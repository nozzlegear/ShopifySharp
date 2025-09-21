#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The supported formats for webhook subscriptions.
/// </summary>
public enum WebhookSubscriptionFormat
{
    JSON,
    XML,
}