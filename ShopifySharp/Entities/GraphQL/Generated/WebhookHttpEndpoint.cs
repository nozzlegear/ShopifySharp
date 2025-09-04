#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An HTTPS endpoint to which webhook subscriptions send POST requests.
/// </summary>
public record WebhookHttpEndpoint : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The URL to which the webhooks events are sent.
    /// </summary>
    [JsonPropertyName("callbackUrl")]
    public string? callbackUrl { get; set; } = null;
}