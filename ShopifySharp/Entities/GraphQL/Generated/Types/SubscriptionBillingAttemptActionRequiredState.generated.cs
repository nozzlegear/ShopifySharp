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
/// The billing attempt state that requires an action to resolve.
/// Must complete the action required for the billing attempt to continue being processed.
/// </summary>
public record SubscriptionBillingAttemptActionRequiredState : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The action required to resolve the billing attempt.
    /// </summary>
    [JsonPropertyName("action")]
    public SubscriptionBillingAttemptAction? action { get; set; } = null;
}