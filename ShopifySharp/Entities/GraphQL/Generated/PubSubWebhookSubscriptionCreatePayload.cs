#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `pubSubWebhookSubscriptionCreate` mutation.
/// </summary>
public record PubSubWebhookSubscriptionCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PubSubWebhookSubscriptionCreateUserError>? userErrors { get; set; } = null;

    /// <summary>
    /// The webhook subscription that was created.
    /// </summary>
    [JsonPropertyName("webhookSubscription")]
    public WebhookSubscription? webhookSubscription { get; set; } = null;
}