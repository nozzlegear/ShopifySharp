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
/// A delivery customization.
/// </summary>
public record DeliveryCustomization : IGraphQLUnionCase, IGraphQLObject, IHasMetafieldDefinitions, IHasMetafields, INode
{
    /// <summary>
    /// The enabled status of the delivery customization.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;

    /// <summary>
    /// The error history on the most recent version of the delivery customization.
    /// </summary>
    [JsonPropertyName("errorHistory")]
    public FunctionsErrorHistory? errorHistory { get; set; } = null;

    /// <summary>
    /// The ID of the Shopify Function implementing the delivery customization.
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
    /// The Shopify Function implementing the delivery customization.
    /// </summary>
    [JsonPropertyName("shopifyFunction")]
    public ShopifyFunction? shopifyFunction { get; set; } = null;

    /// <summary>
    /// The title of the delivery customization.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}