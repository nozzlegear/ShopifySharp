using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters;

public class CheckoutCountFilter : Parameterizable
{
    /// <summary>
    /// Restrict results to after the specified ID.
    /// </summary>
    [JsonProperty("since_id")]
    public long? SinceId { get; set; }
        
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
    /// Restrict results to those with the given status. Known values: <c>"open"</c>, <c>"closed"</c>. Default: <c>"open"</c>.
    /// </summary>
    [JsonProperty("status")]
    public string Status { get; set; }
}