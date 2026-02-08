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
/// Connects your app to Amazon EventBridge so you can receive Shopify webhook
/// events and process them through AWS's event-driven architecture. This gives you
/// enterprise-grade scalability and lets you tap into the full AWS ecosystem for
/// handling webhook traffic.
/// For example, when a customer places an order, Shopify can publish the order
/// creation event directly to your EventBridge partner source, allowing your AWS
/// infrastructure to process the event through Lambda functions, SQS queues, or
/// other AWS services.
/// EventBridge endpoints provide enterprise-grade event routing and processing
/// capabilities, making them ideal for apps that need to handle high-volume webhook
/// traffic or integrate deeply with AWS services.
/// Learn more about [webhook endpoints](https://shopify.dev/docs/apps/build/webhooks/subscribe/get-started).
/// </summary>
public record WebhookEventBridgeEndpoint : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The ARN of this EventBridge partner event source.
    /// </summary>
    [JsonPropertyName("arn")]
    public string? arn { get; set; } = null;
}