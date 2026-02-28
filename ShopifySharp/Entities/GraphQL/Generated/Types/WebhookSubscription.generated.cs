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
/// A webhook subscription is a persisted data object created by an app using the REST Admin API or GraphQL Admin API.
/// It describes the topic that the app wants to receive, and a destination where
/// Shopify should send webhooks of the specified topic.
/// When an event for a given topic occurs, the webhook subscription sends a relevant payload to the destination.
/// Learn more about the [webhooks system](https://shopify.dev/apps/webhooks).
/// </summary>
public record WebhookSubscription : IGraphQLObject, ILegacyInteroperability, INode
{
    /// <summary>
    /// The Admin API version that Shopify uses to serialize webhook events. This
    /// value is inherited from the app that created the webhook subscription.
    /// </summary>
    [JsonPropertyName("apiVersion")]
    public ApiVersion? apiVersion { get; set; } = null;

    /// <summary>
    /// The destination URI to which the webhook subscription will send a message when an event occurs.
    /// </summary>
    [JsonPropertyName("callbackUrl")]
    [Obsolete("Use `uri` instead.")]
    public string? callbackUrl { get; set; } = null;

    /// <summary>
    /// The date and time when the webhook subscription was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The endpoint to which the webhook subscription will send events.
    /// </summary>
    [JsonPropertyName("endpoint")]
    [Obsolete("Use `uri` instead.")]
    public WebhookSubscriptionEndpoint? endpoint { get; set; } = null;

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
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The list of fields to be included in the webhook subscription. Only the fields
    /// specified will be included in the webhook payload. If null, then all fields
    /// will be included. Learn more about [modifying webhook payloads](https://shopify.dev/docs/apps/build/webhooks/customize/modify-payloads).
    /// </summary>
    [JsonPropertyName("includeFields")]
    public ICollection<string>? includeFields { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The list of namespaces for any metafields that should be included in the webhook subscription.
    /// </summary>
    [JsonPropertyName("metafieldNamespaces")]
    public ICollection<string>? metafieldNamespaces { get; set; } = null;

    /// <summary>
    /// The list of identifiers specifying metafields to include in the webhook subscription.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<WebhookSubscriptionMetafieldIdentifier>? metafields { get; set; } = null;

    /// <summary>
    /// The type of event that triggers the webhook. The topic determines when the
    /// webhook subscription sends a webhook, as well as what class of data object
    /// that webhook contains.
    /// </summary>
    [JsonPropertyName("topic")]
    public WebhookSubscriptionTopic? topic { get; set; } = null;

    /// <summary>
    /// The date and time when the webhook subscription was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;

    /// <summary>
    /// The URI to which the webhook subscription will send events.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? uri { get; set; } = null;
}