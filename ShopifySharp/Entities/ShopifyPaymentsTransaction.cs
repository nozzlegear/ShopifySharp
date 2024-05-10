using Newtonsoft.Json;
using System;

namespace ShopifySharp;

/// <summary>
/// An object representing a Shopify payments transction.
/// </summary>
public class ShopifyPaymentsTransaction : ShopifyObject
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("test")]
    public bool Test { get; set; }

    [JsonProperty("payout_id")]
    public long? PayoutId { get; set; }

    [JsonProperty("payout_status")]
    public string PayoutStatus { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("amount")]
    public decimal? Amount { get; set; }

    [JsonProperty("fee")]
    public decimal? Fee { get; set; }

    [JsonProperty("net")]
    public decimal? Net { get; set; }

    [JsonProperty("source_id")]
    public long? SourceId { get; set; }

    [JsonProperty("source_type")]
    public string SourceType { get; set; }

    [JsonProperty("source_order_transaction_id")]
    public long? SourceOrderTransactionId { get; set; }

    [JsonProperty("source_order_id")]
    public long? SourceOrderId { get; set; }

    [JsonProperty("processed_at")]
    public DateTimeOffset? ProcessedAt { get; set; }


}