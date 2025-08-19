#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a Subscription Line.
/// </summary>
public record SubscriptionLine : IGraphQLObject
{
    /// <summary>
    /// The origin contract of the line if it was concatenated from another contract.
    /// </summary>
    [JsonPropertyName("concatenatedOriginContract")]
    public SubscriptionContract? concatenatedOriginContract { get; set; } = null;

    /// <summary>
    /// The price per unit for the subscription line in the contract's currency.
    /// </summary>
    [JsonPropertyName("currentPrice")]
    public MoneyV2? currentPrice { get; set; } = null;

    /// <summary>
    /// List of custom attributes associated to the line item.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; } = null;

    /// <summary>
    /// Discount allocations.
    /// </summary>
    [JsonPropertyName("discountAllocations")]
    public ICollection<SubscriptionDiscountAllocation>? discountAllocations { get; set; } = null;

    /// <summary>
    /// The unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Total line price including all discounts.
    /// </summary>
    [JsonPropertyName("lineDiscountedPrice")]
    public MoneyV2? lineDiscountedPrice { get; set; } = null;

    /// <summary>
    /// Describe the price changes of the line over time.
    /// </summary>
    [JsonPropertyName("pricingPolicy")]
    public SubscriptionPricingPolicy? pricingPolicy { get; set; } = null;

    /// <summary>
    /// The product ID associated with the subscription line.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? productId { get; set; } = null;

    /// <summary>
    /// The quantity of the unit selected for the subscription line.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Whether physical shipping is required for the variant.
    /// </summary>
    [JsonPropertyName("requiresShipping")]
    public bool? requiresShipping { get; set; } = null;

    /// <summary>
    /// The selling plan ID associated to the line.
    /// Indicates which selling plan was used to create this
    /// contract line initially. The selling plan ID is also used to
    /// find the associated delivery profile.
    /// The subscription contract, subscription line, or selling plan might have
    /// changed. As a result, the selling plan's attributes might not
    /// match the information on the contract.
    /// </summary>
    [JsonPropertyName("sellingPlanId")]
    public string? sellingPlanId { get; set; } = null;

    /// <summary>
    /// The selling plan name associated to the line. This name describes
    /// the order line items created from this subscription line
    /// for both merchants and customers.
    /// The value can be different from the selling plan's name, because both
    /// the selling plan's name and the subscription line's selling_plan_name
    /// attribute can be updated independently.
    /// </summary>
    [JsonPropertyName("sellingPlanName")]
    public string? sellingPlanName { get; set; } = null;

    /// <summary>
    /// Variant SKU number of the item associated with the subscription line.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

    /// <summary>
    /// Whether the variant is taxable.
    /// </summary>
    [JsonPropertyName("taxable")]
    public bool? taxable { get; set; } = null;

    /// <summary>
    /// Product title of the item associated with the subscription line.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The product variant ID associated with the subscription line.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;

    /// <summary>
    /// The image associated with the line item's variant or product.
    /// </summary>
    [JsonPropertyName("variantImage")]
    public Image? variantImage { get; set; } = null;

    /// <summary>
    /// Product variant title of the item associated with the subscription line.
    /// </summary>
    [JsonPropertyName("variantTitle")]
    public string? variantTitle { get; set; } = null;
}