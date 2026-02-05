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
/// The `DiscountAutomaticNode` object enables you to manage [automatic discounts](https://help.shopify.com/manual/discounts/discount-types#automatic-discounts)
/// that are applied when an order meets specific criteria. You can create amount
/// off, free shipping, or buy X get Y automatic discounts. For example, you can
/// offer customers a free shipping discount that applies when conditions are met.
/// Or you can offer customers a buy X get Y discount that's automatically applied
/// when customers spend a specified amount of money, or a specified quantity of products.
/// Learn more about working with [Shopify's discount model](https://shopify.dev/docs/apps/build/discounts),
/// including related queries, mutations, limitations, and considerations.
/// </summary>
public record DiscountAutomaticNode : IGraphQLUnionCase, IGraphQLObject, IHasEvents, IHasMetafieldDefinitions, IHasMetafields, INode
{
    /// <summary>
    /// A discount that's applied automatically when an order meets specific criteria.
    /// Learn more about [automatic discounts](https://help.shopify.com/manual/discounts/discount-types#automatic-discounts).
    /// </summary>
    [JsonPropertyName("automaticDiscount")]
    public DiscountAutomatic? automaticDiscount { get; set; } = null;

    /// <summary>
    /// The paginated list of events associated with the host subject.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

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
}