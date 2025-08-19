#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A fulfillment constraint rule.
/// </summary>
public record FulfillmentConstraintRule : IGraphQLObject, IHasMetafields, INode
{
    /// <summary>
    /// Delivery method types that the function is associated with.
    /// </summary>
    [JsonPropertyName("deliveryMethodTypes")]
    public ICollection<DeliveryMethodType>? deliveryMethodTypes { get; set; } = null;

    /// <summary>
    /// The ID for the fulfillment constraint function.
    /// </summary>
    [JsonPropertyName("function")]
    public ShopifyFunction? function { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;
}