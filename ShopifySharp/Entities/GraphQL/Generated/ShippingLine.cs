#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the shipping details that the customer chose for their order.
/// </summary>
public record ShippingLine : DraftOrderPlatformDiscountAllocationTarget, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// A reference to the carrier service that provided the rate.
    /// Present when the rate was computed by a third-party carrier service.
    /// </summary>
    [JsonPropertyName("carrierIdentifier")]
    public string? carrierIdentifier { get; set; } = null;

    /// <summary>
    /// A reference to the shipping method.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The current shipping price after applying refunds, after applying discounts.
    /// If the parent `order.taxesIncluded`` field is true, then this price includes
    /// taxes. Otherwise, this field is the pre-tax price.
    /// </summary>
    [JsonPropertyName("currentDiscountedPriceSet")]
    public MoneyBag? currentDiscountedPriceSet { get; set; } = null;

    /// <summary>
    /// Whether the shipping line is custom or not.
    /// </summary>
    [JsonPropertyName("custom")]
    public bool? custom { get; set; } = null;

    /// <summary>
    /// The general classification of the delivery method.
    /// </summary>
    [JsonPropertyName("deliveryCategory")]
    public string? deliveryCategory { get; set; } = null;

    /// <summary>
    /// The discounts that have been allocated to the shipping line.
    /// </summary>
    [JsonPropertyName("discountAllocations")]
    public ICollection<DiscountAllocation>? discountAllocations { get; set; } = null;

    /// <summary>
    /// The pre-tax shipping price with discounts applied.
    /// As of API version 2024-07, this will be calculated including cart level discounts, such as the free shipping discount.
    /// </summary>
    [JsonPropertyName("discountedPrice")]
    [Obsolete("Use `discountedPriceSet` instead.")]
    public MoneyV2? discountedPrice { get; set; } = null;

    /// <summary>
    /// The shipping price after applying discounts. If the parent order.taxesIncluded
    /// field is true, then this price includes taxes. If not, it's the pre-tax price.
    /// As of API version 2024-07, this will be calculated including cart level discounts, such as the free shipping discount.
    /// </summary>
    [JsonPropertyName("discountedPriceSet")]
    public MoneyBag? discountedPriceSet { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the shipping line has been removed.
    /// </summary>
    [JsonPropertyName("isRemoved")]
    public bool? isRemoved { get; set; } = null;

    /// <summary>
    /// The pre-tax shipping price without any discounts applied.
    /// </summary>
    [JsonPropertyName("originalPrice")]
    [Obsolete("Use `originalPriceSet` instead.")]
    public MoneyV2? originalPrice { get; set; } = null;

    /// <summary>
    /// The pre-tax shipping price without any discounts applied.
    /// </summary>
    [JsonPropertyName("originalPriceSet")]
    public MoneyBag? originalPriceSet { get; set; } = null;

    /// <summary>
    /// The phone number at the shipping address.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// Returns the price of the shipping line.
    /// </summary>
    [JsonPropertyName("price")]
    [Obsolete("Use `originalPriceSet` instead.")]
    public decimal? price { get; set; } = null;

    /// <summary>
    /// The fulfillment service requested for the shipping method.
    /// Present if the shipping method requires processing by a third party fulfillment service.
    /// </summary>
    [JsonPropertyName("requestedFulfillmentService")]
    [Obsolete("requestedFulfillmentService is no longer in use. Order routing does not use the requestedFulfillmentService during order and fulfillment order creation.")]
    public FulfillmentService? requestedFulfillmentService { get; set; } = null;

    /// <summary>
    /// A unique identifier for the shipping rate. The format can change without notice and isn't meant to be shown to users.
    /// </summary>
    [JsonPropertyName("shippingRateHandle")]
    public string? shippingRateHandle { get; set; } = null;

    /// <summary>
    /// Returns the rate source for the shipping line.
    /// </summary>
    [JsonPropertyName("source")]
    public string? source { get; set; } = null;

    /// <summary>
    /// The TaxLine objects connected to this shipping line.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<TaxLine>? taxLines { get; set; } = null;

    /// <summary>
    /// Returns the title of the shipping line.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}