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
/// Return type for `subscriptionBillingCycleEditsDelete` mutation.
/// </summary>
public record SubscriptionBillingCycleEditsDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The list of updated billing cycles.
    /// </summary>
    [JsonPropertyName("billingCycles")]
    public ICollection<SubscriptionBillingCycle>? billingCycles { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionBillingCycleUserError>? userErrors { get; set; } = null;
}