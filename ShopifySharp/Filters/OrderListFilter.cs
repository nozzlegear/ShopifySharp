using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters;

/// <summary>
/// Options for filtering lists of orders.
/// </summary>
public class OrderListFilter : ListFilter<Order>
{
    /// <summary>
    /// Restricts results to those with the given status. Known values are "open", "closed", "cancelled" and "any".
    /// </summary>
    [JsonProperty("status")]
    public string Status { get; set; }

    /// <summary>
    /// Restricts results to those with the given financial status. Known values are "authorized", "paid", "pending", "partially_paid", "partially_refunded", "refunded" and "voided".
    /// </summary>
    [JsonProperty("financial_status")]
    public string FinancialStatus { get; set; }

    /// <summary>
    /// Restricts results to those with the given fulfillment status. Known values are "shipped", "partial", "unshipped", "any" and "unfulfilled". Default: any. 
    /// </summary>
    [JsonProperty("fulfillment_status")]
    public string FulfillmentStatus { get; set; }
        
    /// <summary>
    /// Restrict results to those created at or after date.
    /// </summary>
    [JsonProperty("created_at_min")]
    public DateTimeOffset? CreatedAtMin { get; set; }

    /// <summary>
    /// Restrict results to those created at or after date.
    /// </summary>
    [JsonProperty("created_at_max")]
    public DateTimeOffset? CreatedAtMax { get; set; }
        
    /// <summary>
    /// Restrict results to those created at or before date.
    /// </summary>
    [JsonProperty("updated_at_min")]
    public DateTimeOffset? UpdatedAtMin { get; set; }

    /// <summary>
    /// Restrict results to those last updated at or before date.
    /// </summary>
    [JsonProperty("updated_at_max")]
    public DateTimeOffset? UpdatedAtMax { get; set; }
        
    /// <summary>
    /// Show orders imported after date.
    /// </summary>
    [JsonProperty("processed_at_min")]
    public DateTimeOffset? ProcessedAtMin { get; set; }

    /// <summary>
    /// Show orders imported before date.
    /// </summary>
    [JsonProperty("processed_at_max")]
    public DateTimeOffset? ProcessedAtMax { get; set; }

    /// <summary>
    /// Show orders attributed to a specific app. Valid values are the app ID to filter on (eg. 123) or a value of "current" to only show orders for the app currently consuming the API.
    /// </summary>
    [JsonProperty("attribution_app_id")]
    public string AttributionAppId { get; set; }
        
    /// <summary>
    /// Retrieve only orders specified by a comma-separated list of order IDs.
    /// </summary>
    [JsonProperty("ids")]
    public IEnumerable<long> Ids { get; set; }
        
    /// <summary>
    /// Retrieve only orders specified by a comma-separated list of order IDs.
    /// </summary>
    [JsonProperty("since_id")]
    public long? SinceId { get; set; }
}