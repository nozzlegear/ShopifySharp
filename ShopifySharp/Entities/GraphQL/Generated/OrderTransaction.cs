#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The `OrderTransaction` object represents a payment transaction that's associated with an order. An order
/// transaction is a specific action or event that happens within the context of an order, such as a customer paying
/// for a purchase or receiving a refund, or other payment-related activity.
/// Use the `OrderTransaction` object to capture the complete lifecycle of a payment, from initial
/// authorization to final settlement, including refunds and currency exchanges. Common use cases for using the
/// `OrderTransaction` object include:
/// - Processing new payments for orders
/// - Managing payment authorizations and captures
/// - Processing refunds for returned items
/// - Tracking payment status and errors
/// - Managing multi-currency transactions
/// - Handling payment gateway integrations
/// Each `OrderTransaction` object has a [`kind`](https://shopify.dev/docs/api/admin-graphql/latest/enums/OrderTransactionKind)
/// that defines the type of transaction and a [`status`](https://shopify.dev/docs/api/admin-graphql/latest/enums/OrderTransactionStatus)
/// that indicates the current state of the transaction. The object stores detailed information about payment
/// methods, gateway processing, and settlement details.
/// Learn more about [payment processing](https://help.shopify.com/manual/payments)
/// and [payment gateway integrations](https://www.shopify.com/ca/payment-gateways).
/// </summary>
public record OrderTransaction : IGraphQLUnionCase, IGraphQLObject, INode
{
    /// <summary>
    /// The masked account number associated with the payment method.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    public string? accountNumber { get; set; } = null;

