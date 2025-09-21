#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `webhookSubscriptionUpdate` mutation.
/// </summary>
public record WebhookSubscriptionUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;

    /// <summary>
    /// The webhook subscription that was updated.
    /// </summary>
    [JsonPropertyName("webhookSubscription")]
    public WebhookSubscription? webhookSubscription { get; set; } = null;
}