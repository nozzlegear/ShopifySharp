using Newtonsoft.Json;
using System;

namespace ShopifySharp.Filters;

public class ShopifyPaymentsDisputeListFilter : ListFilter<ShopifyPaymentsDispute>
{
    /// <summary>
    /// Restrict results to after the specified ID. 
    /// </summary>
    [JsonProperty("since_id")]
    public long? SinceId { get; set; }

    /// <summary>
    /// Return only disputes before the specified ID.
    /// </summary>
    [JsonProperty("last_id")]
    public long? LastId { get; set; }

    /// <summary>
    /// Return only disputes with the specified status.
    /// </summary>
    [JsonProperty("status")]
    public string Status { get; set; }

    /// <summary>
    /// Return only disputes with the specified initiated_at date.
    /// </summary>
    [JsonProperty("initiated_at ")]
    public DateTimeOffset? InitiatedAt { get; set; }
}