#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `webhookSubscriptionDelete` mutation.
/// </summary>
public record WebhookSubscriptionDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted webhook subscription.
    /// </summary>
    [JsonPropertyName("deletedWebhookSubscriptionId")]
    public string? deletedWebhookSubscriptionId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}