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
/// Return type for `subscriptionDraftUpdate` mutation.
/// </summary>
public record SubscriptionDraftUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The Subscription Draft object.
    /// </summary>
    [JsonPropertyName("draft")]
    public SubscriptionDraft? draft { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionDraftUserError>? userErrors { get; set; } = null;
}