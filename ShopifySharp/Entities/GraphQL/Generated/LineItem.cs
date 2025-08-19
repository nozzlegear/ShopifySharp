#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The `LineItem` object represents a single product or service that a customer purchased in an
/// [order](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order).
/// Each line item is associated with a
/// [product variant](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant)
/// and can have multiple [discount allocations](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountAllocation).
/// Line items contain details about what was purchased, including the product variant, quantity, pricing,
/// and fulfillment status.
/// Use the `LineItem` object to manage the following processes:
/// - [Track the quantity of items](https://shopify.dev/docs/apps/build/orders-fulfillment/order-management-apps/build-fulfillment-solutions)
/// ordered, fulfilled, and unfulfilled.
/// - [Calculate prices](https://shopify.dev/docs/apps/build/orders-fulfillment/order-management-apps/edit-orders), including discounts and taxes.
/// - Manage fulfillment through [fulfillment services](https://shopify.dev/docs/apps/build/orders-fulfillment/fulfillment-service-apps).
/// - Manage [returns](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/build-return-management) and [exchanges](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/manage-exchanges).
/// - Handle [subscriptions](https://shopify.dev/docs/apps/build/purchase-options/subscriptions) and recurring orders.
/// Line items can also include custom attributes and properties, allowing merchants to add specific details
/// about each item in an order. Learn more about
/// [managing orders and fulfillment](https://shopify.dev/docs/apps/build/orders-fulfillment).
/// </summary>
public record LineItem : IGraphQLObject, INode
{
    /// <summary>
    /// Whether the line item can be restocked.
    /// </summary>
    [JsonPropertyName("canRestock")]
    [Obsolete("Use `restockable` instead.")]
    public bool? canRestock { get; set; } = null;

    /// <summary>
    /// The subscription contract associated with this line item.
    /// </summary>
    [JsonPropertyName("contract")]
    public SubscriptionContract? contract { get; set; } = null;

    /// <summary>
    /// The number of units ordered, excluding refunded and removed units.
    /// </summary>
    [JsonPropertyName("currentQuantity")]
    public int? currentQuantity { get; set; } = null;

    /// <summary>
    /// A list of attributes that represent custom features or special requests.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; } = null;

    /// <summary>
    /// The discounts that have been allocated to the line item by discount
    /// applications, including discounts allocated to refunded and removed quantities.
    /// </summary>
    [JsonPropertyName("discountAllocations")]
    public ICollection<DiscountAllocation>? discountAllocations { get; set; } = null;

    /// <summary>
    /// The total discounted price of the line item in shop currency, including
    /// refunded and removed quantities. This value doesn't include order-level discounts.
    /// </summary>
    [JsonPropertyName("discountedTotal")]
    [Obsolete("Use `discountedTotalSet` instead.")]
    public decimal? discountedTotal { get; set; } = null;

    /// <summary>
    /// The total discounted price of the line item in shop and presentment
    /// currencies, including refunded and removed quantities. This value doesn't
    /// include order-level discounts. Code-based discounts aren't included by default.
    /// </summary>
    [JsonPropertyName("discountedTotalSet")]
    public MoneyBag? discountedTotalSet { get; set; } = null;

    /// <summary>
    /// The approximate unit price of the line item in shop currency. This value
    /// includes line-level discounts and discounts applied to refunded and removed
    /// quantities. It doesn't include order-level or code-based discounts.
    /// </summary>
    [JsonPropertyName("discountedUnitPrice")]
    [Obsolete("Use `discountedUnitPriceSet` instead.")]
    public decimal? discountedUnitPrice { get; set; } = null;

    /// <summary>
    /// The approximate unit price of the line item in shop and presentment
    /// currencies. This value includes discounts applied to refunded and removed quantities.
    /// </summary>
    [JsonPropertyName("discountedUnitPriceAfterAllDiscountsSet")]
    public MoneyBag? discountedUnitPriceAfterAllDiscountsSet { get; set; } = null;

    /// <summary>
    /// The approximate unit price of the line item in shop and presentment
    /// currencies. This value includes line-level discounts and discounts applied to
    /// refunded and removed quantities. It doesn't include order-level or code-based discounts.
    /// </summary>
    [JsonPropertyName("discountedUnitPriceSet")]
    public MoneyBag? discountedUnitPriceSet { get; set; } = null;

    /// <summary>
    /// The duties associated with the line item.
    /// </summary>
    [JsonPropertyName("duties")]
    public ICollection<Duty>? duties { get; set; } = null;

