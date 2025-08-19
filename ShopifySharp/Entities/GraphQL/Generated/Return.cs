#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The `Return` object represents the intent of a buyer to ship one or more items from an order back to a merchant
/// or a third-party fulfillment location. A return is associated with an
/// [order](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order)
/// and can include multiple return [line items](https://shopify.dev/docs/api/admin-graphql/latest/objects/LineItem).
/// Each return has a [status](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps#return-statuses),
/// which indicates the state of the return.
/// Use the `Return` object to capture the financial, logistical,
/// and business intent of a return. For example, you can identify eligible items for a return and issue customers
/// a refund for returned items on behalf of the merchant.
/// Learn more about providing a
/// [return management workflow](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/build-return-management)
/// for merchants. You can also manage [exchanges](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/manage-exchanges),
/// [reverse fulfillment orders](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/manage-reverse-fulfillment-orders),
/// and [reverse deliveries](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/manage-reverse-deliveries)
/// on behalf of merchants.
/// </summary>
public record Return : IGraphQLObject, INode
{
    /// <summary>
    /// The date and time when the return was closed.
    /// </summary>
    [JsonPropertyName("closedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? closedAt { get; set; } = null;

    /// <summary>
    /// The date and time when the return was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// Additional information about the declined return.
    /// </summary>
    [JsonPropertyName("decline")]
    public ReturnDecline? decline { get; set; } = null;

    /// <summary>
    /// The exchange line items attached to the return.
    /// </summary>
    [JsonPropertyName("exchangeLineItems")]
    public ExchangeLineItemConnection? exchangeLineItems { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the return.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The order that the return belongs to.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The list of refunds associated with the return.
    /// </summary>
    [JsonPropertyName("refunds")]
    public RefundConnection? refunds { get; set; } = null;

    /// <summary>
    /// The date and time when the return was approved.
    /// </summary>
    [JsonPropertyName("requestApprovedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? requestApprovedAt { get; set; } = null;

    /// <summary>
    /// The return line items attached to the return.
    /// </summary>
    [JsonPropertyName("returnLineItems")]
    public ReturnLineItemTypeConnection? returnLineItems { get; set; } = null;

    /// <summary>
    /// The return shipping fees for the return.
    /// </summary>
    [JsonPropertyName("returnShippingFees")]
    public ICollection<ReturnShippingFee>? returnShippingFees { get; set; } = null;

    /// <summary>
    /// The list of reverse fulfillment orders for the return.
    /// </summary>
    [JsonPropertyName("reverseFulfillmentOrders")]
    public ReverseFulfillmentOrderConnection? reverseFulfillmentOrders { get; set; } = null;

    /// <summary>
    /// The status of the return.
    /// </summary>
    [JsonPropertyName("status")]
    public ReturnStatus? status { get; set; } = null;

    /// <summary>
    /// A suggested financial outcome for the return.
    /// </summary>
    [JsonPropertyName("suggestedFinancialOutcome")]
    public SuggestedReturnFinancialOutcome? suggestedFinancialOutcome { get; set; } = null;

    /// <summary>
    /// A suggested refund for the return.
    /// </summary>
    [JsonPropertyName("suggestedRefund")]
    [Obsolete("Use `suggestedFinancialOutcome` instead.")]
    public SuggestedReturnRefund? suggestedRefund { get; set; } = null;

    /// <summary>
    /// The sum of all return line item quantities for the return.
    /// </summary>
    [JsonPropertyName("totalQuantity")]
    public int? totalQuantity { get; set; } = null;
}