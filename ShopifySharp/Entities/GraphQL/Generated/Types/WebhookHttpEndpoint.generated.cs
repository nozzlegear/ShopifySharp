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
/// An HTTPS endpoint that receives webhook events as POST requests, letting your
/// app respond to Shopify events in real-time. This is the most common webhook
/// endpoint type, allowing apps to process Shopify events through standard HTTP callbacks.
/// For example, when setting up order notifications, your app would provide an
/// HTTPS URL like `https://yourapp.com/webhooks/orders/create` to receive order
/// creation events as JSON payloads.
/// HTTP endpoints offer straightforward webhook integration with immediate event
/// delivery, making them suitable for apps that need real-time notifications
/// without complex infrastructure requirements.
/// Learn more about [HTTP webhook configuration](https://shopify.dev/docs/apps/build/webhooks/subscribe/https).
/// </summary>
public record WebhookHttpEndpoint : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The URL to which the webhooks events are sent.
    /// </summary>
    [JsonPropertyName("callbackUrl")]
    public string? callbackUrl { get; set; } = null;
}