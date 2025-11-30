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
/// The `DiscountNode` object enables you to manage
/// [discounts](https://help.shopify.com/manual/discounts), which are applied at
/// checkout or on a cart.
/// Discounts are a way for merchants to promote sales and special offers, or as
/// customer loyalty rewards. Discounts can apply to [orders, products, or
/// shipping](https://shopify.dev/docs/apps/build/discounts#discount-classes), and
/// can be either automatic or code-based. For example, you can offer customers a
/// buy X get Y discount that's automatically applied when purchases meet specific
/// criteria. Or, you can offer discounts where customers have to enter a code to
/// redeem an amount off discount on products, variants, or collections in a store.
/// Learn more about working with [Shopify's discount model](https://shopify.dev/docs/apps/build/discounts),
/// including related mutations, limitations, and considerations.
/// </summary>
public record DiscountNode : IGraphQLUnionCase, IGraphQLObject, IHasEvents, IHasMetafieldDefinitions, IHasMetafields, INode
{
    /// <summary>
    /// A discount that's applied at checkout or on cart.
    /// Discounts can be [automatic or code-based](https://shopify.dev/docs/apps/build/discounts#discount-methods).
    /// </summary>
    [JsonPropertyName("discount")]
    public Discount? discount { get; set; } = null;

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