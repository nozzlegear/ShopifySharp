#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// One of the actions that the fulfillment order supports in its current state.
/// </summary>
public record FulfillmentOrderSupportedAction : IGraphQLObject
{
    /// <summary>
    /// The action value.
    /// </summary>
    [JsonPropertyName("action")]
    public FulfillmentOrderAction? action { get; set; } = null;

    /// <summary>
    /// The external URL to be used to initiate the fulfillment process outside Shopify.
    /// Applicable only when the `action` value is `EXTERNAL`.
    /// </summary>
    [JsonPropertyName("externalUrl")]
    public string? externalUrl { get; set; } = null;
}