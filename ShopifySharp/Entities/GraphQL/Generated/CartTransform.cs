#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A Cart Transform Function to create [Customized Bundles.](https://shopify.dev/docs/apps/selling-strategies/bundles/add-a-customized-bundle).
/// </summary>
public record CartTransform : IGraphQLObject, IHasMetafields, INode
{
    /// <summary>
    /// Whether a run failure will block cart and checkout operations.
    /// </summary>
    [JsonPropertyName("blockOnFailure")]
    public bool? blockOnFailure { get; set; } = null;

    /// <summary>
    /// The ID for the Cart Transform function.
    /// </summary>
    [JsonPropertyName("functionId")]
    public string? functionId { get; set; } = null;

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