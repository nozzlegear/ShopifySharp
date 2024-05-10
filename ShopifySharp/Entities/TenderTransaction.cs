using Newtonsoft.Json;
using System;

namespace ShopifySharp;

/// <summary>
/// An object representing a Shopify tender transaction.
/// Each tender transaction represents money passing between the merchant and a customer.
/// A tender transaction with a positive amount represents a transaction where the customer paid money to the merchant.
/// A negative amount represents a transaction where the merchant refunded money back to the customer.
/// Tender transactions represent transactions that modify the shop's balance.
/// </summary>
public class TenderTransaction : ShopifyObject
{
    /// <summary>
    /// The ID of the order that the tender transaction belongs to.
    /// </summary>
    [JsonProperty("order_id")]
    public long? OrderId { get; set; }

    /// <summary>
    /// The amount of the tender transaction in the shop's currency.
    /// </summary>
    [JsonProperty("amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// The three letter code (ISO 4217) for the currency used for the tender transaction.
    /// </summary>
    [JsonProperty("currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The ID of the user logged into the Shopify POS device that processed the tender transaction, if applicable.
    /// </summary>
    [JsonProperty("user_id")]
    public long? UserId { get; set; }

    /// <summary>
    /// Whether the tender transaction is a test transaction.
    /// </summary>
    [JsonProperty("test")]
    public bool? Test { get; set; }

    /// <summary>
    /// The date and time when the tender transaction was processed.
    /// </summary>
    [JsonProperty("processed_at")]
    public DateTimeOffset? ProcessedAt { get; set; }

    /// <summary>
    /// The remote (gateway) reference associated with the tender.
    /// </summary>
    [JsonProperty("remote_reference")]
    public string RemoteReference { get; set; }

    /// <summary>
    /// An object containing information about the payment instrument used for this transaction.
    /// </summary>
    [JsonProperty("payment_details")]
    public PaymentDetails PaymentDetails { get; set; }

    /// <summary>
    /// The payment method used for this transaction.
    /// </summary>
    [JsonProperty("payment_method")]
    public string PaymentMethod { get; set; }
}