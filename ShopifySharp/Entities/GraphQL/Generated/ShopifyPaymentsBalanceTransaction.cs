#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A transaction that contributes to a Shopify Payments account balance.
/// </summary>
public record ShopifyPaymentsBalanceTransaction : IGraphQLObject, INode
{
    /// <summary>
    /// The reason for the adjustment that's associated with the transaction.
    ///             If the source_type isn't an adjustment, the value will be null.
    /// </summary>
    [JsonPropertyName("adjustmentReason")]
    public string? adjustmentReason { get; set; } = null;

    /// <summary>
    /// The adjustment orders associated to the transaction.
    /// </summary>
    [JsonPropertyName("adjustmentsOrders")]
    public ICollection<ShopifyPaymentsAdjustmentOrder>? adjustmentsOrders { get; set; } = null;

    /// <summary>
    /// The amount contributing to the balance transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// The associated order for the balance transaction.
    /// </summary>
    [JsonPropertyName("associatedOrder")]
    public ShopifyPaymentsAssociatedOrder? associatedOrder { get; set; } = null;

    /// <summary>
    /// Payout assoicated with the transaction.
    /// </summary>
    [JsonPropertyName("associatedPayout")]
    public ShopifyPaymentsBalanceTransactionAssociatedPayout? associatedPayout { get; set; } = null;

    /// <summary>
    /// The fee amount contributing to the balance transaction.
    /// </summary>
    [JsonPropertyName("fee")]
    public MoneyV2? fee { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The net amount contributing to the merchant's balance.
    /// </summary>
    [JsonPropertyName("net")]
    public MoneyV2? net { get; set; } = null;

    /// <summary>
    /// The ID of the resource leading to the transaction.
    /// </summary>
    [JsonPropertyName("sourceId")]
    public long? sourceId { get; set; } = null;

    /// <summary>
    /// The id of the
    ///             [Order Transaction](https://shopify.dev/docs/admin-api/rest/reference/orders/transaction)
    ///             that resulted in this balance transaction.
    /// </summary>
    [JsonPropertyName("sourceOrderTransactionId")]
    public long? sourceOrderTransactionId { get; set; } = null;

    /// <summary>
    /// The source type of the balance transaction.
    /// </summary>
    [JsonPropertyName("sourceType")]
    public ShopifyPaymentsSourceType? sourceType { get; set; } = null;

    /// <summary>
    /// Wether the tranaction was created in test mode.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; } = null;

    /// <summary>
    /// The date and time when the balance transaction was processed.
    /// </summary>
    [JsonPropertyName("transactionDate")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? transactionDate { get; set; } = null;

    /// <summary>
    /// The type of transaction.
    /// </summary>
    [JsonPropertyName("type")]
    public ShopifyPaymentsTransactionType? type { get; set; } = null;
}