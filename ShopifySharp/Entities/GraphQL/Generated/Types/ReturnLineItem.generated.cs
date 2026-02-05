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
/// An item that a customer returns from a fulfilled order. Links to the original [`FulfillmentLineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/FulfillmentLineItem)
/// and tracks quantities through the return process.
/// The line item includes the customer's reason for returning the item and any
/// additional notes. It also tracks processing status with separate quantities for
/// items that are processable, processed, refundable, and refunded. You can apply
/// optional restocking fees to cover handling costs.
/// Learn more about [creating a return](https://shopify.dev/docs/api/admin-graphql/latest/mutations/returnCreate).
/// </summary>
public record ReturnLineItem : IGraphQLObject, INode, IReturnLineItemType
{
    /// <summary>
    /// A note from the customer that describes the item to be returned. Maximum length: 300 characters.
    /// </summary>
    [JsonPropertyName("customerNote")]
    public string? customerNote { get; set; } = null;

    /// <summary>
    /// The fulfillment line item from which items are returned.
    /// </summary>
    [JsonPropertyName("fulfillmentLineItem")]
    public FulfillmentLineItem? fulfillmentLineItem { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The quantity that can be processed.
    /// </summary>
    [JsonPropertyName("processableQuantity")]
    public int? processableQuantity { get; set; } = null;

    /// <summary>
    /// The quantity that has been processed.
    /// </summary>
    [JsonPropertyName("processedQuantity")]
    public int? processedQuantity { get; set; } = null;

    /// <summary>
    /// The quantity being returned.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The quantity that can be refunded.
    /// </summary>
    [JsonPropertyName("refundableQuantity")]
    public int? refundableQuantity { get; set; } = null;

    /// <summary>
    /// The quantity that was refunded.
    /// </summary>
    [JsonPropertyName("refundedQuantity")]
    public int? refundedQuantity { get; set; } = null;

    /// <summary>
    /// The restocking fee for the return line item.
    /// </summary>
    [JsonPropertyName("restockingFee")]
    public RestockingFee? restockingFee { get; set; } = null;

    /// <summary>
    /// The reason for returning the item.
    /// </summary>
    [JsonPropertyName("returnReason")]
    [Obsolete("Use `returnReasonDefinition` instead. This field will be removed in the future.")]
    public ReturnReason? returnReason { get; set; } = null;

    /// <summary>
    /// The standardized reason for why the item is being returned.
    /// </summary>
    [JsonPropertyName("returnReasonDefinition")]
    public ReturnReasonDefinition? returnReasonDefinition { get; set; } = null;

    /// <summary>
    /// Additional information about the reason for the return. Maximum length: 255 characters.
    /// </summary>
    [JsonPropertyName("returnReasonNote")]
    public string? returnReasonNote { get; set; } = null;

    /// <summary>
    /// The total weight of the item.
    /// </summary>
    [JsonPropertyName("totalWeight")]
    public Weight? totalWeight { get; set; } = null;

    /// <summary>
    /// The quantity that has't been processed.
    /// </summary>
    [JsonPropertyName("unprocessedQuantity")]
    public int? unprocessedQuantity { get; set; } = null;

    /// <summary>
    /// The total line price after all discounts on the line item, including both line
    /// item level discounts and code-based line item discounts, are applied.
    /// </summary>
    [JsonPropertyName("withCodeDiscountedTotalPriceSet")]
    public MoneyBag? withCodeDiscountedTotalPriceSet { get; set; } = null;
}