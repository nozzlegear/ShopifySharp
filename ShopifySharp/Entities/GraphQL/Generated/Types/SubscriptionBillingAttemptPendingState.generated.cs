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
/// The billing attempt is currently being processed.
/// </summary>
public record SubscriptionBillingAttemptPendingState : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Always true when the billing attempt is pending.
    /// </summary>
    [JsonPropertyName("processing")]
    public bool? processing { get; set; } = null;
}