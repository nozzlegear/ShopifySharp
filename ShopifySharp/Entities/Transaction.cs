using Newtonsoft.Json;
using System;

namespace ShopifySharp;

/// <summary>
/// An object representing a Shopify transaction.
/// </summary>
public class Transaction : ShopifyObject
{
    /// <summary>
    /// The amount of money that the transaction was for.
    /// </summary>
    [JsonProperty("amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// The authorization code associated with the transaction.
    /// </summary>
    [JsonProperty("authorization")]
    public string Authorization { get; set; }

    /// <summary>
    /// The date and time when the Shopify Payments authorization expires.
    /// </summary>
    [JsonProperty("authorization_expires_at")]
    public DateTimeOffset? AuthorizationExpiresAt { get; set; }

    /// <summary>
    /// The date and time when the transaction was created.
    /// </summary>
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// The unique identifier for the device.
    /// </summary>
    [JsonProperty("device_id")]
    public long? DeviceId { get; set; }

    /// <summary>
    /// The name of the gateway the transaction was issued through.
    /// </summary>
    [JsonProperty("gateway")]
    public string Gateway { get; set; }

    /// <summary>
    /// The origin of the transaction. This is set by Shopify and cannot be overridden. Example values include: 'web', 'pos', 'iphone', 'android'.
    /// </summary>
    [JsonProperty("source_name")]
    public string SourceName { get; private set; }

    /// <summary>
    /// The origin of the transaction. Set to "external" to create a cash transaction for the associated order.
    /// </summary>
    [JsonProperty("source")]
    public string Source { get; set; }

    /// <summary>
    /// An object containing information about the credit card used for this transaction.
    /// </summary>
    [JsonProperty("payment_details")]
    public PaymentDetails PaymentDetails { get; set; }

    /// <summary>
    /// The kind of transaction. Known values are 'authorization', 'capture', 'sale', 'void' and 'refund'.
    /// </summary>
    [JsonProperty("kind")]
    public string Kind { get; set; }

    /// <summary>
    /// A unique numeric identifier for the order.
    /// </summary>
    [JsonProperty("order_id")]
    public long? OrderId { get; set; }

    /// <summary>
    /// Shopify does not currently offer documentation for this object.
    /// </summary>
    [JsonProperty("receipt")]
    public object Receipt { get; set; }

    /// <summary>
    /// A standardized error code, e.g. 'incorrect_number', independent of the payment provider. Value can be null. A full list of known values can be found at https://help.shopify.com/api/reference/transaction.
    /// </summary>
    [JsonProperty("error_code")]
    public string ErrorCode { get; set; }

    /// <summary>
    /// The status of the transaction. Valid values are: pending, failure, success or error.
    /// </summary>
    [JsonProperty("status")]
    public string Status { get; set; }

    /// <summary>
    /// Whether the transaction is for testing purposes.
    /// </summary>
    [JsonProperty("test")]
    public bool? Test { get; set; }

    /// <summary>
    /// The unique identifier for the user.
    /// </summary>
    [JsonProperty("user_id")]
    public long? UserId { get; set; }

    /// <summary>
    /// The three letter code (ISO 4217) for the currency used for the payment.
    /// </summary>
    [JsonProperty("currency")]
    public string Currency { get; set; }

    /// <summary>
    /// This property is undocumented by Shopify.
    /// </summary>
    [JsonProperty("message")]
    public string Message { get; set; }

    /// <summary>
    /// This property is undocumented by Shopify.
    /// </summary>
    [JsonProperty("location_id")]
    public long? LocationId { get; set; }

    /// <summary>
    /// This property is undocumented by Shopify.
    /// </summary>
    [JsonProperty("parent_id")]
    public long? ParentId { get; set; }
        
    /// <summary>
    /// This property is undocumented by Shopify.
    /// </summary>
    [JsonProperty("processed_at")]
    public DateTimeOffset? ProcessedAt { get; set; }

    /// <summary>
    /// The maximum amount that can be refunded
    /// </summary>
    [JsonProperty("maximum_refundable")]
    public decimal? MaximumRefundable { get; set; }

    /// <summary>
    /// An adjustment on the transaction showing the amount lost or gained due to fluctuations in the currency exchange rate
    /// Requires the header X-Shopify-Api-Features = include-currency-exchange-adjustments
    /// </summary>
    [JsonProperty("currency_exchange_adjustment")]
    public CurrencyExchangeAdjustment CurrencyExchangeAdjustment { get; set; }

    /// <summary>
    /// payments_refund_attributes are available only if the following criteria apply:
    /// The store is on a Shopify Plus plan.
    /// The store uses Shopify Payments.
    /// The order transaction kind is either refund or void.
    /// If the criteria isn't met, then the payments_refund_attributes property is omitted.
    /// </summary>
    [JsonProperty("payments_refund_attributes")]
    public PaymentsRefundAttributes PaymentsRefundAttributes { get; set; }

    /// <summary>
    /// Unique ID is now sent to payment providers when a customer pays at checkout. 
    /// This ID can be used to match order information between Shopify and payment providers. An Order can have more than one Payment ID. 
    /// It only includes successful or pending payments. It does not include captures and refunds.
    /// </summary>
    [JsonProperty("payment_id")]
    public string PaymentId { get; set; }

    /// <summary>
    /// Specifies the available amount with currency to capture on the gateway in shop and presentment currencies. Only available when an amount is capturable or manually mark as paid.
    /// </summary>
    [JsonProperty("total_unsettled_set")]
    public PriceSet TotalUnsettledSet { get; set; }

    #nullable enable
    /// <summary>
    /// The reason for the adjustment that is associated with the transaction. If the source_type is not an adjustment, the value will be null.
    /// </summary>
    [JsonProperty("adjustment_reason")]
    public string? AdjustmentReason { get; set; }
    #nullable disable
}
