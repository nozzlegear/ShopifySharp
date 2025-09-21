#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The `Refund` object represents a financial record of money returned to a customer from an order.
/// It provides a comprehensive view of all refunded amounts, transactions, and restocking instructions
/// associated with returning products or correcting order issues.
/// The `Refund` object provides information to:
/// - Process customer returns and issue payments back to customers
/// - Handle partial or full refunds for line items with optional inventory restocking
/// - Refund shipping costs, duties, and additional fees
/// - Issue store credit refunds as an alternative to original payment method returns
/// - Track and reconcile all financial transactions related to refunds
/// Each `Refund` object maintains detailed records of what was refunded, how much was refunded,
/// which payment transactions were involved, and any inventory restocking that occurred. The refund
/// can include multiple components such as product line items, shipping charges, taxes, duties, and
/// additional fees, all calculated with proper currency handling for international orders.
/// Refunds are always associated with an [order](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order)
/// and can optionally be linked to a [return](https://shopify.dev/docs/api/admin-graphql/latest/objects/Return)
/// if the refund was initiated through the returns process. The refund tracks both the presentment currency
/// (what the customer sees) and the shop currency for accurate financial reporting.
/// > Note:
/// > The existence of a `Refund` object doesn't guarantee that the money has been returned to the customer.
/// > The actual financial processing happens through associated
/// > [`OrderTransaction`](https://shopify.dev/docs/api/admin-graphql/latest/objects/OrderTransaction)
/// > objects, which can be in various states, such as pending, processing, success, or failure.
/// > To determine if money has actually been refunded, check the
/// > [status](https://shopify.dev/docs/api/admin-graphql/latest/objects/OrderTransaction#field-OrderTransaction.fields.status)
/// > of the associated transactions.
/// Learn more about
/// [managing returns](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/build-return-management),
/// [refunding duties](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/view-and-refund-duties), and
/// [processing refunds](https://shopify.dev/docs/api/admin-graphql/latest/mutations/refundCreate).
/// </summary>
public record Refund : IGraphQLObject, ILegacyInteroperability, INode
{
    /// <summary>
    /// The date and time when the refund was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// A list of the refunded duties as part of this refund.
    /// </summary>
    [JsonPropertyName("duties")]
    public ICollection<RefundDuty>? duties { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The optional note associated with the refund.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The order associated with the refund.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The order adjustments that are attached with the refund.
    /// </summary>
    [JsonPropertyName("orderAdjustments")]
    public OrderAdjustmentConnection? orderAdjustments { get; set; } = null;

    /// <summary>
    /// The `RefundLineItem` resources attached to the refund.
    /// </summary>
    [JsonPropertyName("refundLineItems")]
    public RefundLineItemConnection? refundLineItems { get; set; } = null;

    /// <summary>
    /// The `RefundShippingLine` resources attached to the refund.
    /// </summary>
    [JsonPropertyName("refundShippingLines")]
    public RefundShippingLineConnection? refundShippingLines { get; set; } = null;

    /// <summary>
    /// The return associated with the refund.
    /// </summary>
    [JsonPropertyName("return")]
    public Return? @return { get; set; } = null;

    /// <summary>
    /// The staff member who created the refund.
    /// </summary>
    [JsonPropertyName("staffMember")]
    public StaffMember? staffMember { get; set; } = null;

    /// <summary>
    /// The total amount across all transactions for the refund.
    /// </summary>
    [JsonPropertyName("totalRefunded")]
    [Obsolete("Use `totalRefundedSet` instead.")]
    public MoneyV2? totalRefunded { get; set; } = null;

    /// <summary>
    /// The total amount across all transactions for the refund, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("totalRefundedSet")]
    public MoneyBag? totalRefundedSet { get; set; } = null;

    /// <summary>
    /// The transactions associated with the refund.
    /// </summary>
    [JsonPropertyName("transactions")]
    public OrderTransactionConnection? transactions { get; set; } = null;

    /// <summary>
    /// The date and time when the refund was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; } = null;
}