#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `webhookSubscriptionCreate` mutation.
/// </summary>
public record WebhookSubscriptionCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;

    /// <summary>
    /// The webhook subscription that was created.
    /// </summary>
    [JsonPropertyName("webhookSubscription")]
    public WebhookSubscription? webhookSubscription { get; set; } = null;
}