using Newtonsoft.Json;

namespace ShopifySharp;

public class OrderCancelOptions
{
    /// <summary>
    /// Amount to refund (decimal ex: 21.20).
    /// If set, Shopify will attempt to void/refund the payment depending on the status.
    /// </summary>
    [JsonProperty("amount")]
    public decimal? RefundAmount { get; set; }

    /// <summary>
    /// The three letter code (ISO 4217) for the currency used for the refund.
    /// The currency of the refund that's issued when the order is canceled. 
    /// Required for multi-currency orders whenever the `amount` property is provided.
    /// </summary>
    [JsonProperty("currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Restock the items for this order back to your store.
    /// </summary>
    [JsonProperty("restock")]
    public bool? Restock { get; set; }

    /// <summary>
    /// The reason for the order cancellation
    /// Must be: customer, inventory, fraud or other.
    /// </summary>
    [JsonProperty("reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Send an email to the customer notifying them of the cancellation.
    /// </summary>
    [JsonProperty("email")]
    public bool? SendCancellationReceipt { get; set; }
}