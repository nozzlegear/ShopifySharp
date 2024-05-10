using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters;

public class EventCountFilter : Parameterizable
{
    /// <summary>
    /// Show events created at or after date and time
    /// </summary>
    [JsonProperty("created_at_min")]
    public DateTimeOffset? CreatedAtMin { get; set; }

    /// <summary>
    /// Show events created at or before date and time
    /// </summary>
    [JsonProperty("created_at_max")]
    public DateTimeOffset? CreatedAtMax { get; set; }
}