    /// <summary>
    /// The total number of units to fulfill.
    /// </summary>
    [JsonPropertyName("fulfillableQuantity")]
    [Obsolete("Use [FulfillmentOrderLineItem#remainingQuantity](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrderLineItem#field-fulfillmentorderlineitem-remainingquantity) instead.")]
    public int? fulfillableQuantity { get; set; } = null;

    /// <summary>
    /// The fulfillment service that stocks the product variant belonging to a line item.
    /// This is a third-party fulfillment service in the following scenarios:
    /// **Scenario 1**
    /// - The product variant is stocked by a single fulfillment service.
    /// - The [FulfillmentService](/api/admin-graphql/latest/objects/FulfillmentService)
    /// is a third-party fulfillment service. Third-party fulfillment services don't
    /// have a handle with the value `manual`.
    /// **Scenario 2**
    /// - Multiple fulfillment services stock the product variant.
    /// - The last time that the line item was unfulfilled, it was awaiting
    /// fulfillment by a third-party fulfillment service. Third-party fulfillment
    /// services don't have a handle with the value `manual`.
    /// If none of the above conditions are met, then the fulfillment service has the `manual` handle.
    /// </summary>
    [JsonPropertyName("fulfillmentService")]
    [Obsolete(" The [relationship between a product variant and a fulfillment service was changed](/changelog/fulfillment-service-sku-sharing). A [ProductVariant](/api/admin-graphql/latest/objects/ProductVariant) can be stocked by multiple fulfillment services. As a result, we recommend that you use the [inventoryItem field](/api/admin-graphql/latest/objects/ProductVariant#field-productvariant-inventoryitem) if you need to determine where a product variant is stocked.  If you need to determine whether a product is a gift card, then you should continue to use this field until an alternative is available.  Altering the locations which stock a product variant wont change the value of this field for existing orders.  Learn about [managing inventory quantities and states](/apps/fulfillment/inventory-management-apps/quantities-states). ")]
    public FulfillmentService? fulfillmentService { get; set; } = null;

