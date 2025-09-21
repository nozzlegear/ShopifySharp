#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `pubSubWebhookSubscriptionUpdate` mutation.
/// </summary>
public record PubSubWebhookSubscriptionUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PubSubWebhookSubscriptionUpdateUserError>? userErrors { get; set; } = null;

    /// <summary>
    /// The webhook subscription that was updated.
    /// </summary>
    [JsonPropertyName("webhookSubscription")]
    public WebhookSubscription? webhookSubscription { get; set; } = null;
}