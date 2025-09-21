#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A checkout server side validation installed on the shop.
/// </summary>
public record Validation : IGraphQLObject, IHasMetafieldDefinitions, IHasMetafields, INode
{
    /// <summary>
    /// Whether the validation should block on failures other than expected violations.
    /// </summary>
    [JsonPropertyName("blockOnFailure")]
    public bool? blockOnFailure { get; set; } = null;

    /// <summary>
    /// Whether the validation is enabled on the merchant checkout.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;

    /// <summary>
    /// The error history on the most recent version of the validation function.
    /// </summary>
    [JsonPropertyName("errorHistory")]
    public FunctionsErrorHistory? errorHistory { get; set; } = null;

    /// <summary>
    /// Global ID for the validation.
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
    /// List of metafield definitions.
    /// </summary>
    [JsonPropertyName("metafieldDefinitions")]
    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public MetafieldDefinitionConnection? metafieldDefinitions { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// The Shopify Function implementing the validation.
    /// </summary>
    [JsonPropertyName("shopifyFunction")]
    public ShopifyFunction? shopifyFunction { get; set; } = null;

    /// <summary>
    /// The merchant-facing validation name.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}