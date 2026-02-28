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
/// Individual Google Cloud Pub/Sub topics that receive webhook events for reliable,
/// asynchronous processing. This endpoint type lets your app tap into Google
/// Cloud's messaging infrastructure to handle events at scale.
/// For example, when inventory levels change, Shopify can publish these events to
/// your Pub/Sub topic `projects/your-project/topics/inventory-updates`, allowing
/// your Google Cloud functions or services to process inventory changes at their own pace.
/// Pub/Sub endpoints provide reliable message delivery to Google Cloud Pub/Sub,
/// making them excellent for apps that need to handle variable webhook volumes or
/// integrate with Google Cloud Platform services.
/// Learn more about [Pub/Sub webhook configuration](https://shopify.dev/docs/apps/build/webhooks/subscribe/get-started).
/// </summary>
public record WebhookPubSubEndpoint : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The Google Cloud Pub/Sub project ID.
    /// </summary>
    [JsonPropertyName("pubSubProject")]
    public string? pubSubProject { get; set; } = null;

    /// <summary>
    /// The Google Cloud Pub/Sub topic ID.
    /// </summary>
    [JsonPropertyName("pubSubTopic")]
    public string? pubSubTopic { get; set; } = null;
}