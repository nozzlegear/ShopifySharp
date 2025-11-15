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
/// The input fields for a line item to create for an order.
/// </summary>
public record OrderCreateLineItemInput : GraphQLInputObject<OrderCreateLineItemInput>
{
    /// <summary>
    /// The handle of a fulfillment service that stocks the product variant belonging to a line item.
    ///               This is a third-party fulfillment service in the following scenarios:
    ///               **Scenario 1**
    ///               - The product variant is stocked by a single fulfillment service.
    ///               - The
    /// [FulfillmentService](/api/admin-graphql/latest/objects/FulfillmentService) is
    /// a third-party fulfillment service. Third-party fulfillment services don't have
    /// a handle with the value `manual`.
    ///               **Scenario 2**
    ///               - Multiple fulfillment services stock the product variant.
    ///               - The last time that the line item was unfulfilled, it was
    /// awaiting fulfillment by a third-party fulfillment service. Third-party
    /// fulfillment services don't have a handle with the value `manual`.
    ///               If none of the above conditions are met, then the fulfillment service has the `manual` handle.
    /// </summary>
    [JsonPropertyName("fulfillmentService")]
    public string? fulfillmentService { get; set; } = null;

    /// <summary>
    /// Whether the item is a gift card. If true, then the item is not taxed or considered for shipping charges.
    /// </summary>
    [JsonPropertyName("giftCard")]
    public bool? giftCard { get; set; } = null;

    /// <summary>
    /// The price of the item before discounts have been applied in the shop currency.
    /// </summary>
    [JsonPropertyName("priceSet")]
    public MoneyBagInput? priceSet { get; set; } = null;

    /// <summary>
    /// The ID of the product that the line item belongs to. Can be `null` if the
    /// original product associated with the order is deleted at a later date.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? productId { get; set; } = null;

    /// <summary>
    /// An array of custom information for the item that has been added to the cart.
    /// Often used to provide product customization options.
    /// </summary>
    [JsonPropertyName("properties")]
    public ICollection<OrderCreateLineItemPropertyInput>? properties { get; set; } = null;

    /// <summary>
    /// The number of items that were purchased.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Whether the item requires shipping.
    /// </summary>
    [JsonPropertyName("requiresShipping")]
    public bool? requiresShipping { get; set; } = null;

    /// <summary>
    /// The item's SKU (stock keeping unit).
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

    /// <summary>
    /// Whether the item was taxable.
    /// </summary>
    [JsonPropertyName("taxable")]
    public bool? taxable { get; set; } = null;

    /// <summary>
    /// A list of tax line objects, each of which details a tax applied to the item.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<OrderCreateTaxLineInput>? taxLines { get; set; } = null;

    /// <summary>
    /// The title of the product.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The ID of the product variant. If both `productId` and `variantId` are
    /// provided, then the product ID that corresponds to the `variantId` is used.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;

    /// <summary>
    /// The title of the product variant.
    /// </summary>
    [JsonPropertyName("variantTitle")]
    public string? variantTitle { get; set; } = null;

    /// <summary>
    /// The name of the item's supplier.
    /// </summary>
    [JsonPropertyName("vendor")]
    public string? vendor { get; set; } = null;

    /// <summary>
    /// The weight of the line item. This will take precedence over the weight of the product variant, if one was specified.
    /// </summary>
    [JsonPropertyName("weight")]
    public WeightInput? weight { get; set; } = null;
}