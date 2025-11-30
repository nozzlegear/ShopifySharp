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
/// Contains information about an item in the exchange.
/// </summary>
public record ExchangeV2LineItem : IGraphQLObject
{
    /// <summary>
    /// A list of attributes that represent custom features or special requests.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; } = null;

    /// <summary>
    /// The total line price, in shop and presentment currencies, after discounts are applied.
    /// </summary>
    [JsonPropertyName("discountedTotalSet")]
    public MoneyBag? discountedTotalSet { get; set; } = null;

    /// <summary>
    /// The price, in shop and presentment currencies,
    /// of a single variant unit after line item discounts are applied.
    /// </summary>
    [JsonPropertyName("discountedUnitPriceSet")]
    public MoneyBag? discountedUnitPriceSet { get; set; } = null;

    /// <summary>
    /// Name of the service provider who fulfilled the order.
    /// Valid values are either **manual** or the name of the provider.
    /// For example, **amazon**, **shipwire**.
    /// Deleted fulfillment services will return null.
    /// </summary>
    [JsonPropertyName("fulfillmentService")]
    public FulfillmentService? fulfillmentService { get; set; } = null;

    /// <summary>
    /// Indiciates if this line item is a gift card.
    /// </summary>
    [JsonPropertyName("giftCard")]
    public bool? giftCard { get; set; } = null;

    /// <summary>
    /// The gift cards associated with the line item.
    /// </summary>
    [JsonPropertyName("giftCards")]
    public ICollection<GiftCard>? giftCards { get; set; } = null;

    /// <summary>
    /// Whether the line item represents the purchase of a gift card.
    /// </summary>
    [JsonPropertyName("isGiftCard")]
    public bool? isGiftCard { get; set; } = null;

    /// <summary>
    /// The line item associated with this object.
    /// </summary>
    [JsonPropertyName("lineItem")]
    public LineItem? lineItem { get; set; } = null;

    /// <summary>
    /// The name of the product.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The total price, in shop and presentment currencies, before discounts are applied.
    /// </summary>
    [JsonPropertyName("originalTotalSet")]
    public MoneyBag? originalTotalSet { get; set; } = null;

    /// <summary>
    /// The price, in shop and presentment currencies,
    /// of a single variant unit before line item discounts are applied.
    /// </summary>
    [JsonPropertyName("originalUnitPriceSet")]
    public MoneyBag? originalUnitPriceSet { get; set; } = null;

    /// <summary>
    /// The number of products that were purchased.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Whether physical shipping is required for the variant.
    /// </summary>
    [JsonPropertyName("requiresShipping")]
    public bool? requiresShipping { get; set; } = null;

    /// <summary>
    /// The SKU number of the product variant.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

    /// <summary>
    /// Whether the variant is taxable.
    /// </summary>
    [JsonPropertyName("taxable")]
    public bool? taxable { get; set; } = null;

    /// <summary>
    /// The TaxLine object connected to this line item.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<TaxLine>? taxLines { get; set; } = null;

    /// <summary>
    /// The title of the product or variant. This field only applies to custom line items.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The product variant of the line item.
    /// </summary>
    [JsonPropertyName("variant")]
    public ProductVariant? variant { get; set; } = null;

    /// <summary>
    /// The name of the variant.
    /// </summary>
    [JsonPropertyName("variantTitle")]
    public string? variantTitle { get; set; } = null;

    /// <summary>
    /// The name of the vendor who created the product variant.
    /// </summary>
    [JsonPropertyName("vendor")]
    public string? vendor { get; set; } = null;
}