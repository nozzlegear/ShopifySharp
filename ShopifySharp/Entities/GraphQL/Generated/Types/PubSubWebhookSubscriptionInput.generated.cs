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
/// The input fields for a PubSub webhook subscription.
/// </summary>
public record PubSubWebhookSubscriptionInput : GraphQLInputObject<PubSubWebhookSubscriptionInput>
{
    /// <summary>
    /// A constraint specified using search syntax that ensures only webhooks that
    /// match the specified filter are emitted. See our [guide on
    /// filters](https://shopify.dev/docs/apps/build/webhooks/customize/filters) for more details.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? filter { get; set; } = null;

    /// <summary>
    /// The format in which the webhook subscription should send the data.
    /// </summary>
    [JsonPropertyName("format")]
    public WebhookSubscriptionFormat? format { get; set; } = null;

    /// <summary>
    /// The list of fields to be included in the webhook subscription. Only the fields
    /// specified will be included in the webhook payload. If null, then all fields
    /// will be included. Learn more about [modifying webhook payloads](https://shopify.dev/docs/apps/build/webhooks/customize/modify_payloads).
    /// </summary>
    [JsonPropertyName("includeFields")]
    public ICollection<string>? includeFields { get; set; } = null;

    /// <summary>
    /// The list of namespaces for any metafields that should be included in the webhook subscription.
    /// </summary>
    [JsonPropertyName("metafieldNamespaces")]
    public ICollection<string>? metafieldNamespaces { get; set; } = null;

    /// <summary>
    /// A list of identifiers specifying metafields to include in the webhook payload.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<HasMetafieldsMetafieldIdentifierInput>? metafields { get; set; } = null;

    /// <summary>
    /// The Pub/Sub project ID.
    /// </summary>
    [JsonPropertyName("pubSubProject")]
    public string? pubSubProject { get; set; } = null;

    /// <summary>
    /// The Pub/Sub topic ID.
    /// </summary>
    [JsonPropertyName("pubSubTopic")]
    public string? pubSubTopic { get; set; } = null;
}