    /// <summary>
    /// The amount of money.
    /// </summary>
    [JsonPropertyName("amount")]
    [Obsolete("Use `amountSet` instead.")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// The rounding adjustment applied on the cash amount in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amountRoundingSet")]
    public MoneyBag? amountRoundingSet { get; set; } = null;

    /// <summary>
    /// The amount and currency of the transaction in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBag? amountSet { get; set; } = null;

    /// <summary>
    /// The amount and currency of the transaction.
    /// </summary>
    [JsonPropertyName("amountV2")]
    [Obsolete("Use `amountSet` instead.")]
    public MoneyV2? amountV2 { get; set; } = null;

    /// <summary>
    /// Authorization code associated with the transaction.
    /// </summary>
    [JsonPropertyName("authorizationCode")]
    public string? authorizationCode { get; set; } = null;

    /// <summary>
    /// The time when the authorization expires. This field is available only to stores on a Shopify Plus plan.
    /// </summary>
    [JsonPropertyName("authorizationExpiresAt")]
    public DateTime? authorizationExpiresAt { get; set; } = null;

    /// <summary>
    /// Date and time when the transaction was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// An adjustment on the transaction showing the amount lost or gained  due to fluctuations in the currency exchange rate.
    /// </summary>
    [JsonPropertyName("currencyExchangeAdjustment")]
    public CurrencyExchangeAdjustment? currencyExchangeAdjustment { get; set; } = null;

    /// <summary>
    /// The Shopify Point of Sale device used to process the transaction.
    /// </summary>
    [JsonPropertyName("device")]
    public PointOfSaleDevice? device { get; set; } = null;

    /// <summary>
    /// A standardized error code, independent of the payment provider.
    /// </summary>
    [JsonPropertyName("errorCode")]
    public OrderTransactionErrorCode? errorCode { get; set; } = null;

    /// <summary>
    /// The transaction fees charged on the order transaction. Only present for Shopify Payments transactions.
    /// </summary>
    [JsonPropertyName("fees")]
    public ICollection<TransactionFee>? fees { get; set; } = null;

    /// <summary>
    /// The human-readable payment gateway name used to process the transaction.
    /// </summary>
    [JsonPropertyName("formattedGateway")]
    public string? formattedGateway { get; set; } = null;

    /// <summary>
    /// The payment gateway used to process the transaction.
    /// </summary>
    [JsonPropertyName("gateway")]
    public string? gateway { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The kind of transaction.
    /// </summary>
    [JsonPropertyName("kind")]
    public OrderTransactionKind? kind { get; set; } = null;

    /// <summary>
    /// The physical location where the transaction was processed.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// Whether the transaction can be manually captured.
    /// </summary>
    [JsonPropertyName("manuallyCapturable")]
    public bool? manuallyCapturable { get; set; } = null;

    /// <summary>
    /// Whether the transaction is processed by manual payment gateway.
    /// </summary>
    [JsonPropertyName("manualPaymentGateway")]
    public bool? manualPaymentGateway { get; set; } = null;

    /// <summary>
    /// Specifies the available amount to refund on the gateway.
    /// This value is only available for transactions of type `SuggestedRefund`.
    /// </summary>
    [JsonPropertyName("maximumRefundable")]
    [Obsolete("Use `maximumRefundableV2` instead.")]
    public decimal? maximumRefundable { get; set; } = null;

    /// <summary>
    /// Specifies the available amount with currency to refund on the gateway.
    /// This value is only available for transactions of type `SuggestedRefund`.
    /// </summary>
    [JsonPropertyName("maximumRefundableV2")]
    public MoneyV2? maximumRefundableV2 { get; set; } = null;

    /// <summary>
    /// Whether the transaction can be captured multiple times.
    /// </summary>
    [JsonPropertyName("multiCapturable")]
    public bool? multiCapturable { get; set; } = null;

    /// <summary>
    /// The associated order.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The associated parent transaction, for example the authorization of a capture.
    /// </summary>
    [JsonPropertyName("parentTransaction")]
    public OrderTransaction? parentTransaction { get; set; } = null;

    /// <summary>
    /// The payment details for the transaction.
    /// </summary>
    [JsonPropertyName("paymentDetails")]
    public PaymentDetails? paymentDetails { get; set; } = null;

    /// <summary>
    /// The payment icon to display for the transaction.
    /// </summary>
    [JsonPropertyName("paymentIcon")]
    public Image? paymentIcon { get; set; } = null;

    /// <summary>
    /// The payment ID associated with the transaction.
    /// </summary>
    [JsonPropertyName("paymentId")]
    public string? paymentId { get; set; } = null;

    /// <summary>
    /// The payment method used for the transaction. This value is `null` if the payment method is unknown.
    /// </summary>
    [JsonPropertyName("paymentMethod")]
    [Obsolete("Use `paymentIcon` instead.")]
    public PaymentMethods? paymentMethod { get; set; } = null;

    /// <summary>
    /// Date and time when the transaction was processed.
    /// </summary>
    [JsonPropertyName("processedAt")]
    public DateTime? processedAt { get; set; } = null;

    /// <summary>
    /// The transaction receipt that the payment gateway attaches to the transaction.
    /// The value of this field depends on which payment gateway processed the transaction.
    /// </summary>
    [JsonPropertyName("receiptJson")]
    public string? receiptJson { get; set; } = null;

    /// <summary>
    /// The settlement currency.
    /// </summary>
    [JsonPropertyName("settlementCurrency")]
    public CurrencyCode? settlementCurrency { get; set; } = null;

    /// <summary>
    /// The rate used when converting the transaction amount to settlement currency.
    /// </summary>
    [JsonPropertyName("settlementCurrencyRate")]
    public decimal? settlementCurrencyRate { get; set; } = null;

    /// <summary>
    /// Contains all Shopify Payments information related to an order transaction.
    /// This field is available only to stores on a Shopify Plus plan.
    /// </summary>
    [JsonPropertyName("shopifyPaymentsSet")]
    public ShopifyPaymentsTransactionSet? shopifyPaymentsSet { get; set; } = null;

    /// <summary>
    /// The status of this transaction.
    /// </summary>
    [JsonPropertyName("status")]
    public OrderTransactionStatus? status { get; set; } = null;

    /// <summary>
    /// Whether the transaction is a test transaction.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; } = null;

    /// <summary>
    /// Specifies the available amount to capture on the gateway.
    /// Only available when an amount is capturable or manually mark as paid.
    /// </summary>
    [JsonPropertyName("totalUnsettled")]
    [Obsolete("Use `totalUnsettledSet` instead.")]
    public decimal? totalUnsettled { get; set; } = null;

    /// <summary>
    /// Specifies the available amount with currency to capture on the gateway in shop and presentment currencies.
    /// Only available when an amount is capturable or manually mark as paid.
    /// </summary>
    [JsonPropertyName("totalUnsettledSet")]
    public MoneyBag? totalUnsettledSet { get; set; } = null;

    /// <summary>
    /// Specifies the available amount with currency to capture on the gateway.
    /// Only available when an amount is capturable or manually mark as paid.
    /// </summary>
    [JsonPropertyName("totalUnsettledV2")]
    [Obsolete("Use `totalUnsettledSet` instead.")]
    public MoneyV2? totalUnsettledV2 { get; set; } = null;

    /// <summary>
    /// Staff member who was logged into the Shopify POS device when the transaction was processed.
    /// </summary>
    [JsonPropertyName("user")]
    public StaffMember? user { get; set; } = null;
}