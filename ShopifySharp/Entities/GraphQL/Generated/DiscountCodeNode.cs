#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The `DiscountCodeNode` object enables you to manage [code discounts](https://help.shopify.com/manual/discounts/discount-types#discount-codes)
/// that are applied when customers enter a code at checkout. For example, you can
/// offer discounts where customers have to enter a code to redeem an amount off
/// discount on products, variants, or collections in a store. Or, you can offer
/// discounts where customers have to enter a code to get free shipping. Merchants
/// can create and share discount codes individually with customers.
/// Learn more about working with [Shopify's discount model](https://shopify.dev/docs/apps/build/discounts),
/// including related queries, mutations, limitations, and considerations.
/// </summary>
public record DiscountCodeNode : MetafieldReferencer, IGraphQLUnionCase, IGraphQLObject, IHasEvents, IHasMetafieldDefinitions, IHasMetafields, INode
{
    /// <summary>
    /// The underlying code discount object.
    /// </summary>
    [JsonPropertyName("codeDiscount")]
    public DiscountCode? codeDiscount { get; set; } = null;

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