    /// <summary>
    /// The line item's fulfillment status. Returns 'fulfilled' if fulfillableQuantity >= quantity,
    /// 'partial' if  fulfillableQuantity > 0, and 'unfulfilled' otherwise.
    /// </summary>
    [JsonPropertyName("fulfillmentStatus")]
    [Obsolete("Use [FulfillmentOrderLineItem#remainingQuantity](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrderLineItem#field-fulfillmentorderlineitem-remainingquantity) instead")]
    public string? fulfillmentStatus { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The image associated to the line item's variant.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// Whether the line item represents the purchase of a gift card.
    /// </summary>
    [JsonPropertyName("isGiftCard")]
    public bool? isGiftCard { get; set; } = null;

    /// <summary>
    /// The line item group associated to the line item.
    /// </summary>
    [JsonPropertyName("lineItemGroup")]
    public LineItemGroup? lineItemGroup { get; set; } = null;

    /// <summary>
    /// Whether the line item can be edited or not.
    /// </summary>
    [JsonPropertyName("merchantEditable")]
    public bool? merchantEditable { get; set; } = null;

    /// <summary>
    /// The title of the product, optionally appended with the title of the variant (if applicable).
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The total number of units that can't be fulfilled. For example, if items have
    /// been refunded, or the item is not something that can be fulfilled, like a tip. Please see the [FulfillmentOrder](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrder)
    /// object for more fulfillment details.
    /// </summary>
    [JsonPropertyName("nonFulfillableQuantity")]
    public int? nonFulfillableQuantity { get; set; } = null;

    /// <summary>
    /// In shop currency, the total price of the line item when the order was created.
    /// This value doesn't include discounts.
    /// </summary>
    [JsonPropertyName("originalTotal")]
    [Obsolete("Use `originalTotalSet` instead.")]
    public decimal? originalTotal { get; set; } = null;

    /// <summary>
    /// In shop and presentment currencies, the total price of the line item when the order was created.
    /// This value doesn't include discounts.
    /// </summary>
    [JsonPropertyName("originalTotalSet")]
    public MoneyBag? originalTotalSet { get; set; } = null;

    /// <summary>
    /// In shop currency, the unit price of the line item when the order was created. This value doesn't include discounts.
    /// </summary>
    [JsonPropertyName("originalUnitPrice")]
    [Obsolete("Use `originalUnitPriceSet` instead.")]
    public decimal? originalUnitPrice { get; set; } = null;

    /// <summary>
    /// In shop and presentment currencies, the unit price of the line item when the
    /// order was created. This value doesn't include discounts.
    /// </summary>
    [JsonPropertyName("originalUnitPriceSet")]
    public MoneyBag? originalUnitPriceSet { get; set; } = null;

    /// <summary>
    /// The Product object associated with this line item's variant.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The number of units ordered, including refunded and removed units.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The number of units ordered, excluding refunded units and removed units.
    /// </summary>
    [JsonPropertyName("refundableQuantity")]
    public int? refundableQuantity { get; set; } = null;

    /// <summary>
    /// Whether physical shipping is required for the variant.
    /// </summary>
    [JsonPropertyName("requiresShipping")]
    public bool? requiresShipping { get; set; } = null;

    /// <summary>
    /// Whether the line item can be restocked.
    /// </summary>
    [JsonPropertyName("restockable")]
    public bool? restockable { get; set; } = null;

    /// <summary>
    /// The selling plan details associated with the line item.
    /// </summary>
    [JsonPropertyName("sellingPlan")]
    public LineItemSellingPlan? sellingPlan { get; set; } = null;

    /// <summary>
    /// The variant SKU number.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

    /// <summary>
    /// Staff attributed to the line item.
    /// </summary>
    [JsonPropertyName("staffMember")]
    public StaffMember? staffMember { get; set; } = null;

    /// <summary>
    /// Whether the variant is taxable.
    /// </summary>
    [JsonPropertyName("taxable")]
    public bool? taxable { get; set; } = null;

    /// <summary>
    /// The taxes charged for the line item, including taxes charged for refunded and removed quantities.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<TaxLine>? taxLines { get; set; } = null;

    /// <summary>
    /// The title of the product at time of order creation.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The total discount allocated to the line item in shop currency, including the
    /// total allocated to refunded and removed quantities. This value doesn't include
    /// order-level discounts.
    /// </summary>
    [JsonPropertyName("totalDiscount")]
    [Obsolete("Use `totalDiscountSet` instead.")]
    public decimal? totalDiscount { get; set; } = null;

    /// <summary>
    /// The total discount allocated to the line item in shop and presentment
    /// currencies, including the total allocated to refunded and removed quantities.
    /// This value doesn't include order-level discounts.
    /// </summary>
    [JsonPropertyName("totalDiscountSet")]
    public MoneyBag? totalDiscountSet { get; set; } = null;

    /// <summary>
    /// In shop currency, the total discounted price of the unfulfilled quantity for the line item.
    /// </summary>
    [JsonPropertyName("unfulfilledDiscountedTotal")]
    [Obsolete("Use `unfulfilledDiscountedTotalSet` instead.")]
    public decimal? unfulfilledDiscountedTotal { get; set; } = null;

    /// <summary>
    /// In shop and presentment currencies, the total discounted price of the unfulfilled quantity for the line item.
    /// </summary>
    [JsonPropertyName("unfulfilledDiscountedTotalSet")]
    public MoneyBag? unfulfilledDiscountedTotalSet { get; set; } = null;

    /// <summary>
    /// In shop currency, the total price of the unfulfilled quantity for the line item. This value doesn't include discounts.
    /// </summary>
    [JsonPropertyName("unfulfilledOriginalTotal")]
    [Obsolete("Use `unfulfilledOriginalTotalSet` instead.")]
    public decimal? unfulfilledOriginalTotal { get; set; } = null;

    /// <summary>
    /// In shop and presentment currencies, the total price of the unfulfilled
    /// quantity for the line item. This value doesn't include discounts.
    /// </summary>
    [JsonPropertyName("unfulfilledOriginalTotalSet")]
    public MoneyBag? unfulfilledOriginalTotalSet { get; set; } = null;

    /// <summary>
    /// The number of units not yet fulfilled.
    /// </summary>
    [JsonPropertyName("unfulfilledQuantity")]
    public int? unfulfilledQuantity { get; set; } = null;

    /// <summary>
    /// The Variant object associated with this line item.
    /// </summary>
    [JsonPropertyName("variant")]
    public ProductVariant? variant { get; set; } = null;

    /// <summary>
    /// The title of the variant at time of order creation.
    /// </summary>
    [JsonPropertyName("variantTitle")]
    public string? variantTitle { get; set; } = null;

    /// <summary>
    /// The name of the vendor who made the variant.
    /// </summary>
    [JsonPropertyName("vendor")]
    public string? vendor { get; set; } = null;
}